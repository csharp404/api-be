using HISApp.Data;
using HISApp.Domain;
using HISApp.DTOs;
using MediatR;

namespace HISApp.Feature.Patient.Create;

public record ResponseCreateCommand(int status);
public record RequestCreateCommand(PatientsDto Patient) :IRequest<ResponseCreateCommand>;
public class  RequestCreateCommandHandler (MyDbContext context): IRequestHandler<RequestCreateCommand, ResponseCreateCommand>{
    public async Task<ResponseCreateCommand> Handle(RequestCreateCommand request, CancellationToken cancellationToken)
    {
        try
        {
            var Patient = new Domain.Patient
            {
                Age = request.Patient.age,
                FirstName = request.Patient.firstName,
                LastName = request.Patient.lastName,
                Gender = request.Patient.gender,
                BloodType = request.Patient.bloodType,
                LegalGaurdainName = request.Patient.legalGaurdainName,
                LegalGaurdainPhone = request.Patient.legalGaurdainPhone,
                PhoneNumber = request.Patient.phoneNumber,
                DepartmentId = request.Patient.departmentId,
                PCD = request.Patient.pcd,
                UserId = request.Patient.userId,
                AreaId = request.Patient.Areaid,
                CityId = request.Patient.CityId,
                
            };

            await context.Patients.AddAsync(Patient);
            context.SaveChanges();
            return new ResponseCreateCommand(1);
        }
        catch (Exception e)
        {
            
            return new ResponseCreateCommand(0);
        }
     
    }
}