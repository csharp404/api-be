using HISApp.Domain;
using HISApp.DTOs;
using HISApp.Feature.User.ChangePassword;
using HISApp.Feature.User.DisableAccount;
using HISApp.Feature.User.Login;
using HISApp.Feature.User.SignUp;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HISApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController(ISender sender) : ControllerBase
    {
        [HttpPost]
        [Route("Login")]
        public async Task<IActionResult> Login(LoginDTO u)
        {
            LoginUserCommand query = new LoginUserCommand(u.Email, u.Password);
            var result = sender.Send(query);
            Token tok = new Token();
            tok.TokenString = result.Result;
            return Ok(tok);
        }
       
        [HttpPut]
        [Route("ChangePWD")]
        //[Authorize(Roles = "Admin")]
        public IActionResult ChangePassword(ChangePasswordDTO pwds)
        {
            ChangePasswordUserCommand usr = new ChangePasswordUserCommand(pwds.OldPassword, pwds.NewPassword);
            var result = sender.Send(usr);
            return Ok(result.Result);
        }

    }
}

