using Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class User : BaseEntity
    {
        public string FullName { get; set; }
        [NotNull]
        public string Email { get; set; }

        [NotNull]
        public string Password { get; set; }

        public bool IsActive { get; set; } = false;

    }

    public class Admin: User
    {
        public string JobTitle { get; set; }
        public DateTime HireDate { get; set; }

    }

    public class Customer : User
    {
        public int Phone { get; set; }
        public string Address { get; set; }

    }


}
