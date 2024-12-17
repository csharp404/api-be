
using MediatR;

namespace HISApp.Feature.User.Login
{
    public sealed record LoginUserCommand(string Email,string Password):IRequest<string>;
}
