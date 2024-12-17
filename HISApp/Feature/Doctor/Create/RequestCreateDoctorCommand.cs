using HISApp.DTOs;
using MediatR;

namespace HISApp.Feature.Doctor.Create
{
    public record class RequestCreateDoctorCommand(SignUpDTO usr) : IRequest<ResponseCreateDoctorCommand>;

    public record class ResponseCreateDoctorCommand(int status);


        public class RequestCreateDoctorCommandHandler(AccountService service) : IRequestHandler<RequestCreateDoctorCommand, ResponseCreateDoctorCommand>
        {
            public async Task<ResponseCreateDoctorCommand> Handle(RequestCreateDoctorCommand request, CancellationToken cancellationToken)
            {
            var result = service.Register(request.usr);
            return new ResponseCreateDoctorCommand(1);
        }
        }
}
