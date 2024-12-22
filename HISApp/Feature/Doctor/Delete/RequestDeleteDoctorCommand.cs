using HISApp.Data;
using MediatR;
using Microsoft.AspNetCore.Identity;

namespace HISApp.Feature.Doctor.Delete
{
    public record class ResponseDeleteDoctorCommand(int status);

    public record class RequestDeleteDoctorCommand(string id) : IRequest<ResponseDeleteDoctorCommand>;

    public class RequestDeleteDoctorCommandHandler(MyDbContext context,UserManager<Domain.User> _userManager, RoleManager<IdentityRole> RoleManager) : IRequestHandler<RequestDeleteDoctorCommand, ResponseDeleteDoctorCommand>
    {
        public async Task<ResponseDeleteDoctorCommand> Handle(RequestDeleteDoctorCommand request, CancellationToken cancellationToken)
        {
            var data =await  _userManager.FindByIdAsync(request.id);
            if (data == null)
            {
                return new ResponseDeleteDoctorCommand(0);
            }

            var address =  context.Addresses.FirstOrDefault(x=>x.UserId==request.id);
            context.Addresses.Remove(address);
            await context.SaveChangesAsync();
            var response  = await _userManager.DeleteAsync(data);
            return new ResponseDeleteDoctorCommand(1);
        }
    }
}
