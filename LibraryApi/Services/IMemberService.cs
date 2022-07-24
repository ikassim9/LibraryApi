using LibraryApi.Model;
using Microsoft.AspNetCore.Mvc;

namespace LibraryApi.Services
{
    public interface IMemberService
    {
        Task<ActionResult<IEnumerable<Member>>> GetMembers();

        Task<ActionResult<Member>> AddMember();
    }

}