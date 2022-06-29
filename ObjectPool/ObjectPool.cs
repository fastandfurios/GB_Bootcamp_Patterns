using System.Collections;
using System.Runtime.InteropServices;

namespace ObjectPool
{
    public class ObjectPool<T> where T: class
    {
        private Semaphore _semaphore;
        private ArrayList _pool;
        private readonly ICreation<T> _creator;
        private int _instanceCount;
        private int _maxInstances;

        public ObjectPool(ICreation<T> creator)
        {
        }

        public ObjectPool(ICreation<T> creator, int maxInstances)
        {
            _creator = creator;
            _maxInstances = maxInstances;
            _pool = new ArrayList();
            _semaphore = new Semaphore(0, _maxInstances);
        }

        public int Size
        {
            get
            {
                lock (_pool)
                {
                    return _pool.Count;
                }
            }
        }

        public int InstanceCount => _instanceCount;
        public int MaxInstances { get => _maxInstances; set => _maxInstances = value; }

        public T GetObject()
        {
            lock (_pool)
            {
                T thisObject = RemoveObject();
                if (thisObject != null)
                    return thisObject;

                if (InstanceCount < MaxInstances)
                    return CreateObject();

                return null;
            }
        }

        public T WaitForObject()
        {
            lock (_pool)
            {
                T thisObject = RemoveObject();
                if (thisObject != null)
                    return thisObject;

                if (InstanceCount < MaxInstances)
                    return CreateObject();
            }

            _semaphore.WaitOne();
            return WaitForObject();
        }

        public void Release(T obj)
        {
            if (obj is null)
                throw new NullReferenceException();
            lock (_pool)
            {
                var refThis = new WeakReference(obj);
                _pool.Add(refThis);
                _semaphore.Release();
            }
        }

        private T CreateObject()
        {
            T newObject = _creator.Create();
            _instanceCount++;
            return newObject;
        }

        private T RemoveObject()
        {
            while (_pool.Count > 0)
            {
                var refThis =  _pool[^1] as WeakReference;
                _pool.RemoveAt(_pool.Count - 1);
                if (refThis.Target is T thisObject)
                    return thisObject;
                _instanceCount--;
            }

            return null;
        }
    }
}
