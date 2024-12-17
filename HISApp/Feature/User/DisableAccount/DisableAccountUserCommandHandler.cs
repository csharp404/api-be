using HISApp.DTOs;
using MediatR;

namespace HISApp.Feature.User.DisableAccount
{
    public class DisableAccountUserCommandHandler(AccountService service):IRequestHandler<DisableAccountUserCommand,string>
    {
        public Task<string> Handle(DisableAccountUserCommand request, CancellationToken cancellationToken)
        {
            var result = service.DisableAccount(request.Email);
            return result;
        }
    }
}
