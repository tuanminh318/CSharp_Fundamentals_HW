using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CRUD.Models;

namespace CRUD.Repository
{
    public class MemberRepository : IMemberRepository
    {
        public void DeleteMember(int id)
        {
            MemberList.DeleteMemberList(id);
        }

        public void InsertMember(Member member)
        {
            MemberList.InsertMemberList(member);
        }

        public List<Member> SelectAllEmployees()
        {
            return MemberList.SelectMemberList();
        }

        public Member SelectMemberById(int id)
        {
            return MemberList.SelectMemberList().Find(x => x.MemberId == id);
        }

        public void UpdateMember(Member member)
        {
            MemberList.UpdateMemberList(member);
        }
    }
}
