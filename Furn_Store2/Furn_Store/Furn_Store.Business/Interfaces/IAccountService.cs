using Furn_Store.Business.DTO.Identity;
using Furn_Store.Data.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Furn_Store.Business.Interfaces
{
    public interface IAccountService
    {
        public Task<IdentityResult> Register(RegisterDTO myUser);
        /*public Task<string> Create(MyUserDTO myUser);*/
        public Task<LoginToken> Login(LoginDTO myUser);
        public Task<string> Exit();
        public Task<List<MyUser>> List();
    }
}
