using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedicalAPI.DataModels
{
    public class Appointment
    {
        
        public int id { get; set; }
        public string name { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public string dob { get; set; }
        public string appdate { get; set; }
        public string apptime { get; set; }
        public string dname { get; set; }
    }
}
