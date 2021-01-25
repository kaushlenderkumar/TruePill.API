using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Truepill.API.Models
{
    public class Patient : ErrorModel
    {
       
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string gender { get; set; }
        public string dob { get; set; }
        public string mbi { get; set; }
        public string address { get; set; }
        public string name { get; set; }
        public string street1 { get; set; }
        public string street2 { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string zip { get; set; }
        public string company { get; set; }
        public string country { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public string patient_token { get; set; }
    }

    public class PatientModel
    {

        public string first_name { get; set; }
        public string last_name { get; set; }
        public string gender { get; set; }
        public string dob { get; set; } 
        public string street1 { get; set; }
        public string street2 { get; set; }
        public string city { get; set; }
        public string state { get; set; }        
        public string country { get; set; }
        public string zip { get; set; }
        public string phone { get; set; }
        public string email { get; set; } 
    }
}
