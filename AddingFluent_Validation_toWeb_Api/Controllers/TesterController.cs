using AddingFluent_Validation_toWeb_Api.Validators;
using ExternalModels.Models;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace AddingFluent_Validation_toWeb_Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TesterController : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> Create()
        {
            TesterValidator validator = new TesterValidator();
            List<string> ValidationMessages = new List<string>();
            var tester = new Tester
            {
                FirstName = "",
                Email="bla"
            };
            var validationResult = validator.Validate(tester);
            var response = new ResponseModel();
            if (!validationResult.IsValid)
            {
                response.IsValid = false;
                foreach (ValidationFailure failure in validationResult.Errors)
                {
                    ValidationMessages.Add(failure.ErrorMessage);

                }
                response.ValidationMessages=ValidationMessages;
            }
            return Ok(response);

        }
    }
}
