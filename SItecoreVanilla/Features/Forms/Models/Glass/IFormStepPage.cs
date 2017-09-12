using Glass.Mapper.Sc.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SitecoreVanilla.Features.Forms.Models
{
    [SitecoreType(AutoMap = true)]
    public interface IFormStepPage : ISitecoreItem
    {
        [SitecoreChildren]
        IEnumerable<IFormSection> Sections { get; set; }
    }
}