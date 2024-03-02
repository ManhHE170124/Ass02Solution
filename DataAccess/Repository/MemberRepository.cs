using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class MemberRepository : IMemberRepository
    {
        public void DeleteMember(int MemberId) => MemberDAO.Instance.Remove(MemberId);

        public IEnumerable<MemberObject> GetAllMembers() => MemberDAO.Instance.GetMemberList();

        public List<MemberObject> GetMemberByAscending() => MemberDAO.Instance.GetMemberByAscending();

        public List<MemberObject> GetMemberByDescending() => MemberDAO.Instance.GetMemberByDescending();

        public MemberObject GetMemberByEmailAndPassword(string email, string password) => MemberDAO.Instance.GetMemberByEmailAndPassword(email, password);

        public List<MemberObject> GetMemberByFilter(string filter, string location) => MemberDAO.Instance.GetMemberByFilter(filter, location);

        public List<MemberObject> GetMemberBySearch(string search, string key) => MemberDAO.Instance.GetMemberBySearch(search, key);

        public MemberObject GetMemberObject(int MemberId) => MemberDAO.Instance.GetMemberByID(MemberId);    

        public void InsertMember(MemberObject member) => MemberDAO.Instance.AddNew(member);

        public void UpdateMember(MemberObject member) => MemberDAO.Instance.Update(member);
    }
}
