using Dyson.Api.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Dyson.Api.Controllers
{
    [Route("api/v1/[controller]")]
    public class AccountController : ControllerBase
    {
        private readonly UserManager<IdentityUser> userManager;

        public AccountController(UserManager<IdentityUser> userManager)
        {
            this.userManager = userManager;
        }

        [HttpPost("register")]
        public async Task<IActionResult> RegisterAsync([FromBody]User user)
        {
            if (ModelState.IsValid)
            {
                IdentityUser identityUser = new IdentityUser
                {
                    UserName = user.UserName,

                };

                IdentityResult identityResult = await userManager.CreateAsync(identityUser, user.Password);

                IActionResult errorResult = GetErrorResult(identityResult);

                if (errorResult != null)
                    return errorResult;

                return Ok();
            }

            return BadRequest(ModelState);
        }

        private IActionResult GetErrorResult(IdentityResult identityResult)
        {
            if (!identityResult.Succeeded)
            {
                if (identityResult.Errors != null)
                {
                    foreach (IdentityError identityError in identityResult.Errors)
                    {
                        ModelState.AddModelError("", identityError.Description);
                    }
                }

                if (ModelState.IsValid)
                {
                    // No ModelState errors are available to send, so just return an empty BadRequest.
                    return BadRequest();
                }

                return BadRequest(ModelState);
            }

            return null;
        }
    }
}