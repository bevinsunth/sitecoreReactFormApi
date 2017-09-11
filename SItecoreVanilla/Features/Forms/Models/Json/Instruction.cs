using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SitecoreVanilla.Features.Forms.Models.Json
{
    public class Instruction
    {
        [JsonProperty("heading")]
        public string Heading { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }
}