namespace BindERP.Connector.Common
{
    public class SearchCriteria
    {
        public string? Filter
        {
            get;
            set;
        }

        public string? OrderBy
        {
            get;
            set;
        }

        public long? Top
        {
            get;
            set;
        }

        public long? Skip
        {
            get;
            set;
        }


        public string ToQueryString()
        {
            var query    = string.Empty;
            var elements = new List<string>();

            if (!string.IsNullOrWhiteSpace(this.Filter))
            {
                elements.Add($"$filter={this.Filter.Trim()}");
            }

            if (!string.IsNullOrWhiteSpace(this.OrderBy))
            {
                elements.Add($"$orderby={this.OrderBy.Trim()}");
            }

            if (this.Top is not null && this.Top > 0)
            {
                elements.Add($"$top={this.Top}");
            }

            if (this.Skip is not null && this.Skip > 0)
            {
                elements.Add($"$skip={this.Skip}");
            }

            if (elements.Count > 0)
            {
                query = $"{string.Join("&", elements)}";
            }

            return query;
        }
    }
}
