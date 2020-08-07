using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.Data.Models
{
    public class UserRole
    {
        public Role Role { get; set; }

        public string RoleId { get; set; }

        public User User { get; set; }

        public string UserId { get; set; }
    }
}
