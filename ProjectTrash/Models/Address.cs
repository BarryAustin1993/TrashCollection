using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectTrash.Models
{
    public class Address
    {
        [Key]
        public int ID { get; set; }

        public string address { get; set; }

        public string city { get; set; }

        public string state { get; set; }

        public int zipCode { get; set; }
    }
}
