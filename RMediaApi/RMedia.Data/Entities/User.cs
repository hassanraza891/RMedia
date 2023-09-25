using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMedia.Data.Entities
{
    public class User
    {
        public Guid User_id { get; set; }
        public string Username { get; set; }
        public string Password_hash { get; set; }
        public string Role { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public string Email { get; set; }
        [NotMapped]
        public bool IsStudent { get; set; }
        [NotMapped]
        public bool IsFaculty { get; set; }
    }
}
