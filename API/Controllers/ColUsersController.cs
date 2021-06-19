using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using API.Data;
using API.DTOs;
using API.Entities;
using API.Interfaces;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [Authorize]
    public class ColUsersController : BaseApiController
    {
        private readonly IColUserRepository _colUserRepository;
        private readonly IMapper _mapper;
        public ColUsersController(IColUserRepository colUserRepository, IMapper mapper)
        {
            _mapper = mapper;
            _colUserRepository = colUserRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ColMemberDto>>> GetColUsers()
        {
            var colUsers = await _colUserRepository.GetColMembersAsync();

            return Ok(colUsers);
        }

        [HttpGet("{colusername}")]
        public async Task<ActionResult<ColMemberDto>> GetColUser(string colusername)
        {
            return await _colUserRepository.GetColMemberAsync(colusername);
        }

        [HttpPut]
        public async Task<ActionResult> UpdateColUser(ColMemberUpdateDto colMemberUpdateDto)
        {
            var colUsername = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            var colUser = await _colUserRepository.GetColUserByUsernameAsync(colUsername);

            _mapper.Map(colMemberUpdateDto, colUser);

            _colUserRepository.Update(colUser);

            if (await _colUserRepository.SaveAllAsync()) return NoContent();

            // _unitOfWork.UserRepository.Update(user);

            // var collegePrep = new CollegePrep
            // {
            //     AcademicPlus = memberUpdateDto.AcademicPlus
            // };

            // user.CollegePreps.Add(collegePrep);

            // user.CollegePreps.a Entry(user.CollegePreps.AcademicPlus).State = EntityState.Modified;

            // _context.Entry(user).State = EntityState.Modified;

            // if (await _unitOfWork.Complete()) return NoContent();

            return BadRequest("Failed to update colUser");
        }
    }
}