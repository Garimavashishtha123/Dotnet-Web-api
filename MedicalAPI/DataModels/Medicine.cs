using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MedicalAPI.DataModels
{
    public class Medicine
    {
        public int id { get; set; }

        [MaxLength(150)]
        public string title { get; set; }

        [MaxLength(150)]
        public string description { get; set; }
        public double Price { get; set; }

        [MaxLength(800)]
        public string image { get; set; }
    }
}
