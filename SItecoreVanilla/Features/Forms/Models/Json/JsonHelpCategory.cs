using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SitecoreVanilla.Features.Forms.Models.Json
{
    public class JsonHelpCategory
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("title")]
        public string Title { get; set; }
        [JsonProperty("topics")]
        public IEnumerable<JsonFormHelpTopic> Topics { get; set; }
        [JsonProperty("helpItems")]
        public IEnumerable<JsonHelpItem> Items { get; set; }
    }
}