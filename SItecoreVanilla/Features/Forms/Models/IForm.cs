using Glass.Mapper.Sc.Configuration.Attributes;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace SitecoreVanilla.Features.Forms.Models
{
    [SitecoreType(AutoMap = true)]
    public interface IForm : ISitecoreItem
    {
        [SitecoreChildren]
        IEnumerable<IFormStepPage> FormSteps { get; set; }
    }
}
