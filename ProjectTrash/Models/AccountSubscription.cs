using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectTrash.Models
{
    public class AccountSubscription
    {
        [Key]
        public int Id { get; set; }

        public bool isActive { get; set; }

        public bool isSuspended { get; set; }

        public DateTime accountStartDate { get; set; }

        public DateTime accountEndDate { get; set; }

        public DateTime suspensionStartDate { get; set; }

        public DateTime suspensionEndDate { get; set; }


    }

}
