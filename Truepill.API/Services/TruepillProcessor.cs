using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Truepill.API.Models;

namespace Truepill.API.Services
{
    public class TruepillProcessor
    {
        
        public static async Task<string> GetPatient(string patient_token)
        {
            string url = $"patient/{patient_token}";

            using(HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
            {
                var resp = "";
                if (response.IsSuccessStatusCode)
                {
                    resp = await response.Content.ReadAsStringAsync();
                    //patient = JsonConvert.DeserializeObject<Patient>(resp);

                    return resp;
                }
                else
                {
                    var failResult = response.Content.ReadAsStringAsync().Result;
                    resp = failResult;
                    //resp = JsonConvert.DeserializeObject<Patient>(failResult);

                    //return resp;
                    //var statusCode = result.;
                    //var error = response.ReasonPhrase;
                    //var message = response.RequestMessage;

                    //throw new Exception(response.ReasonPhrase);
                }

                return resp;
            }
        }


        public static async Task<string> PutPatient(PatientModel patient)
        {
            var url = "patient";

            if(patient.first_name != null)
            { 
                StringContent content = new StringContent(JsonConvert.SerializeObject(patient), Encoding.UTF8, "application/json");

                using (HttpResponseMessage response = await ApiHelper.ApiClient.PutAsync(url, content))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        return response.Content.ReadAsStringAsync().Result;
                    }
                    else
                    {
                        var failResult = response.Content.ReadAsStringAsync().Result;
                        return failResult;
                        //patient = JsonConvert.DeserializeObject<Patient>(failResult);

                        //var statusCode = result.;
                        //var error = response.ReasonPhrase;
                        //var message = response.RequestMessage;

                        //throw new Exception(response.ReasonPhrase);
                    }

                }

            }

            return null;
        }
         
    }
}
