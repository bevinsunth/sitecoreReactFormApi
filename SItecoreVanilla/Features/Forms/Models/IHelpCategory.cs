using Glass.Mapper.Sc.Configuration.Attributes;
using SitecoreVanilla.Features.Forms.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SitecoreVanilla.Features.Forms.Models
{
    [SitecoreType(AutoMap = true)]
    public interface IHelpCategory : ISitecoreItem
    {
        [SitecoreChildren(InferType = false)]
        IEnumerable<IHelpTopic> Topics { get; set; }

        [SitecoreChildren(InferType = false)]
        IEnumerable<IHelpItem> HelpItems { get; set; }
    }
}
