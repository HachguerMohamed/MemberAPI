using Members.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Members.Data.Interface
{
    public interface IMember
    {
        List<Member> GetAllMembre();
        Member GetMembre(int id);
    }
}
