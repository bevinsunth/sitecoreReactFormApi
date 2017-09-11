﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SitecoreVanilla.Features.Forms.Models.Json
{
    public class HelpAndSupport
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("title")]
        public string Title { get; set; }
        [JsonProperty("categories")]
        public IEnumerable<HelpCategory> Categories { get; set; }
    }
}