using HISApp.DTOs;
using MediatR;

namespace HISApp.Feature.User.ChangePassword
{
    public class ChangePasswordUserCommandHandler(AccountService service):IRequestHandler<ChangePasswordUserCommand,string>
    {
        public Task<string> Handle(ChangePasswordUserCommand request, CancellationToken cancellationToken)
        {
            var result = service.ChangePassword(request.OldPassword,request.NewPassword);
            return result;
        }
    }
}
