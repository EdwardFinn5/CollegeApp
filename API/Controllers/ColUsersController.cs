using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    public class ColUsersController : BaseApiController
    {
        private readonly DataContext _context;
        public ColUsersController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<ActionResult<IEnumerable<ColUser>>> GetColUsers()
        {
            return await _context.ColUsers.ToListAsync();
        }

        [Authorize]
        [HttpGet("{id}")]
        public async Task<ActionResult<ColUser>> GetColUser(int id)
        {
            return await _context.ColUsers.FindAsync(id);

        }
    }
}