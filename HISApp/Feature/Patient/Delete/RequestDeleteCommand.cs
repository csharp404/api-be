using HISApp.Data;
using MediatR;

namespace HISApp.Feature.Patient.Delete;

public record ResponseDeleteCommand(int status);
public record RequestDeleteCommand(int id):IRequest<ResponseDeleteCommand>;
public class RequestDeleteCommandHandler (MyDbContext context):IRequestHandler<RequestDeleteCommand, ResponseDeleteCommand>
{
    public async Task<ResponseDeleteCommand> Handle(RequestDeleteCommand request, CancellationToken cancellationToken)
    {
        var data = await context.Patients.FindAsync(request.id);
        if (data != null)
        {
            data.IsDeleted = true;
        }

        await context.SaveChangesAsync();
        return new ResponseDeleteCommand(1);
    }
} 