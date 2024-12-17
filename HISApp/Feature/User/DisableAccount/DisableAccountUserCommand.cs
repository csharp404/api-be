using MediatR;

namespace HISApp.Feature.User.DisableAccount
{
    public sealed record DisableAccountUserCommand(string Email):IRequest<string>;
}
