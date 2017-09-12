using Glass.Mapper.Sc;
using Newtonsoft.Json;
using Sitecore.Data.Items;
using SitecoreVanilla.Features.Forms.Models;
using SitecoreVanilla.Features.Forms.Models.Json;
using SitecoreVanilla.Features.SignUpForm.Repositories;
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
        private IFormsRepository _formRepository;
        static ISitecoreService sitecoreService = new SitecoreService("master");
        static IForm form = sitecoreService.GetItem<IForm>("{8852004D-6A83-4366-A8EA-7EFCB9689D6F}");

        public FormsController() : this(new FormsRepository(form))
        {
        }
        private FormsController(IFormsRepository formRepository)
        {
            _formRepository = formRepository;
        }

        // GET api/<controller>
        [HttpGet]
        [Route("api/forms")]
        public HttpResponseMessage GetFormContent()
        {
            var jsonString = JsonConvert.SerializeObject(_formRepository.GetJsonFormObjectFromGlasss(), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
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
            var jsonString = JsonConvert.SerializeObject(_formRepository.GetJsonHelpObjectFromGlass(), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
            return SetJsonResponseProperties(jsonString);
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