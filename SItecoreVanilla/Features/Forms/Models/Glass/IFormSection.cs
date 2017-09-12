using Glass.Mapper.Sc.Configuration.Attributes;
using Glass.Mapper.Sc.Fields;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SitecoreVanilla.Features.Forms.Models
{
    [SitecoreType(AutoMap = true)]
    public interface IFormSection : ISitecoreItem
    {
        [SitecoreChildren]
        IEnumerable<IField> Fields { get; set; }

        string Heading { get; set; }

        [SitecoreField(FieldType = Glass.Mapper.Sc.Configuration.SitecoreFieldType.RichText)]
        string Text { get; set; }

        [SitecoreField(FieldId = "{386C4166-CF53-4BCC-BE27-AA79B78C107D}")]
        Link HelpLink { get; set; }

    }
}