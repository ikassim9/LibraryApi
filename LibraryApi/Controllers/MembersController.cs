using LibraryApi.Model;
using LibraryApi.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LibraryApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MembersController : ControllerBase
    {

        //   private readonly IMemberService _memberService;

        private readonly LibraryDbContext _context;


        public MembersController(LibraryDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>All Books in DB </returns>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Member>>> GetMembers()
        {
            if (_context.Members == null)
            {
                return NotFound();
            }
            return await _context.Members.ToListAsync();

        }
    }

    }