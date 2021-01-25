using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Truepill.API.Models
{
    public class ErrorModel
    {
        public string statusCode { get; set; }
        public string error { get; set; }
        public string message { get; set; }
    }
}
