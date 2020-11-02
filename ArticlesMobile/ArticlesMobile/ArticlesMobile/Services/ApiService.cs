using ArticlesMobile.Helpers;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ArticlesMobile.Services
{
    public class ApiService
    {
        HttpClient httpClient;

        public ApiService()
        {
            httpClient = new HttpClient();
        }


        public async Task<List<T>> Get<T>(string url, string objectname)
        {

            try
            {


                httpClient = new HttpClient();
                var response = await httpClient.GetAsync(url);
                var answer = await response.Content.ReadAsStringAsync();

                if (!response.IsSuccessStatusCode)
                {
                    return null;
                }


                JObject json = JObject.Parse(answer);
                string data = json.ToString();
                if (objectname.ToString().Trim().Length > 0) {data =  json[objectname].ToString(); }
                var list = JsonConvert.DeserializeObject<List<T>>(data.ToString());
                return list;

            }

            catch(Exception ex)
            {
                return null;
            }

        }

    }
}
