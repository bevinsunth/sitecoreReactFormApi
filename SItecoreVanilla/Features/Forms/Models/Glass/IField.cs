using Glass.Mapper.Sc.Configuration.Attributes;
using Glass.Mapper.Sc.Fields;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SitecoreVanilla.Features.Forms.Models
{
    [SitecoreType(AutoMap = true)]
    public interface IField : ISitecoreItem
    {
        IEnumerable<IValidatioMessage> Validations { get; set; }

        IEnumerable<IOption> Options { get; set; }

        [SitecoreField(FieldId = "{035F49DC-CA0A-49D2-AC76-AF3306A3DE58}")]
        Link HelpLink { get; set; }
        string InlineHelpText { get; set; }
        string HoverHelptext { get; set; }
    }
}