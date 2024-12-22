using HISApp.Domain;
using HISApp.DTOs;
using HISApp.Feature.Doctor.Delete;
using HISApp.Feature.Doctor.GetAll;
using HISApp.Feature.Doctor.GetById;
using HISApp.Feature.Doctor.Update;
using HISApp.Feature.User.SignUp;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HISApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController(ISender sender) : ControllerBase
    {

        [HttpPost]
        [Route("user-Create")]
        //[Authorize(Roles = "Admin")]
        public async Task<IActionResult> Create(SignUpDTO usr)
        {
            SignUpUserCommand user = new SignUpUserCommand(usr);

            var result = sender.Send(user);

            Response tok = new Response();
            tok.Message = result.Result;
            return Ok(tok);
        }
        [HttpGet]
        [Route("users/{role}")]
        //[Authorize(Roles = "Admin")]

        public async Task<IActionResult> GetAllDoctor(int role)
        {

            var result = await sender.Send(new RequestDoctorsQuery(role));
            return Ok(result);
        }
        [HttpGet]
        [Route("user/{id}")]
        //[Authorize(Roles = "Admin")]

        public async Task<IActionResult> GetDoctorById([FromRoute]string id)
        {
            var result = await sender.Send(new RequestDoctorByIdQuery(id));
            return Ok(result);
        }

        [HttpPut]
        [Route("user-update")]
        //[Authorize(Roles = "Admin")]

        public async Task<IActionResult> Update(UpdateDto doc)
        {
            var result = await sender.Send(new RequestUpdateDoctorCommand(doc));
            return Ok(result);
        }
        [HttpDelete]
        [Route("user-delete/{id}")]
        //[Authorize(Roles = "Admin")]
        public async Task<IActionResult> DeleteDoctorByID(string id)
        {
            var result = await sender.Send(new RequestDeleteDoctorCommand(id));
            return Ok(result);
        }

    }
}
