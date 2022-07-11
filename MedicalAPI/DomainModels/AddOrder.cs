using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MedicalAPI.DomainModels
{
    public class AddOrder
    {
        public int id { get; set; }

        [MaxLength(150)]
        public string title { get; set; }

        [MaxLength(150)]
        public string description { get; set; }
        public double Price { get; set; }

        public int quantity { get; set; }

        public double total { get; set; }
    }
}
