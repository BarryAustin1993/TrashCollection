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

        [ForeignKey("IdentityUser")]
        public string UserId { get; set; }
        public IdentityUser IdentityUser { get; set; }

        [ForeignKey("account")]
        public int accountID { get; set; }
        public Account account { get; set; }

        public string firstName { get; set; }

        public string lastName { get; set; }
    }

}
