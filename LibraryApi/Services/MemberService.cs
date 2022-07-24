using LibraryApi.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LibraryApi.Services
{
    public class MemberService : IMemberService
    {
        private readonly LibraryDbContext _context;


        public MemberService(LibraryDbContext context)
        {
            _context = context;
        }

        public async void AddMember(Member Member)
        {
    
            if(_context.Members != null)
            {
                _context.Add(Member);
                await _context.SaveChangesAsync();
                
            }
        }

        public Task<ActionResult<Member>> AddMember()
        {
            throw new NotImplementedException();
        }

        public async Task<ActionResult<IEnumerable<Member>>> GetMembers()
        {
            
            return await _context.Members.ToListAsync();
          

    }
    }
}
