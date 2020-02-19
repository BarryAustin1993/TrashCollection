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

        public string address;

        public string city;

        public string state;

        public int zipCode;
    }
}
