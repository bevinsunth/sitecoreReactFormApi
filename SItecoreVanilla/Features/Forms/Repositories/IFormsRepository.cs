using Sitecore.Data.Items;
using SitecoreVanilla.Features.Forms.Models.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SitecoreVanilla.Features.SignUpForm.Repositories
{
    interface IFormsRepository
    {
        JsonForm GetJsonFormObjectFromGlasss();
        JsonHelpAndSupport GetJsonHelpObjectFromGlass();
    }
}
