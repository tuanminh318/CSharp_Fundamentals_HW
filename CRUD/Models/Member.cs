using System;
using System.Collections.Generic;

namespace CRUD.Models
{
    public class Member
    {
        public int MemberId { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public String PhoneNumber { get; set; }
        public String BirthPlace { get; set; }
        public DateTime StartDate { get; set; }
    }
}