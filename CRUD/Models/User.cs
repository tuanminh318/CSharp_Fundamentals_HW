using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;    

namespace CRUD.Models
{
    public class User
    {
        public int UserId { get; set; }

        public String Username { get; set; }
        [DataType(DataType.Password)]
        public String Password { get; set; }
        public int RoleId { get; set; }
    }
}