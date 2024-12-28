using HISApp.Data;
using HISApp.DTOs;
using MediatR;
using Microsoft.AspNetCore.Identity;

namespace HISApp.Feature.Patient.Update;

public record ResponseUpdateCommand(int status);
public record RequestUpdateCommand(int id, PatientsDto Patient):IRequest<ResponseUpdateCommand>;
public class RequestUpdateCommandHandler(MyDbContext context,UserManager<Domain.User>userManager):IRequestHandler<RequestUpdateCommand,ResponseUpdateCommand>
{
    public async Task<ResponseUpdateCommand> Handle(RequestUpdateCommand request, CancellationToken cancellationToken)
    {
        var data = context.Patients.Find(request.id);
        if (data == null)
        {
            return new ResponseUpdateCommand(0);
        }

      

        data.BloodType = request.Patient.bloodType;
        data.Age = request.Patient.age;
        data.FirstName = request.Patient.firstName;
        data.LastName = request.Patient.lastName;
        data.PCD  = request.Patient.pcd;
        data.UserId = Guid.Parse(request.Patient.pcd);
        data.AreaId = request.Patient.Areaid;
        data.CityId = request.Patient.CityId;
        data.DepartmentId = request.Patient.departmentId;
        data.PhoneNumber = request.Patient.phoneNumber;
        data.Gender = request.Patient.gender;
        await context.SaveChangesAsync(cancellationToken);
        return new ResponseUpdateCommand(1);
    }
}