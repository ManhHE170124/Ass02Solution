using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IMemberRepository
    {
        IEnumerable<MemberObject> GetAllMembers();
        MemberObject GetMemberObject(int MemberId);
        void InsertMember(MemberObject member);
        void DeleteMember(int MemberId);
        void UpdateMember(MemberObject member);
        List<MemberObject> GetMemberBySearch(string search, string key);
        List<MemberObject> GetMemberByFilter(string filter, string location);
        List<MemberObject> GetMemberByDescending();
        List<MemberObject> GetMemberByAscending();
        MemberObject GetMemberByEmailAndPassword(string email, string password);
    }
}
