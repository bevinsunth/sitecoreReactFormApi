﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SitecoreVanilla.Features.Forms.Models.Json
{
    public class FormStep
    {
        [JsonProperty("id")]
        public string Name { get; set; }
        [JsonProperty("title")]
        public string Title { get; set; }
        [JsonProperty("sections")]
        public IDictionary<string , FormSection> Sections { get; set; }
    }
}