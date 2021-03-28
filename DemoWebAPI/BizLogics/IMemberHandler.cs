using System;
using System.Collections.Generic;
using System.Linq;
using DemoWebAPI.Models;
using System.Threading.Tasks;
using DemoWebAPI.Models;

namespace DemoWebAPI.BizLogics
{
    public interface IMemberHandler
    {
        // 1. Return list members who is male

        List<Member> FilterMemberByGender(string gender);
        // 2. Return the oldest one

        Member ReturnTheOldestMember();
        // 3. Return full name of members

        List<string> GetMemberWithFullNameOnly(); 
        // 4.1 Return list of members who has birth year is 2000

        List<Member> FilterMemberByBirthYear(int year); 
        // 4.2 Return list of member who has birth year less than 2000

        List<Member> FilterMemberByBirthYearLessThan(int year); 
        // 4.3 Return list of member who has birth year greater than 2000

        List<Member> FilterMemberByBirthYearGreaterThan(int year);
        // 5. Return list members who born in HaNoi

        List<Member> FilterMemberByBirthPlace(string place);
        // 6. Add new member to classification

        List<Member> AddNewMember(Member member);
    }
}