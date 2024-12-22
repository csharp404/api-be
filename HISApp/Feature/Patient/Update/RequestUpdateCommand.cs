using HISApp.Data;
using HISApp.DTOs;
using MediatR;

namespace HISApp.Feature.Patient.Update;

public record ResponseUpdateCommand(int status);
public record RequestUpdateCommand(int id, PatientsDto Patient):IRequest<ResponseUpdateCommand>;
public class RequestUpdateCommandHandler(MyDbContext context):IRequestHandler<RequestUpdateCommand,ResponseUpdateCommand>
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
        await context.SaveChangesAsync(cancellationToken);
        return new ResponseUpdateCommand(1);
    }
}