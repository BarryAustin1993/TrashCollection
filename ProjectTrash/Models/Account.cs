using Microsoft.AspNetCore.Mvc.Rendering;
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

        

        public Account()
        {
            this.AccountSubscription = new AccountSubscription();
            this.Address = new Address();
        }
        [Key]
        public int AccountID { get; set; }

        public double Balance { get; set; }

        public virtual AccountSubscription AccountSubscription { get; set; }

        public DayOfWeek PickUpDay { get; set; }

        public virtual Address Address { get; set; }

        [ForeignKey("Customer")]
        public int CustomerId { get; set; }
        public Customer customer { get; set; }



    }
}
