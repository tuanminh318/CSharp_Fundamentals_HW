using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using DemoWebAPI.Models;


namespace DemoWebAPI.BizLogics
{
    public class MemberHandler : IMemberHandler
    {
        private List<Member> _listMembers;
        public MemberHandler()
        {
            SeedingData();
        }
        public List<Member> AddNewMember(Member member)
        {
            _listMembers.Add(member);
            return _listMembers;
        }
        public List<Member> FilterMemberByBirthPlace(string place)
        {
            var result = _listMembers.Where(x => x.BirthPlace == place).ToList();
            
            return result;
        }

        public List<Member> FilterMemberByBirthYear(int year)
        {
            var result = _listMembers.Where(x => x.DoB.Year == year).ToList();
            
            return result;
        }
        
        public List<Member> FilterMemberByBirthYearGreaterThan(int year)
        {
            var result = _listMembers.Where(x => x.DoB.Year < year).ToList();
            
            return result;
        }

        public List<Member> FilterMemberByBirthYearLessThan(int year)
        {
            var result = _listMembers.Where(x => x.DoB.Year > year).ToList();
            
            return result;
        }

        public List<Member> FilterMemberByGender(string gender)
        {
            var result = _listMembers.Where(x => x.Gender == gender).ToList();

            return result;
        }

        public List<string> GetMemberWithFullNameOnly()
        {
            var result = _listMembers.Select(x => $"{x.FirstName + x.LastName}").ToList();

            return result;
        }

        public Member ReturnTheOldestMember()
        {
            var minDob = _listMembers.Min(x => x.DoB);
            var result = _listMembers.FirstOrDefault(x => x.DoB == minDob);

            return result;
        }
        private void SeedingData()
        {
            //Create list member
            _listMembers = new List<Member>
            {
                new Member
                {
                    FirstName = "Thanh",
                    LastName = "Le",
                    BirthPlace = "Ha Noi",
                    DoB = DateTime.Now.AddYears(-30),
                    Gender = "Male",
                    IsGraduated = true,
                    PhoneNumber = "0123456789",
                    StartDate = DateTime.Now.AddYears(-10),
                    EndDate = DateTime.Now.AddYears(5)
                },
                 new Member
                {
                    FirstName = "Tung",
                    LastName = "Vu",
                    BirthPlace = "Bac Ninh",
                    DoB = DateTime.Now.AddYears(-24),
                    Gender = "Male",
                    IsGraduated = true,
                    PhoneNumber = "0123456789",
                    StartDate = DateTime.Now.AddYears(-10),
                    EndDate = DateTime.Now.AddYears(5)
                },
                  new Member
                {
                    FirstName = "Thao",
                    LastName = "Vu",
                    BirthPlace = "Ha Noi",
                    DoB = DateTime.Now.AddYears(-26),
                    Gender = "Female",
                    IsGraduated = true,
                    PhoneNumber = "0123456789",
                    StartDate = DateTime.Now.AddYears(-10),
                    EndDate = DateTime.Now.AddYears(5)
                },
                   new Member
                {
                    FirstName = "Thang",
                    LastName = "Nguyen",
                    BirthPlace = "Da Nang",
                    DoB = DateTime.Now.AddYears(-15),
                    Gender = "Male",
                    IsGraduated = true,
                    PhoneNumber = "0123456789",
                    StartDate = DateTime.Now.AddYears(-10),
                    EndDate = DateTime.Now.AddYears(5)
                },
                    new Member
                {
                    FirstName = "Phuong",
                    LastName = "Nguyen",
                    BirthPlace = "Ha Noi",
                    DoB = DateTime.Now.AddYears(-20),
                    Gender = "Female",
                    IsGraduated = true,
                    PhoneNumber = "0123456789",
                    StartDate = DateTime.Now.AddYears(-10),
                    EndDate = DateTime.Now.AddYears(5)
                },
            };
        }
    }
}