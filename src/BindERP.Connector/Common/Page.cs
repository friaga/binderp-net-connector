using Microsoft.AspNetCore.WebUtilities;
using Newtonsoft.Json;

namespace BindERP.Connector.Common
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Page<T>
    {
        public Page()
        {
            Items = new List<T>();
        }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("value")]
        public IEnumerable<T> Items
        {
            get;
        }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("nextLink")]
        public string? NextLink
        {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("count")]
        public long Count
        {
            get;
            set;
        }

        public SearchCriteria? GetNextSearchCriteria()
        {
            SearchCriteria? criteria = null;

            if (this.NextLink is not null)
            {
                var next = new Uri(this.NextLink, UriKind.Absolute);

                var parameters = QueryHelpers.ParseQuery(next.Query);

                string? filter = null;
                string? order = null;
                long? top = null;
                long? skip = null;

                if (parameters.TryGetValue("$filter", out var rawFilter) && !string.IsNullOrWhiteSpace(rawFilter))
                {
                    filter = rawFilter;
                }

                if (parameters.TryGetValue("$orderby", out var rawOrder) && !string.IsNullOrWhiteSpace(rawOrder))
                {
                    order = rawOrder;
                }

                if (parameters.TryGetValue("$top", out var rawTop) && long.TryParse(rawTop, out long parsedTop))
                {
                    top = parsedTop;
                }

                if (parameters.TryGetValue("$skip", out var rawSkip) && long.TryParse(rawSkip, out long parsedSkip))
                {
                    skip = parsedSkip;
                }

                criteria = new SearchCriteria()
                {
                    Filter = filter,
                    OrderBy = order,
                    Top = top,
                    Skip = skip,
                };
            }

            return criteria;
        }
    }
}
