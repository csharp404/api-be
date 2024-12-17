using HISApp.DTOs;
using MediatR;

namespace HISApp.Feature.User.Login
{
    public class LoginUserCommandHandler(AccountService service):IRequestHandler<LoginUserCommand,string>
    {
        public Task<string> Handle(LoginUserCommand request, CancellationToken cancellationToken)
        {
            var result =  service.Login(request.Email,request.Password);
            return result;
        }
    }
}
