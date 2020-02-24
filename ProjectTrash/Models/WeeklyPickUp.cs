using Microsoft.AspNetCore.Mvc.Rendering;
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
        [Key]
        public int WeeklyPickUpId { get; set; }

        public string DayOfTheWeek { get; set; }
        
    }
}
