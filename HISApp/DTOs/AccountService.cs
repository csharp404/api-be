using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using HISApp.Constants;
using HISApp.Domain;
using HISApp.ENums;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace HISApp.DTOs
{
    public class AccountService(RoleManager<IdentityRole> roleManager, UserManager<User> userManager, SignInManager<User> signin, IConfiguration configuration, IHttpContextAccessor httpContextAccessor)
    {

        public async Task<string> Register(SignUpDTO user)
        {
            var add = new Address()
            {
                AreaId = user.areaid,
                CityId = user.cityid
            };
            User usr = new()
            {
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.email,
                UserName = user.email,
                PhoneNumber = user.phonenumber,
                Age = user.age,
                Gender = user.gender == 1 ? true : false,
                DepartmentId = user.departmentid,
                Experience = user.experience,
                Address = add,
                HireDate = user.hiredate,
                AddressId = add.Id
            };

            string role = GetRoleName(user.Role);
            var res = await userManager.CreateAsync(usr, user.Password);
            var res2 = await userManager.AddToRoleAsync(usr, role);
            if (res.Succeeded)
            {
                //ToDo:here what i have to do when , send a notification to the admin to determine the role of this user
                return "creating operation successful...!!!";
            }

            return "creating operation Fail...!!!";
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

        public async Task<string> ChangePassword(string OldPassword, string NewPassword)
        {
            // Access the HttpContext to retrieve the JWT token claims
            var userClaims = httpContextAccessor.HttpContext?.User;

            if (userClaims == null || !userClaims.Identity.IsAuthenticated)
            {
                return "User is not authenticated.";
            }


            var userIdClaim = userClaims.Claims.FirstOrDefault(c => c.Type == "Id");
            if (userIdClaim == null)
            {
                return "User ID not found in token.";
            }

            var userId = userIdClaim.Value; // Extract the value of the claim

            // Find the user by ID
            var usr = await userManager.FindByIdAsync(userId);
            if (usr == null)
            {
                return "User not found.";
            }

            // Check the old password
            var res = await userManager.CheckPasswordAsync(usr, OldPassword);
            if (res)
            {
                // Change the password
                var changePasswordResult = await userManager.ChangePasswordAsync(usr, OldPassword, NewPassword);
                if (changePasswordResult.Succeeded)
                {
                    return "Changing password operation succeeded!";
                }
                else
                {
                    return "Failed to change password: " + string.Join(", ", changePasswordResult.Errors.Select(e => e.Description));
                }
            }

            return "Old password is incorrect.";
        }

        public async Task<string> DisableAccount(string Email)
        {
            var usr = userManager.FindByEmailAsync(Email).Result;
            var res = userManager.DeleteAsync(usr).Result;
            if (res.Succeeded)
            {
                return "Deleted Sccessfully ... !!!";
            }

            return "delete fail !!!";
        }
        public async Task<string> Login(string Email, string Password)
        {


            try
            {
                User usr = new()
                {
                    UserName = Email,
                    Email = Email
                };
                // Use SignInManager to validate user credentials
                var res = signin.PasswordSignInAsync(usr.UserName, Password, true, false).Result;

                if (res.Succeeded)
                {
                    // Retrieve the user by email
                    var identityUser = await userManager.FindByEmailAsync(Email);

                    if (identityUser != null)
                    {
                        // Generate a token after successful login
                        var token = GenerateTokenAsync(identityUser);
                        return token.Result;
                    }
                }
                else
                {
                    return "Failed Login";
                }
            }
            catch (Exception e)
            {
                // Consider using a logging framework instead of Console.WriteLine
                Console.WriteLine(e.Message);
                // Optionally log the stack trace as well
                Console.WriteLine(e.StackTrace);
            }

            return string.Empty;
        }

        private async Task<string> GenerateTokenAsync(User user)
        {

            var jwtSecret = configuration.GetSection("JWTSecret").Value;
            if (string.IsNullOrEmpty(jwtSecret))
            {
                throw new InvalidOperationException("JWT secret is not configured.");
            }

            var jwtSecretBytes = Encoding.ASCII.GetBytes(jwtSecret);

            // Create claims for the user
            var claims = new List<Claim>
            {
                new Claim("Id", user.Id.ToString()),
                new Claim("Email", user.Email),
                
            };

            
            if (await userManager.IsInRoleAsync(user, "Admin"))
            {
                claims.Add(new Claim(ClaimTypes.Role, "Admin"));
            }
            else if (await userManager.IsInRoleAsync(user, "Doctor"))
            {
                claims.Add(new Claim(ClaimTypes.Role, "Doctor"));
            }
            else if (await userManager.IsInRoleAsync(user, "Nurse"))
            {
                claims.Add(new Claim(ClaimTypes.Role, "Nurse"));
            } 
            else if (await userManager.IsInRoleAsync(user, "Pharmacist"))
            {
                claims.Add(new Claim(ClaimTypes.Role, "Pharmacist"));
            }
            else
            {
                claims.Add(new Claim(ClaimTypes.Role, "Management Staff"));
            }

            // Create token descriptor
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Audience = "Us",
                Issuer = "Us",
                Subject = new ClaimsIdentity(claims),
                Expires = DateTime.UtcNow.AddDays(10), // Use UTC to avoid timezone issues
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(jwtSecretBytes), SecurityAlgorithms.HmacSha256)
            };

            // Create token handler and generate token
            var tokenHandler = new JwtSecurityTokenHandler();
            var token = tokenHandler.CreateToken(tokenDescriptor);

            return tokenHandler.WriteToken(token);
        }



    }
}
