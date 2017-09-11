using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SitecoreVanilla.Features.Forms.Models.Json
{
    public class FormSection
    {
        [JsonProperty("id")]
        public string Name { get; set; }
        [JsonProperty("title")]
        public string Title { get; set; }
        [JsonProperty("instruction")]
        public Instruction Instruction { get; set; }
        [JsonProperty("help")]
        public HelpField Help { get; set; }
        [JsonProperty("fields")]
        public IDictionary<string, FormField> Fields { get; set; } 
    }
}