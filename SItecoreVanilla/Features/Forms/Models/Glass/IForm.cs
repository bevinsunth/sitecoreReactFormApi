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

        [SitecoreField(FieldId = "{10D19A16-4DCC-42C7-8A41-A1A340E3F995}")]
        IHelp HelpAndSupport { get; set; }
    }
}
