using Glass.Mapper.Sc.Configuration.Attributes;
using SitecoreVanilla.Features.Forms.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SitecoreVanilla.Features.Forms.Models
{
    [SitecoreType(AutoMap = true, TemplateId = "{9578FD14-DF97-411D-B0B6-1DBACFDC5F45}", EnforceTemplate = Glass.Mapper.Sc.Configuration.SitecoreEnforceTemplate.Template)]
    public interface IHelpItem : ISitecoreItem
    {
        [SitecoreField(FieldType = Glass.Mapper.Sc.Configuration.SitecoreFieldType.RichText )]
        string Summary { get; set; }
    }
}
