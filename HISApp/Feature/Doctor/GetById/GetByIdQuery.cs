
using System.Runtime.InteropServices.ComTypes;
using HISApp.Data;
using HISApp.DTOs;
using HISApp.Feature.Doctor.GetAll;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

 namespace HISApp.Feature.Doctor.GetById
{
    public record class ResponseDoctorByIdQuery(DetailsDto DoctorsCard);
    public record class RequestDoctorByIdQuery (string id): IRequest<ResponseDoctorByIdQuery>;


    public class RequestDoctorsQueryHandler(MyDbContext context,UserManager<Domain.User> _userManager, RoleManager<IdentityRole> RoleManager) : IRequestHandler<RequestDoctorByIdQuery, ResponseDoctorByIdQuery>
    {
        public async Task<ResponseDoctorByIdQuery> Handle(RequestDoctorByIdQuery request, CancellationToken cancellationToken)
        {
           
            var data = await _userManager.GetUsersInRoleAsync("Doctor");
            var doctor = data.FirstOrDefault(x => x.Id == request.id);
           
            var department = context.Departments.Find(doctor.DepartmentId);
            var DoctorDetails =  new DetailsDto
            {
                Id = doctor.Id,
                Name = $"Dr.{doctor.FirstName} {doctor.LastName}",
                Department = department.Name,
                Age =  doctor.Age,
                Email = doctor.Email,
                Experience = doctor.Experience,
                Gender = (doctor.Gender==true ? "Male" : "Female"),
                HireDate = (DateTime)doctor.HireDate,
                PhoneNumber = doctor.PhoneNumber
               
            };

            return new ResponseDoctorByIdQuery(DoctorDetails);
        }
    }
}
