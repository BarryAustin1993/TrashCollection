using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectTrash.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("ApplicationUser")]
        public string UserId { get; set; }
        public IdentityUser ApplicationUser { get; set; }

        [ForeignKey("Account")]
        public int accountID { get; set; }
        public Account account { get; set; }

        public string firstName;

        public string lastName;
    }

}
