using HISApp.DTOs;
using MediatR;

namespace HISApp.Feature.User.SignUp
{
    public sealed record SignUpUserCommand(SignUpDTO usr):IRequest<string>;
}
