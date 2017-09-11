using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SitecoreVanilla.Features.Forms.Models.Json
{
    public class FormField
    {
        [JsonProperty("id")]
        public string Name { get; set; }
        [JsonProperty("label")]
        public string Label { get; set; }
        [JsonProperty("help")]
        public HelpField Help { get; set; }
        [JsonProperty("options")]
        public IDictionary<string, string> Options { get; set; }
        [JsonProperty("validationMessages")]
        public IDictionary<string, string> ValidationMessages {get; set;}
    }
}