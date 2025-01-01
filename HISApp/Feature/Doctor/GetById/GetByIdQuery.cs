
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

            var doctor = await _userManager.FindByIdAsync(request.id);
            var address = context.Addresses.FirstOrDefault(x=>x.UserId==request.id);
            var department = context.Departments.Find(doctor.DepartmentId);
            var DoctorDetails =  new DetailsDto
            {
                id = doctor.Id,
                FirstName = doctor.FirstName,
                LastName = doctor.LastName,
                departmentid = department.Id,
                age =  doctor.Age,
                email = doctor.Email,
                experience = doctor.Experience,
                gender = doctor.Gender,
                hiredate = doctor.HireDate.ToString(),
                phonenumber = doctor.PhoneNumber,
                Role = 2,
                areaid = address.AreaId,
                cityid = address.CityId
               
            };
            
            return new ResponseDoctorByIdQuery(DoctorDetails);
        }
    }
}
