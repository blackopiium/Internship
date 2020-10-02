using AutoMapper;
using Furn_Store.Data.Models;
using Furn_Store.Data.UnitOfWorkFolder;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using Furn_Store.Business.Interfaces;
using Furn_Store.Business.DTO.Identity;
using Microsoft.AspNetCore.Identity;

namespace Furn_Store.Business.Services
{
    public class AccountService : IAccountService
    {
        private readonly IUnitOfWork _uow;
        private readonly IMapper _mapper;
        private readonly IConfiguration _configuration;
        public AccountService(IUnitOfWork uow, IMapper mapper, IConfiguration configuration)
        {
            _uow = uow;
            _mapper = mapper;
            _configuration = configuration;
        }
        public async Task<IdentityResult> Register(RegisterDTO myUser)
        {
            MyUser user = new MyUser { Email = myUser.Email, UserName = myUser.UserName };
            var result = await _uow.userManager.CreateAsync(user, myUser.Password);
            return result; 
        }
        public async Task<LoginToken> Login(LoginDTO myUser)
        {
            MyUser user = await _uow.userManager.FindByNameAsync(myUser.UserName);
            if (user != null)
            {
                var result = await _uow.signInManager.PasswordSignInAsync(myUser.UserName, myUser.Password, myUser.RememberMe, false);
                if (result.Succeeded)
                    return new LoginToken { token = await CreateToken(user), success = true };
                else
                    return new LoginToken { success = false, error = "Invalid password" };
            }
            return new LoginToken { success = false, error = "User not found" };
        }
        public async Task<string> Exit()
        {
            await _uow.signInManager.SignOutAsync();
            return "Exited";
        }
        public async Task<List<MyUser>> List()
        {
            return await _uow.userManager.Users.ToListAsync();
        }
        private async Task<string> CreateToken(MyUser myUser)
        {

            var roles = await _uow.signInManager.UserManager.GetRolesAsync(myUser);
            var claims = new List<Claim>();

            claims.Add(new Claim(ClaimTypes.Name, myUser.UserName));
            claims.Add(new Claim("accountId", myUser.Id.ToString()));
            claims.Add(new Claim("email", myUser.Email));
            foreach (var role in roles)
            {
                claims.Add(new Claim(ClaimTypes.Role, role));
            }


            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JwtSecurityKey"]));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var expiration = DateTime.UtcNow.AddDays(double.Parse(_configuration["JwtExpiryInDays"]));

            JwtSecurityToken token = new JwtSecurityToken(
                issuer: _configuration["JwtIssuer"],
                audience: _configuration["JwtAudience"],
                claims: claims,
                notBefore: DateTime.UtcNow,
                expires: expiration,
                signingCredentials: creds);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}