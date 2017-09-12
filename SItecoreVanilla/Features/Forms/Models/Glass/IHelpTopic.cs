using Glass.Mapper.Sc.Configuration.Attributes;
using SitecoreVanilla.Features.Forms.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SitecoreVanilla.Features.Forms.Models
{
    [SitecoreType(AutoMap = true, TemplateId = "{0694237E-8996-48B9-9BF9-4D6C7BF02D8E}", EnforceTemplate = Glass.Mapper.Sc.Configuration.SitecoreEnforceTemplate.Template)]
    public interface IHelpTopic : ISitecoreItem
    {
        [SitecoreChildren(InferType = false)]
        IEnumerable<IHelpItem> HelpItems { get; set; }
    }
}
