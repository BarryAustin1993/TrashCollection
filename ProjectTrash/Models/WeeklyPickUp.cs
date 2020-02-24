using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectTrash.Models
{
    public class WeeklyPickUp
    {
        [Key, ForeignKey("Account")]
        public int WeeklyPickUpId { get; set; }
        public Account Account { get; set; }

        public string DayOfTheWeek { get; set; }
    }
}
