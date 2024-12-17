using HISApp.Data;
using HISApp.Domain;
using HISApp.DTOs;
using HISApp.Feature.Doctor.GetById;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace HISApp.Feature.Doctor.Update;

public record class ResponseUpdateDoctorCommand(int status);
public record class RequestUpdateDoctorCommand (UpdateDto usr): IRequest<ResponseUpdateDoctorCommand>;
public class RequestDoctorsQueryHandler(MyDbContext context, UserManager<Domain.User> _userManager, RoleManager<IdentityRole> RoleManager) : IRequestHandler<RequestUpdateDoctorCommand, ResponseUpdateDoctorCommand>
{
    public async Task<ResponseUpdateDoctorCommand> Handle(RequestUpdateDoctorCommand request, CancellationToken cancellationToken)
    {
        var user = await _userManager.FindByEmailAsync(request.usr.email);


            user.DepartmentId = request.usr.departmentid;
            user.Experience = request.usr.experience;
            user.PhoneNumber = request.usr.phonenumber;
            user.Gender = request.usr.gender=="Male"?true:false;
            user.Age = request.usr.age;
           
           


            var data =await  context.Addresses.Where(x => x.UserId == user.Id).FirstOrDefaultAsync();
            if (data != null)
            {

                user.AddressId = data.Id;
                data.AreaId = request.usr.areaid;
                data.CityId = request.usr.cityid;
        }
            else
            {
                var add = new Address()
                {
                    AreaId = request.usr.areaid,
                    CityId = request.usr.cityid,
                   
                    UserId = user.Id
                };
                context.Addresses.Add(add);
                user.AddressId = add.Id;
        await context.SaveChangesAsync();
        }
          


            



        var res = await _userManager.UpdateAsync(user);
            return new ResponseUpdateDoctorCommand(1);
    }
}
