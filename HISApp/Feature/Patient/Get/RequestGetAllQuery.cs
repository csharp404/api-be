using HISApp.Data;
using HISApp.DTOs;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace HISApp.Feature.Patient.Get;

public record ResponseGetAllQuery(List<Domain.Patient> patients);
public record RequestGetAllQuery():IRequest<ResponseGetAllQuery>;

public class RequestGetAllQueryHandler(MyDbContext context) : IRequestHandler<RequestGetAllQuery, ResponseGetAllQuery>
{
    public async Task<ResponseGetAllQuery> Handle(RequestGetAllQuery request, CancellationToken cancellationToken)
    {
        var data = await context.Patients.ToListAsync(cancellationToken);
        return new ResponseGetAllQuery(data);


    }
}