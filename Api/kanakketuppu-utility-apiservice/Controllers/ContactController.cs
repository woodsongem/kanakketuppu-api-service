using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using kanakketuppuapiservice.Mappers.ContactService;
using KanakketuppuUtilityApiServiceCore.ContactServiceCore.Services;
using KanakketuppuUtilityApiServiceCore.DataContracts.Commons;
using KanakketuppuUtilityApiServiceModel.ContactApiServiceModels;
using Microsoft.AspNetCore.Mvc;

namespace kanakketuppuapiservice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly IContactService contactService;
        private readonly IContactServiceControllerMapper contactServiceControllerMapper;

        public ContactController(
            IContactService contactService,
            IContactServiceControllerMapper contactServiceControllerMapper)
        {
            this.contactService = contactService;
            this.contactServiceControllerMapper = contactServiceControllerMapper;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post(ContactApiModel contactApiModel)
        {
            var createContactMsgEntity = contactServiceControllerMapper.MapCreateContactMsgEntity(contactApiModel);
            Result result = contactService.CreateContact(createContactMsgEntity);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
