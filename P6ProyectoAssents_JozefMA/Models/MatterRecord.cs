using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RestSharp;
using RestSharp.Authenticators;

namespace P6ProyectoAssents_JozefMA.Models 
{ 

internal class MatterRecord
{
    public RestRequest request { get; set; }
    const string mimeType = "application/json";
    const string contentType = "Content-Type";

        public int MatterRecordId { get; set; }

        public int ScheduleId { get; set; }

        public int MaterialId { get; set; }

        public int Quantity { get; set; }



        public async Task<List<MatterRecord>?> GetAllMatterRecordAsync()
    {
        try
        {

            string RouterSufix = string.Format("MatterRecord");


            string URL = Services.WebAPIConnection.ProductionURLPrefix + RouterSufix;

            var client = new RestClient(URL);

            request = new RestRequest(URL, Method.Get);


            request.AddHeader(Services.WebAPIConnection.ApiKeyName,
                              Services.WebAPIConnection.ApiKeyValue);


            RestResponse response = await client.ExecuteAsync(request);


            HttpStatusCode statusCode = response.StatusCode;

            if (statusCode == HttpStatusCode.OK)
            {

                var list = JsonConvert.DeserializeObject<List<MatterRecord>>(response.Content);

                return list;
            }
            else
            {
                return null;
            }

        }
        catch (Exception ex)
        {
            string ErrorMsg = ex.Message;
            throw;
        }

    }

    }
}
