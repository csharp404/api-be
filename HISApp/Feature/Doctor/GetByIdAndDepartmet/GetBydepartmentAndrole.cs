using HISApp.Data;
using Microsoft.AspNetCore.Http.HttpResults;



using global::HISApp.DTOs;

using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace HISApp.Feature.Doctor.GetByIdAndDepartmet
{
    public record class ResponseDoctorsDepartmentQuery(List<CardsDto> DoctorsCard);
    public record class RequestDoctorsDepartmentQuery(int role,int department) : IRequest<ResponseDoctorsDepartmentQuery>;


   public class RequestDoctorsDepartmentQueryHandler (MyDbContext context, UserManager<Domain.User> _userManager) : IRequestHandler<RequestDoctorsDepartmentQuery, ResponseDoctorsDepartmentQuery>
   {
       public async Task<ResponseDoctorsDepartmentQuery> Handle(RequestDoctorsDepartmentQuery request, CancellationToken cancellationToken)
       {
           string role = GetRoleName(request.role);
           var doctors = await _userManager.GetUsersInRoleAsync(role);
           var data = doctors.Where(x => x.DepartmentId == request.department).Select(x=>new CardsDto
           {
               Id = x.Id,
               Name = x.FirstName + " " + x.LastName,
               Description = ""
           }).ToList();
           return new ResponseDoctorsDepartmentQuery(data);
       }
       private string GetRoleName(int RoleNumber)
       {
           return RoleNumber switch
           {
               1 => "Doctor",
               2 => "Nurse",
               3 => "Management Staff",
               4 => "Pharmacist",
               _ => "Unknown Role"
           };
       }
    }

 
    
}