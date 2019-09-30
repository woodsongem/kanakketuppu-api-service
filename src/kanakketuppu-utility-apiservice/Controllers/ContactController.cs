using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using kanakketuppuapiservice.Mappers.ContactService;
using KanakketuppuUtilityApiServiceCore.ContactServiceCore.Services;
using KanakketuppuUtilityApiServiceCore.DataContracts.Commons;
using KanakketuppuUtilityApiServiceCore.Utility;
using KanakketuppuUtilityApiServiceModel.ContactApiServiceModels;
using KanakketuppuUtilityApiServiceModel.ContactApiServiceModels.Contact.GetContact;
using KatavuccolCommon.Extensions;
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
        public ActionResult Get()
        {
            return Ok(contactService.GetContactsModel());
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<ContactModel> Get(string id)
        {
            var contactModel = contactService.GetContactModel(id);
            if (contactModel.IsEmpty())
                return NotFound();
            return Ok(contactModel);
        }

        // POST api/values
        [HttpPost]
        public ActionResult Post(ContactApiModel contactApiModel)
        {
            var createContactMsgEntity = contactServiceControllerMapper.MapCreateContactMsgEntity(contactApiModel);
            var errorMessages = contactService.CreateContact(createContactMsgEntity);
            var contactApiResponseModel = contactServiceControllerMapper.MapContactApiResponseModel(errorMessages, createContactMsgEntity);
            return Ok(contactApiResponseModel);
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
