using HISApp.Data;
using HISApp.DTOs;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace HISApp.Feature.Patient.Get;

public record ResponseGetAllQuery(List<GetPatientDto> patients);
public record RequestGetAllQuery():IRequest<ResponseGetAllQuery>;

public class RequestGetAllQueryHandler(MyDbContext context) : IRequestHandler<RequestGetAllQuery, ResponseGetAllQuery>
{
    private readonly MyDbContext _context = context;

    public async Task<ResponseGetAllQuery> Handle(RequestGetAllQuery request, CancellationToken cancellationToken)
    {
        var data =  await _context.Patients.Include(x=>x.Department)
            .Include(u=>u.User).Include(x=>x.City)
            .Include(x=>x.Area).Where(x=>x.IsDeleted==false).ToListAsync();
            var d =  data.Select(x=>new GetPatientDto
            {
                AreaName = x.Area.Name,cityName = x.City.Name,
                age = x.Age,
                name = x.FirstName +" "+x.LastName,
                address = x.City.Name+", "+x.Area.Name,
                admissionDate = x.AdmissionDate,
                department = x.Department.Name,
                gender = x.Gender ? "Male" :"Female",
                id = x.Id,
                pcd = x.User.FirstName + " " +x.User.LastName,
                phoneNumber = x.PhoneNumber,
                Code  = x.Code.ToString().Substring(0,8),
                
            });




        return new ResponseGetAllQuery(d.ToList());


    }
}