using HISApp.Data;
using HISApp.DTOs;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace HISApp.Feature.Patient.GetById;

public record ResponseGetByIdQuery(Domain.Patient patient);
public record RequestGetByIdQuery(int id):IRequest<ResponseGetByIdQuery>;
public class RequestGetByIdQueryHandler (MyDbContext context): IRequestHandler<RequestGetByIdQuery, ResponseGetByIdQuery>
{
    public async Task<ResponseGetByIdQuery> Handle(RequestGetByIdQuery request, CancellationToken cancellationToken)
    {
        var data = await context.Patients.Where(x=>x.IsDeleted==false && x.Id==request.id).FirstOrDefaultAsync();
        if (data != null)
        {
            return new ResponseGetByIdQuery(data);
        }

        return new ResponseGetByIdQuery(new Domain.Patient());
    }
}