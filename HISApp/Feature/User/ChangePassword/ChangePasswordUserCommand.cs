
using MediatR;

namespace HISApp.Feature.User.ChangePassword
{
    public sealed record ChangePasswordUserCommand(string OldPassword, string NewPassword):IRequest<string>;

}
