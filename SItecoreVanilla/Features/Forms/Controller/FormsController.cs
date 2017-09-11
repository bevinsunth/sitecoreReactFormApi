using Glass.Mapper.Sc;
using Newtonsoft.Json;
using SitecoreVanilla.Features.Forms.Models;
using SitecoreVanilla.Features.Forms.Models.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace SitecoreVanilla.Features.Forms.Controller
{
    public class FormsController : ApiController
    {
        // GET api/<controller>
        [HttpGet]
        [Route("api/forms")]
        public HttpResponseMessage GetFormContent()
        {
            ISitecoreService sitecoreService = new SitecoreService("master");
            IForm form = sitecoreService.GetItem<IForm>("{8852004D-6A83-4366-A8EA-7EFCB9689D6F}");
            var jsonString = JsonConvert.SerializeObject(GetJsonFormObjectFromGlasss(form), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
            return SetJsonResponseProperties(jsonString);
        }

        private HttpResponseMessage SetJsonResponseProperties(string jsonString)
        {
            var response = this.Request.CreateResponse(HttpStatusCode.OK);
            response.Content = new StringContent(jsonString, System.Text.Encoding.UTF8, "application/json");
            return response;
        }

        [HttpGet]
        [Route("api/forms/help")]
        public HttpResponseMessage GetFormHelpContent()
        {
            ISitecoreService sitecoreService = new SitecoreService("master");
            IHelp help = sitecoreService.GetItem<IHelp>("{4F631B4A-4C03-461D-B9F8-F71C3ADA42A5}");
            var jsonString = JsonConvert.SerializeObject(GetJsonHelpObjectFromGlass(help), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
            return SetJsonResponseProperties(jsonString);
        }

        /// <summary>
        /// Gets glass help object and converts it to Json compatible object
        /// </summary>
        /// <param name="helpObject"></param>
        /// <returns></returns>
        private static HelpAndSupport GetJsonHelpObjectFromGlass(IHelp helpObject)
        {
            return new HelpAndSupport()
            {
                Id = helpObject?.Id.ToString("N"),
                Title = helpObject?.Title,
                Categories = helpObject.Categories?.Select(x => new HelpCategory()
                {
                    Id = x.Id.ToString("N"),
                    Title = x.Title,
                    Topics = x.Topics?.Select(y => new HelpTopic()
                    {
                        Id = y.Id.ToString("N"),
                        Title = y.Title,
                        Items = y.HelpItems?.Select(z => new HelpItem()
                        {
                            Id = z.Id.ToString("N"),
                            Title = z.Title,
                            Summary = z.Summary
                        })
                    }),
                    Items = x.HelpItems?.Select(y => new HelpItem()
                    {
                        Id = y.Id.ToString("N"),
                        Title = y.Title,
                        Summary = y.Summary
                    })
                })
            };
        }

        /// <summary>
        /// Gets glass form object and converts it to Json compatible object
        /// </summary>
        /// <param name="formObject"></param>
        /// <returns></returns>
        private Form GetJsonFormObjectFromGlasss(IForm formObject)
        {
            Form JsonFormObject = new Form()
            {
                Name = formObject.Name,
                Title = formObject.Title,
                Steps = formObject?.FormSteps?.ToDictionary(x => x.Name, x => new FormStep()
                {
                    Name = x.Name,
                    Title = x.Title,
                    Sections = x.Sections?.ToDictionary(y => y.Name, y => new FormSection()
                    {
                        Name = y.Name,
                        Title = y.Title,
                        Instruction = new Instruction()
                        {
                            Heading = y.Heading,
                            Text = y.Text
                        },
                        Help = new HelpField()
                        {
                            LinkText = y.HelpLink?.Text,
                            Url = y.HelpLink?.Url
                        },
                        Fields = y.Fields?.ToDictionary(z => z.Name, z => new FormField()
                        {
                            Name = z.Name,
                            Help = new HelpField()
                            {
                                LinkText = z.HelpLink?.Text,
                                Url = z.HelpLink?.Url
                            },
                            Label = z.Title,
                            Options = z.Options?.ToDictionary(a => a.Name, a => a.Value),
                            ValidationMessages = z.Validations?.ToDictionary(b => b.Name, b => b.Message)
                        })
                    })
                })
            };
            return JsonFormObject;
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}