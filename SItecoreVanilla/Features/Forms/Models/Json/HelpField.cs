using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SitecoreVanilla.Features.Forms.Models.Json
{
    public class HelpField
    {
        [JsonProperty("helpHyperlinkText")]
        public string LinkText { get; set; }
        [JsonProperty("helpHyperlinkUrl")]
        public string Url { get; set; }
        [JsonProperty("helpTipInline")]
        public string InlineText { get; set; }
        [JsonProperty("helpTipHover")]
        public string HoverText { get; set; }
    }
}