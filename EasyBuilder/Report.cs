namespace EasyBuilder
{
    public class Report
    {
        public Report(Builder builder)
        {
            Header = builder.Header;
            Title = builder.Title;
            Content = builder.Content;
            Table = builder.Table;
            PageNumber = builder.PageNumber;
        }

        public string Header { get; }
        public string Title { get; }
        public string Content { get; }
        public string Table { get; }
        public int PageNumber { get; }

        public override string ToString()
        {
            return $"Header={Header} \n" +
                   $"Title={Title} \n" +
                   $"Content={Content} \n" +
                   $"Table={Table} \n" +
                   $"PageNumber={PageNumber}";
        }

        public class Builder
        {
            public Builder(string header)
            {
                Header = header;
            }

            public string Header { get; }
            public string Title { get; private set; }
            public string Content { get; private set; }
            public string Table { get; private set; }
            public int PageNumber { get; private set; }

            public Builder SetTitle(string title)
            {
                Title = title;
                return this;
            }

            public Builder SetContent(string content)
            {
                Content = content;
                return this;
            }

            public Builder SetTable(string table)
            {
                Table = table;
                return this;
            }

            public Builder SetPageNumber(int pageNumber)
            {
                PageNumber = pageNumber;
                return this;
            }

            public Report Build()
                => new (this);
        }
    }
}