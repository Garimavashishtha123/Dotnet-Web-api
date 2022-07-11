using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MedicalAPI.DomainModels
{
    public class MedicineDomain
    {
        public int id { get; set; }

        [MaxLength(150)]
        public string title { get; set; }

        [MaxLength(150)]
        public string description { get; set; }
        public decimal Price { get; set; }

        [MaxLength(800)]
        public string image { get; set; }
    }
}
