using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectTrash.Models
{
    public class Employee
    {
        [Key]
        public int ID { get; set; }

        [ForeignKey("ApplicationUser")]
        public string UserId { get; set; }
        public IdentityUser ApplicationUser { get; set; }

        public string firstName { get; set; }

        public string lastName { get; set; }

        public int zipcode { get; set; }
    }
}
