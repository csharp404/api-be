using HISApp.DTOs;
using HISApp.Feature.Patient.Create;
using HISApp.Feature.Patient.Delete;
using HISApp.Feature.Patient.Get;
using HISApp.Feature.Patient.GetById;
using HISApp.Feature.Patient.Update;
using HISApp.Feature.User.SignUp;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HISApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientController (ISender sender): ControllerBase
    {

        [HttpPost]
        [Route("Create")]
        //[Authorize(Roles = "Management Staff")]
        public async Task<IActionResult> Create(PatientsDto usr)
        {
            RequestCreateCommand user = new RequestCreateCommand(usr);

            var result = await sender.Send(user);

            return Ok(result);
        }
        [HttpGet]
        [Route("Get")]
        //[Authorize]
        public async Task<IActionResult> GetAll()
        {
            RequestGetAllQuery user = new RequestGetAllQuery();
            var result = await sender.Send(user);
            return Ok(result);
        }
        [HttpDelete]
        [Route("Delete/{id}")]
        //[Authorize(Roles = "Management Staff")]

        public async Task<IActionResult> Delete(int id)
        {
            RequestDeleteCommand user = new RequestDeleteCommand(id);

            var result = await sender.Send(user);

            return Ok(result);
        }
        [HttpGet]
        [Route("GetById/{id}")]
        //[Authorize]

        public async Task<IActionResult> GetById(int id)
        {
            RequestGetByIdQuery user = new RequestGetByIdQuery(id);

            var result = await sender.Send(user);

            return Ok(result);
        }

        [HttpPut]
        [Route("Update/{id}")]
        //[Authorize(Roles = "Management Staff")]
        public async Task<IActionResult> Update(int id,[FromBody] PatientsDto pate)
        {
            RequestUpdateCommand user = new RequestUpdateCommand(id,pate);

            var result = await sender.Send(user);

            return Ok(result);
        }
    }
}
