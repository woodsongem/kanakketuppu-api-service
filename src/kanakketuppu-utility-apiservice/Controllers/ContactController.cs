using System;
using kanakketuppuapiservice.Mappers.ContactService;
using KanakketuppuUtilityApiServiceCore.ContactServiceCore.Datacontracts.MessageEntities;
using KanakketuppuUtilityApiServiceCore.ContactServiceCore.Services;
using KanakketuppuUtilityApiServiceCore.ContactServiceCore.Utility;
using KanakketuppuUtilityApiServiceCore.Utility;
using KanakketuppuUtilityApiServiceModel.ContactApiServiceModels;
using KanakketuppuUtilityApiServiceModel.ContactApiServiceModels.Contact.GetContact;
using KanakketuppuUtilityApiServiceModel.ContactApiServiceModels.Contact.UpdateContact;
using KatavuccolCommon.Extensions;
using Microsoft.AspNetCore.Mvc;

namespace kanakketuppuapiservice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactsController : ControllerBase
    {
        private readonly IContactService contactService;
        private readonly IContactServiceControllerMapper contactServiceControllerMapper;
        private readonly IContactServiceErrorCode contactServiceErrorCode;

        public ContactsController(
            IContactService contactService,
            IContactServiceControllerMapper contactServiceControllerMapper,
            IContactServiceErrorCode contactServiceErrorCode)
        {
            this.contactService = contactService;
            this.contactServiceControllerMapper = contactServiceControllerMapper;
            this.contactServiceErrorCode = contactServiceErrorCode;
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
                return StatusCode(500, contactServiceErrorCode.InternalError);
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
                return StatusCode(500, contactServiceErrorCode.InternalError);
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
                return StatusCode(500, contactServiceErrorCode.InternalError);
            }
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public ActionResult Put(string id, [FromBody] UpdateContactApiModel updateContactApiModel)
        {
            try
            {
                var updateContactMsgEntity = contactServiceControllerMapper.MapUpdateContactMsgEntity(updateContactApiModel, id);
                var errorMessages = contactService.UpdateContact(updateContactMsgEntity);
                if (errorMessages.IsEmpty())
                    return Ok();
                return StatusCode(400, errorMessages.ToApiErrorMessage());

            }
            catch (Exception ex)
            {
                //TODO: log error
                return StatusCode(500, contactServiceErrorCode.InternalError);
            }
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
                return StatusCode(500, contactServiceErrorCode.InternalError);
            }
        }
    }
}
