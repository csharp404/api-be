﻿using HISApp.Data;
using HISApp.DTOs;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace HISApp.Feature.Doctor.GetAll
{
    public record class ResponseDoctorsQuery(List<CardsDto> DoctorsCard);
    public record class RequestDoctorsQuery (int role): IRequest<ResponseDoctorsQuery>;

  
    public class RequestDoctorsQueryHandler (UserManager<Domain.User> _userManager, RoleManager<IdentityRole> RoleManager) : IRequestHandler<RequestDoctorsQuery, ResponseDoctorsQuery>
    {

        public async Task<ResponseDoctorsQuery> Handle(RequestDoctorsQuery request, CancellationToken cancellationToken)
        {
            string role = GetRoleName(request.role);
            var doctors = await _userManager.GetUsersInRoleAsync(role);

            // Map users to DTOs
            var doctorCards = doctors.Select(doctor => new CardsDto
            {
                Id = doctor.Id,
                Name = $"Dr.{doctor.FirstName} {doctor.LastName}",
                Description = doctor.Department?.Name, 
                ImgPath = doctor.ImageUrl
            }).ToList();

            return new ResponseDoctorsQuery(doctorCards);
        }
        private string GetRoleName(int RoleNumber)
        {
            return RoleNumber switch
            {
                1 => "Doctor",
                2 => "Nurse",
                3 => "Management Staff",
                4 => "Pharmacist",
                _ => "Unknown Role"
            };
        }
    }
}