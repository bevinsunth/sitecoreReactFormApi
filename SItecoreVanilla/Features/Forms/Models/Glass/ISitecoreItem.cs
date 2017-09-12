using Newtonsoft.Json;
using Sitecore.Globalization;
using System;
using System.Collections;

namespace SitecoreVanilla.Features.Forms.Models
{
    public interface ISitecoreItem
    {
        string Name { get; set; }
        Guid Id { get; set; }
        string Title { get; set; }
    }
}
