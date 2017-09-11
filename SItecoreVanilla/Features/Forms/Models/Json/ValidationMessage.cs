using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SitecoreVanilla.Features.Forms.Models.Json
{
    public class ValidationMessage
    {
        [JsonProperty("message")]
        public string Message { get; set; }
    }
}