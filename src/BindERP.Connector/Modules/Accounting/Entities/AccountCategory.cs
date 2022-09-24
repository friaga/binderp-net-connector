using Newtonsoft.Json;

namespace BindERP.Connector.Modules.Accounting.Entities
{
    /// <summary>
    /// 
    /// </summary>
    public record AccountCategory
    {
        /// <summary>
        /// 
        /// </summary>
        public AccountCategory()
        {
            this.Groups = new List<AccountGroup>();
        }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("GLGroups")]
        public IEnumerable<AccountGroup> Groups
        {
            get;
        }
    }
}
