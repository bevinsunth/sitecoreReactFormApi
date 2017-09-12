using Glass.Mapper.Sc;
using Sitecore.Data.Items;
using SitecoreVanilla.Features.Forms.Models;
using SitecoreVanilla.Features.Forms.Models.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SitecoreVanilla.Features.SignUpForm.Repositories
{
    public class FormsRepository : IFormsRepository
    {
        private IForm FormItem { get; set; }

        private FormsRepository()
        { }

        public FormsRepository(IForm contextItem)
        {
            FormItem = contextItem;           
        }

        /// <summary>
        /// Gets glass help object and converts it to Json compatible object
        /// </summary>
        /// <param name="helpObject"></param>
        /// <returns></returns>
        public JsonHelpAndSupport GetJsonHelpObjectFromGlass()
        {
            return new JsonHelpAndSupport()
            {
                Id = FormItem.HelpAndSupport?.Id.ToString("N"),
                Title = FormItem.HelpAndSupport?.Title,
                Categories = FormItem.HelpAndSupport.Categories?.Select(x => new JsonHelpCategory()
                {
                    Id = x.Id.ToString("N"),
                    Title = x.Title,
                    Topics = x.Topics?.Select(y => new JsonFormHelpTopic()
                    {
                        Id = y.Id.ToString("N"),
                        Title = y.Title,
                        Items = y.HelpItems?.Select(z => new JsonHelpItem()
                        {
                            Id = z.Id.ToString("N"),
                            Title = z.Title,
                            Summary = z.Summary
                        })
                    }),
                    Items = x.HelpItems?.Select(y => new JsonHelpItem()
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
        public JsonForm GetJsonFormObjectFromGlasss()
        {
            JsonForm JsonFormObject = new JsonForm()
            {
                Name = FormItem.Name,
                Title = FormItem.Title,
                Steps = FormItem?.FormSteps?.ToDictionary(x => x.Name, x => new JsonFormStep()
                {
                    Name = x.Name,
                    Title = x.Title,
                    Sections = x.Sections?.ToDictionary(y => y.Name, y => new JsonFormSection()
                    {
                        Name = y.Name,
                        Title = y.Title,
                        Instruction = new JsonFormInstruction()
                        {
                            Heading = y.Heading,
                            Text = y.Text
                        },
                        Help = new JsonHelpField()
                        {
                            LinkText = y.HelpLink?.Text,
                            Url = y.HelpLink?.Url
                        },
                        Fields = y.Fields?.ToDictionary(z => z.Name, z => new JsonFormField()
                        {
                            Name = z.Name,
                            Help = new JsonHelpField()
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
    }
}