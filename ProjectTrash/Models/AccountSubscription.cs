using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectTrash.Models
{
    public class AccountSubscription
    {
        [Key, ForeignKey("Account")]
        public int AccountSubscritionId { get; set; }
        public Account Account { get; set; }

        public bool IsActive { get; set; }

        public bool IsSuspended { get; set; }

        public DateTime AccountStartDate { get; set; }

        public DateTime? AccountEndDate { get; set; }

        public DateTime? SuspensionStartDate { get; set; }

        public DateTime? SuspensionEndDate { get; set; }


    }

}
