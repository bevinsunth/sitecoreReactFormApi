using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SitecoreVanilla.Features.Forms.Models.Json
{
    public class Form
    {
        [JsonProperty("id")]
        public string Name { get; set; }
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("steps")]
        public IDictionary<string, FormStep> Steps { get; set; }
    }
}