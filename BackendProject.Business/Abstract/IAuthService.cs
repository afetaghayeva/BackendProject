using System;
using System.Collections.Generic;
using System.Text;
using BackendProject.Entities.DTOs;
using Core.Entity.Concrete;
using Core.Utilities.Results;
using Core.Utilities.Security.JWT;

namespace BackendProject.Business.Abstract
{
    public interface IAuthService
    {
        IDataResult<User> Register(UserForRegisterDto userForRegisterDto, string password);
        IDataResult<User> Login(UserForLoginDto userForLoginDto);
        IResult UserExists(string email);
        IDataResult<AccessToken> CreateAccessToken(User user);
    }
}
