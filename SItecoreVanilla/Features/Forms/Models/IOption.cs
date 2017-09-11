using Glass.Mapper.Sc.Configuration.Attributes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SitecoreVanilla.Features.Forms.Models
{
    [SitecoreType(AutoMap = true)]
    public interface IOption : ISitecoreItem
    {
        [SitecoreField(FieldId = "{EB13B04D-2F9D-4FFF-9A7A-B1D2ED26D8DC}")]
        string DisplayName { get; set; }

        string Value { get; set; }
    }
}