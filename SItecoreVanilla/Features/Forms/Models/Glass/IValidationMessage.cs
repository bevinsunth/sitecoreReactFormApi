using Glass.Mapper.Sc.Configuration.Attributes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SitecoreVanilla.Features.Forms.Models
{
    [SitecoreType(AutoMap = true)]
    public interface IValidatioMessage : ISitecoreItem
    {
        string Key { get; set; }

        string Message { get; set; }
    }
}