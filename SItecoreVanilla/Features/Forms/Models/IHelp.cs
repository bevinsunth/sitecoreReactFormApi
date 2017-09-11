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
    public interface IHelp : ISitecoreItem
    {
        [SitecoreChildren]
        IEnumerable<IHelpCategory> Categories { get; set; }

    }
}
