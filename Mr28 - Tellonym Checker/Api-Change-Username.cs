using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Mr28___Tellonym_Checker
{
    static class Api_Change_Username
    {
        class JsData
        {
            public string username { get; set; }
            public override string ToString()
            {
                return $"{username}";
            }
        }
        public static async Task changeUsername(string email, string password, string newUsr)
        {
            // Get Token 
            string AccountToken = await Api_Create_Token.GetTellToken(email, password);
            var client = new HttpClient();
            string url = "https://api.tellonym.me/accounts/settings";
            client.DefaultRequestHeaders.Add("user-agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/85.0.4183.121 Safari/537.36");
            client.DefaultRequestHeaders.Add("Authorization", "Bearer " + AccountToken);
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            var jsData = new JsData();
            jsData.username = newUsr;
            var json = JsonConvert.SerializeObject(jsData);
            var data = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await client.PostAsync(url, data);
            string result = await response.Content.ReadAsStringAsync();
            //MessageBox.Show(result);
        }
    }
}
