using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Truepill.API.Models;
using Truepill.API.Services;

namespace Truepill.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientController : ControllerBase
    {
        private static readonly HttpClient client = new HttpClient();
        private readonly IConfiguration _configuration;
        public PatientController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
         
        [HttpGet]
        public async Task<string> Get(string patient_token)
        {
            try
            {
                if(patient_token == "")
                {
                    var response = new {
                        message = "missing patient token id"
                    };

                    return JsonConvert.SerializeObject(response);
                }


                ApiHelper.InitializeClient();

                var patient = await TruepillProcessor.GetPatient(patient_token);
                return patient;

                //if(patient.error != null)
                //{
                //    var result = new ErrorModel
                //    {
                //        statusCode = patient.statusCode,
                //        error = patient.error,
                //        message = patient.message
                //    };

                //    var json = Newtonsoft.Json.JsonConvert.SerializeObject(result);

                //    return json;
                //}
                //else
                //{
                //    var result = new Patient
                //    {
                //        first_name = patient.first_name 
                //    }; 

                //    var json = Newtonsoft.Json.JsonConvert.SerializeObject(result);

                //    return json;
                //}

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);

            }

            return null; 
        }

        [HttpPut]
        public async Task<string> Put()
        {
            try
            {
                ApiHelper.InitializeClient();

                var model = new PatientModel()
                {
                      first_name= "Bruce",
                      last_name = "Banner",
                      gender = "male",
                      dob = "19691218",
                      street1 = "123 Some Lane",
                      street2 = "Apt. 123",
                      city = "Los Angeles",
                      state = "CA",
                      country = "US",
                      zip = "94402",
                      phone = "430-304-3949",
                      email = "hulkout@hulk.com"
                };

                var patient = await TruepillProcessor.PutPatient(model);
                //var result = JsonConvert.SerializeObject(patient);
                return patient;

                //if (!ModelState.IsValid)
                //    return BadRequest("Not a valid model");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }

            return null;
        }
    }
}
