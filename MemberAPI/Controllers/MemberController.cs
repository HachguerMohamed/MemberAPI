using Members.Data.Interface;
using Members.Data.Model;
using Members.Data.Repository;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MemberAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MemberController : ControllerBase
    {
        private IMember membres = new MemberRepository();
        [HttpGet]
        public ActionResult<IEnumerable<Member>> GetAllMembres()
        {
            return membres.GetAllMembre();
        }
        [HttpGet("{id}")]
        public ActionResult<Member> GetMembreById(int id)
        {
            return membres.GetMembre(id);
        }

    }
}
