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
        var add = new Address()
        {
            AreaId = request.Patient.AreaId,
            CityId = request.Patient.cityId,

        };
        var Patient = new Domain.Patient
        {
            Address = add,
            Age = request.Patient.age,
            FirstName = request.Patient.FirstName,
            LastName = request.Patient.LastName,
            Gender = request.Patient.gender,
            BloodType = request.Patient.BloodType,
            LegalGaurdainName = request.Patient.LegalGaurdainName,
            LegalGaurdainPhone = request.Patient.LegalGaurdainPhone,
            IsDeleted = false
        };
        await context.Patients.AddAsync(Patient);
       await  context.SaveChangesAsync();
        return new ResponseCreateCommand(1);
    }
}