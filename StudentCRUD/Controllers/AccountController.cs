using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using StudentCRUD.Models;
using StudentCRUD.Repositories.IRepo;

namespace StudentCRUD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase

    {
        private readonly IAccountRepository account;

        public AccountController(IAccountRepository repository) {
            account = repository;
        }

        [HttpPost("SignUp")]
        public async Task<IActionResult> SignUp(SignUpModel signUpModel)
        {
            var result = await account.SignUpAsync(signUpModel);
            return result.Succeeded ? Ok(result.Succeeded) : BadRequest(result.Errors); 
        }

        [HttpPost("SignIn")]
        public async Task<IActionResult> SignIn(SignInModel signInModel)
        {
            var result = await account.SignInAsync(signInModel);

            return string.IsNullOrEmpty(result) ? Unauthorized() : Ok(result);
        }

    }
}
