using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectTrash.Models
{
    public class PickUp
    {
        [Key]
        public int PickUpID { get; set; }

        [ForeignKey("Account")]
        public int AccountID { get; set; }
        public Account Account { get; set; }

        public DateTime PickUpDate { get; set; }


        [ForeignKey("Employee")]
        public int? EmployeeID { get; set; }
        public Employee Employee { get; set; }

        public bool Completed { get; set; }
    }

}
