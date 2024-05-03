using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using P6ProyectoAssents_JozefMA.Models;
using RestSharp;
using System.Net; 

namespace P6ProyectoAssents_JozefMA.ViewModels
{
    public class UserViewModel : BaseViewModel
    {
        public RestRequest request { get; set; }
        const string mimeType = "application/json";
        const string contentType = "Content-Type";

        public int UserRoleId { get; set; }

        public string UserRoleDescription { get; set; } = null!;

        public async Task<List<UserRole>?> GetAllUserRolesAsync()
        {
            try
            {

                string RouterSufix = string.Format("UserRoles");

                string URL = Services.WebAPIConnection.ProductionURLPrefix + RouterSufix;

                var client = new RestClient(URL);

                request = new RestRequest(URL, Method.Get);

                request.AddHeader(Services.WebAPIConnection.ApiKeyName,
                                  Services.WebAPIConnection.ApiKeyValue);

                RestResponse response = await client.ExecuteAsync(request);

                HttpStatusCode statusCode = response.StatusCode;

                if (statusCode == HttpStatusCode.OK)
                {
                    var list = JsonConvert.DeserializeObject<List<UserRole>>(response.Content);

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
