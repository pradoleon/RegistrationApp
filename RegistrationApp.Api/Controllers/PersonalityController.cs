using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RegistrationApp.BL.Business;
using RegistrationApp.Domain.ResponseDto;
using RegistrationApp.BL.Business;
using RegistrationApp.Domain.ResponseDto;
using System.Collections.Generic;

namespace RegistrationApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonalityController : ControllerBase
    {
        private readonly PersonalityBusiness _personalityBusiness;
        public PersonalityController(PersonalityBusiness personalityBusiness)
        {
            _personalityBusiness = personalityBusiness;
        }

        [HttpGet]
        public IEnumerable<PersonalityDto> GetAllPersonality()
        {
            return _personalityBusiness.GetAllPersonalities();
        }
    }
}