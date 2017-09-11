using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SItecoreVanilla
{
    public class ReactController : Controller
    {
        // GET: Default
        public ActionResult SampleReactRendering()
        {
            var data = new
            {
                Title = FieldRenderer.Render(Sitecore.Context.Item, "Title"),
                Text = FieldRenderer.Render(Sitecore.Context.Item, "Text")
            };

            return this.React("~/views/SampleReact/SampleReactRendering.jsx", data);
        }
    }
}