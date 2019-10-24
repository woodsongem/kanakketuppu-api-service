using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KanakketuppuUtilityApiService.Mappers.ErrorCodeService;
using KanakketuppuUtilityApiServiceCore.ErrorCodeServiceCore.Services;
using KanakketuppuUtilityApiServiceModel.ErrorCodeApiServiceModels.Commons;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace kanakketuppu_utility_apiservice.Controllers
{
    [Route("api/[controller]")]
    public class ErrorCodesController : Controller
    {
        private readonly IErrorCodeService errorCodeService;
        private readonly IErrorCodeServiceControllerMapper errorCodeServiceControllerMapper;
        private readonly IErrorCodeServiceErrorCode errorCodeServiceErrorCode;

        public ErrorCodesController(
            IErrorCodeService errorCodeService,
            IErrorCodeServiceControllerMapper errorCodeServiceControllerMapper,
            IErrorCodeServiceErrorCode errorCodeServiceErrorCode)
        {
            this.errorCodeService = errorCodeService;
            this.errorCodeServiceControllerMapper = errorCodeServiceControllerMapper;
            this.errorCodeServiceErrorCode = errorCodeServiceErrorCode;
        }

        // GET: api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<ErrorCodeApiModel> Get(string id)
        {
            try
            {
                var contactModel = errorCodeService.GetErrorCodeModelById(id);
                if (contactModel.IsEmpty())
                    return NotFound();
                return Ok(contactModel);
            }
            catch (Exception ex)
            {
                //TODO: log error
                return StatusCode(500, errorCodeServiceErrorCode.InternalError);
            }
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
