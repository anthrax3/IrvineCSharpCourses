using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace School.Data
{
    public partial class UserRole
    {
        public int UserID { get; set; }
        public virtual User User { get; set; }
        public short RoleID { get; set; }
        public virtual Role Role { get; set; }
    }
}