
using HISApp.DTOs;
using MediatR;

namespace HISApp.Feature.User.SignUp
{
    public class SignUpUserCommandHandler(AccountService service):IRequestHandler<SignUpUserCommand,string>
    {
        public Task<string> Handle(SignUpUserCommand request, CancellationToken cancellationToken)
        {
            var result = service.Register(request.usr);
            return result;
        }
    }
}
