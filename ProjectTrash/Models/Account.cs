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
        public int ID { get; set; }

        public double balance { get; set; }

        [ForeignKey("AccountSubscription")]
        public int AccountSubscriptionID { get; set; }
        public AccountSubscription AccountSubscription { get; set; }

        [ForeignKey("Address")]
        public int AddressID { get; set; }
        public Address Address { get; set; }

        [ForeignKey("WeeklyPickup")]
        public int weeklyPickUp { get; set; }   
        public WeeklyPickUp WeeklyPickUp { get; set; }


    }
}
