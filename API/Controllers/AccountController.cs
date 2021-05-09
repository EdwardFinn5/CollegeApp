using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using API.Data;
using API.DTOs;
using API.Entities;
using API.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    public class AccountController : BaseApiController
    {
        private readonly DataContext _context;
        private readonly ITokenService _tokenService;
        public AccountController(DataContext context, ITokenService tokenService)
        {
            _tokenService = tokenService;
            _context = context;
        }

        [HttpPost("HsRegister")]
        public async Task<ActionResult<ColUserDto>> Register(HsRegisterDto hsRegisterDto)
        {
            if (await ColUserExists(hsRegisterDto.ColUserName)) return BadRequest("Username is taken");

            using var hmac = new HMACSHA512();

            var colUser = new ColUser
            {
                ColUserName = hsRegisterDto.ColUserName,
                PasswordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(hsRegisterDto.Password)),
                PasswordSalt = hmac.Key,
                ColUserType = hsRegisterDto.ColUserType
            };

            _context.ColUsers.Add(colUser);
            await _context.SaveChangesAsync();

            return new ColUserDto
            {
                ColUserName = colUser.ColUserName,
                Token = _tokenService.CreateToken(colUser),
                ColUserType = colUser.ColUserType
            };
        }

        [HttpPost("ColRegister")]
        public async Task<ActionResult<ColUserDto>> Register(ColRegisterDto colRegisterDto)
        {

            if (await ColUserExists(colRegisterDto.ColUserName)) return BadRequest("Username is taken");

            using var hmac = new HMACSHA512();

            var colUser = new ColUser
            {
                ColUserName = colRegisterDto.ColUserName,
                PasswordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(colRegisterDto.Password)),
                PasswordSalt = hmac.Key,
                ColUserType = colRegisterDto.ColUserType
            };

            _context.ColUsers.Add(colUser);
            await _context.SaveChangesAsync();

            return new ColUserDto
            {
                ColUserName = colUser.ColUserName,
                Token = _tokenService.CreateToken(colUser),
                ColUserType = colUser.ColUserType
            };
        }

        [HttpPost("colLogin")]
        public async Task<ActionResult<ColUserDto>> ColLogin(ColLoginDto colLoginDto)
        {

            var colUser = await _context.ColUsers
                .SingleOrDefaultAsync(x => x.ColUserName == colLoginDto.ColUserName);

            if (colUser == null)
            {
                return Unauthorized("Invalid username");
            }

            using var hmac = new HMACSHA512(colUser.PasswordSalt);

            var computedHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(colLoginDto.Password));

            for (var i = 0; i < computedHash.Length; i++)
            {
                if (computedHash[i] != colUser.PasswordHash[i]) return Unauthorized("Invalid password");
            }

            return new ColUserDto
            {
                ColUserName = colUser.ColUserName,
                Token = _tokenService.CreateToken(colUser),
                ColUserType = colUser.ColUserType
            };

        }

        private async Task<bool> ColUserExists(string colUsername)
        {
            return await _context.ColUsers.AnyAsync(x => x.ColUserName == colUsername.ToLower());
        }
    }
}