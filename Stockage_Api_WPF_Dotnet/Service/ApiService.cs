using Newtonsoft.Json;
using Stockage_Api_WPF_Dotnet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;

namespace Stockage_Api_WPF_Dotnet.Service
{
    public class ApiService
    {
        string Url = "https://localhost:44398/";

        public async Task<bool> AddProduct(ProductModel model)
        {
            //instancie httpclient
            HttpClient httpClient = new HttpClient();
            //serialize l'objet au format JSon
            var json = JsonConvert.SerializeObject(model);
            //instancie l'httpcontent et inclue l'objet Json a l'interieru
            HttpContent content = new StringContent(json);

            //inclue l'objet json dans le l'entete de la page
            content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
            var response = await httpClient.PostAsync(Url + "api/ProductModels", content);
            return response.IsSuccessStatusCode;
        }
    }
}