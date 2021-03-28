using Microsoft.AspNetCore.Mvc;
using DemoWebAPI.BizLogics;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using DemoWebAPI.Models;
using System.Threading.Tasks;

namespace DemoWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MemberController : ControllerBase
    {
        private IMemberHandler _memberHandler;
        public MemberController(IMemberHandler memberHandler)
        {
            _memberHandler = memberHandler;
        }

        [HttpGet]
        [Route("/api/member/memberbygender/{gender}")]
        public List<Member> FilterMemberByGender(string gender)
        {
            return _memberHandler.FilterMemberByGender(gender);
        }

        [HttpGet]
        [Route("/api/member/ReturnTheOldestMember")]
        public Member ReturnTheOldestMember()
        {
            return _memberHandler.ReturnTheOldestMember();
        }

        [HttpGet]
        [Route("/api/member/memberbyplace/{place}")]
        public List<Member> FilterMemberByBirthPlace(string place)
        {
            return _memberHandler.FilterMemberByBirthPlace(place);
        }

        [HttpGet]
        [Route("/api/member/GetMemberWithFullNameOnly")]
        public List<string> GetMemberWithFullNameOnly()
        {
            return _memberHandler.GetMemberWithFullNameOnly();
        }

        [HttpGet]
        [Route("/api/member/FilterMemberByBirthYear/{year}")]
        public List<Member> FilterMemberByBirthYear(int year)
        {
            return _memberHandler.FilterMemberByBirthYear(year);
        }

        [HttpGet]
        [Route("/api/member/FilterMemberByBirthYearLessThan/{year}")]
        public List<Member> FilterMemberByBirthYearLessThan(int year)
        {
            return _memberHandler.FilterMemberByBirthYearLessThan(year);
        }

        [HttpGet]
        [Route("/api/member/FilterMembersByBirthYearGreater/{year}")]
        public List<Member> FilterMemberByBirthYearGreatherThan(int year)
        {
            return _memberHandler.FilterMemberByBirthYearGreatherThan(year);
        }
        
        [HttpPost]
        public List<Member> Post(Member member)
        {
            return _memberHandler.AddNewMember(member);
        }
    }
}