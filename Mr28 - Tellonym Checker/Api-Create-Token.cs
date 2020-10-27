using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Mr28___Tellonym_Checker
{
    public static class Api_Create_Token
    {
        class JsDataCreatToken
        {
            public string deviceName { get; set; }
            public string deviceType { get; set; }
            public string lang { get; set; }
            public string email { get; set; }
            public string password { get; set; }

            public override string ToString()
            {
                return $"{deviceName}:{deviceType}:{lang}:{email}:{password}";
            }
        }
        public static async Task<string> GetTellToken(string E, string P)
        {
            var client = new HttpClient();
            string urlCreateToken = "https://api.tellonym.me/tokens/create";
            client.DefaultRequestHeaders.Add("user-agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/85.0.4183.121 Safari/537.36");
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            var JsDataCT = new JsDataCreatToken();
            JsDataCT.deviceName = "Mozilla/5.0 (Linux; Android 10; SM-A505F) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/85.0.4183.12";
            JsDataCT.deviceType = "web";
            JsDataCT.lang = "en";
            JsDataCT.email = E;
            JsDataCT.password = P;
            var json = JsonConvert.SerializeObject(JsDataCT);
            var data = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await client.PostAsync(urlCreateToken, data);
            var result = response.Content.ReadAsStringAsync().Result;
            string accessToken = (string)JObject.Parse(result).SelectToken("accessToken");
            return accessToken;
        }
    }
}
