using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using kanakketuppuapiservice.Mappers.ContactService;
using KanakketuppuUtilityApiServiceCore.ContactServiceCore.Services;
using KanakketuppuUtilityApiServiceCore.ContactServiceCore.Utility;
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
            try
            {
                return Ok(contactService.GetContactsModel());
            }
            catch (Exception ex)
            {
                //TODO: log error
                return StatusCode(500, ContactServiceErrorCode.InternalError);
            }
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<ContactModel> Get(string id)
        {
            try
            {
                var contactModel = contactService.GetContactModel(id);
                if (contactModel.IsEmpty())
                    return NotFound();
                return Ok(contactModel);
            }
            catch (Exception ex)
            {
                //TODO: log error
                return StatusCode(500, ContactServiceErrorCode.InternalError);
            }
        }

        // POST api/values
        [HttpPost]
        public ActionResult Post(ContactApiModel contactApiModel)
        {
            try
            {
                var createContactMsgEntity = contactServiceControllerMapper.MapCreateContactMsgEntity(contactApiModel);
                var errorMessages = contactService.CreateContact(createContactMsgEntity);
                var contactApiResponseModel = contactServiceControllerMapper.MapContactApiResponseModel(errorMessages, createContactMsgEntity);
                if (contactApiResponseModel.ErrorMessages.IsEmpty())
                    return Ok(contactApiResponseModel);
                return StatusCode(400, contactApiResponseModel);

            }
            catch (Exception ex)
            {
                //TODO: log error
                return StatusCode(500, ContactServiceErrorCode.InternalError);
            }
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public ActionResult Delete(string id)
        {
            try
            {
                var deleteContactByIdMsgEntity = contactServiceControllerMapper.MapDeleteContactByIdMsgEntity(id);
                var errorMessage = contactService.DeleteContactById(deleteContactByIdMsgEntity);
                if (errorMessage.IsEmpty())
                    return Ok();
                return StatusCode(400, errorMessage.ToApiErrorMessage());
            }
            catch (Exception ex)
            {
                //TODO: log error
                return StatusCode(500, ContactServiceErrorCode.InternalError);
            }
        }
    }
}
