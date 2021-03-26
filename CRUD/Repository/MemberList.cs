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
    public static class MemberList
    {
        static List<Member> memList = null;
        static MemberList()
        {
            memList = new List<Member>()
            {
                new Member()
                {
                    MemberId = 1,
                    FirstName = "Minh",
                    LastName = "Nguyen",
                    Gender = "Male",
                    DateOfBirth = new DateTime(2000,05,06),
                    PhoneNumber ="142389642",
                    BirthPlace ="Ha Noi",
                    StartDate = new DateTime(2018,01,01),
                }
            };
        }

        public static List<Member> SelectMemberList()
        {
            return memList;
        }
        public static void InsertMemberList(Member member)
        {
            memList.Add(member);
        }
        public static void UpdateMemberList(Member member)
        {
            Member memUpdate = memList.Find(x => x.MemberId == member.MemberId);
            memUpdate.FirstName = member.FirstName;
            memUpdate.LastName = member.LastName;
            memUpdate.Gender = member.Gender;
            memUpdate.DateOfBirth = member.DateOfBirth;
            memUpdate.BirthPlace = member.BirthPlace;
            memUpdate.StartDate = member.StartDate;
        }
        public static void DeleteMemberList(int id)
        {
            Member empDelete = memList.Find(x => x.MemberId == id);
            memList.Remove(empDelete);
        }
    }
}