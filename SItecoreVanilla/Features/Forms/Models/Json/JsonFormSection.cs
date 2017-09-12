using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SitecoreVanilla.Features.Forms.Models.Json
{
    public class JsonFormSection
    {
        [JsonProperty("id")]
        public string Name { get; set; }
        [JsonProperty("title")]
        public string Title { get; set; }
        [JsonProperty("instruction")]
        public JsonFormInstruction Instruction { get; set; }
        [JsonProperty("help")]
        public JsonHelpField Help { get; set; }
        [JsonProperty("fields")]
        public IDictionary<string, JsonFormField> Fields { get; set; } 
    }
}