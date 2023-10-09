using Members.Data.Interface;
using Members.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Members.Data.Repository
{
    public class MemberRepository : IMember
    {
        List<Member> lisMembres = new List<Member>
        {
             new Member{MemberId=1, FirstName="Oussama", LastName="ELHOUSNI",
                 Address="Vadodara" },
             new Member{MemberId=2, FirstName="Mamadou", LastName="CISSE",
                 Address="Vadodara" },
             new Member{MemberId=3, FirstName="Amina", LastName="NEDLOUSSI",
                 Address="Vadodara" },
             new Member{MemberId=4, FirstName="Imane", LastName="GHAZOUANE",
                 Address="Vadodara" },
             new Member{MemberId=5, FirstName="Said", LastName="AJKIOU",
                 Address="Vadodara" },
             new Member{MemberId=6, FirstName="Lahoucine", LastName="OUMLIL",
            Address="Vadodara" },
        };
        public List<Member> GetAllMembre()
        {
            return lisMembres;
        }
        public Member GetMembre(int id)
        {
            return lisMembres.FirstOrDefault(x => x.MemberId == id);
        }

    }
}
