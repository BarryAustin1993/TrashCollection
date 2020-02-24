using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectTrash.Models
{
    public class Account
    {
        [Key]
        public int AccountID { get; set; }

        public double Balance { get; set; }

        [ForeignKey("Customer")]
        public int CustomerId { get; set; }
        public Customer customer { get; set; }

        [ForeignKey("WeeklyPickUp")]
        public int WeeklyPickUpId { get; set; }
        public WeeklyPickUp WeeklyPickUp { get; set; }
    }
}
