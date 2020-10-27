using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Telegram.Bot;
using Telegram;
using Newtonsoft.Json.Linq;
using System.IO;

namespace Mr28___Tellonym_Checker
{
    public partial class Telegram : Form
    {
        public string TelegramSendMessage(string text)
        {
            string urlString = "https://api.telegram.org/bot"+tele_token.Text+"/sendMessage?chat_id="+accid.Text+"&text="+text;
            WebClient webclient = new WebClient();
            return webclient.DownloadString(urlString);
        }

        public Telegram()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void Telegram_Load(object sender, EventArgs e)
        {
            // Get Tele Token & ID & set it in Fields
            var ApplicationDataDirectory = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            if (File.Exists(ApplicationDataDirectory + "/Mr28-Tell-Chker/Config-mr28.json"))
            {
                if (!File.Exists(ApplicationDataDirectory + "/Mr28-Tell-Chker"))
                {
                    System.IO.Directory.CreateDirectory(ApplicationDataDirectory + "/Mr28-Tell-Chker");
                }
                JObject o1 = JObject.Parse(File.ReadAllText(ApplicationDataDirectory + "/Mr28-Tell-Chker/Config-mr28.json"));
                using (StreamReader file = File.OpenText(ApplicationDataDirectory + "/Mr28-Tell-Chker/Config-mr28.json"))
                using (JsonTextReader reader = new JsonTextReader(file))
                {
                    JObject o2 = (JObject)JToken.ReadFrom(reader);
                    if (o2["TeleAccID"] != null)
                    {
                        accid.Text = o2["TeleAccID"].ToString();
                        tele_token.Text = o2["TeleToken"].ToString();
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var ApplicationDataDirectory = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            
            try
            {
                WebClient wc = new WebClient();
                string json = wc.DownloadString("https://api.telegram.org/bot"+tele_token.Text+"/sendMessage?chat_id="+accid.Text+ "&text=Test From Mr28 - Tellonym Checker 🥳");
                dynamic dobj = JsonConvert.DeserializeObject<dynamic>(json);
                bool Ok = dobj["ok"];
                if(string.IsNullOrEmpty(accid.Text) | string.IsNullOrEmpty(tele_token.Text))
                {
                    MessageBox.Show("The Fields are Empty !");
                    this.Close();
                }
                if (Ok == true)
                {
                    // Save Tele ID,Token 
                    if (!File.Exists(ApplicationDataDirectory + "/Mr28-Tell-Chker/Config-mr28.json")) { 
                        JObject mr28_Config = new JObject(
                        new JProperty("TeleToken", tele_token.Text),
                        new JProperty("TeleAccID", accid.Text),
                        new JProperty("discordWebhookToken", null));
                        File.WriteAllText(ApplicationDataDirectory + "/Mr28-Tell-Chker/Config-mr28.json", mr28_Config.ToString());
                        // write JSON directly to a file
                        using (StreamWriter file = File.CreateText(ApplicationDataDirectory + "/Mr28-Tell-Chker/Config-mr28.json"))
                        using (JsonTextWriter writer = new JsonTextWriter(file))
                        {
                            mr28_Config.WriteTo(writer);
                        }
                    }
                    else
                    {
                        string json3 = File.ReadAllText(ApplicationDataDirectory + "/Mr28-Tell-Chker/Config-mr28.json");
                        dynamic jsonObj = Newtonsoft.Json.JsonConvert.DeserializeObject(json3);
                        jsonObj["TeleToken"] = tele_token.Text;
                        jsonObj["TeleAccID"] = accid.Text;
                        string output = Newtonsoft.Json.JsonConvert.SerializeObject(jsonObj, Newtonsoft.Json.Formatting.Indented);
                        File.WriteAllText(ApplicationDataDirectory + "/Mr28-Tell-Chker/Config-mr28.json", output);
                    }
                    statusofTele.Visible = true;
                    statusofTele.Text = "Working";
                    statusofTele.ForeColor = System.Drawing.Color.Green;
                    
                    this.Close();
                }

            }
            catch (WebException a)
            {
                string UrlRes = a.Message;
                string UrlResUpdated = string.Empty;
                int val;
                for (int i = 0; i < UrlRes.Length; i++)
                {
                    if (Char.IsDigit(UrlRes[i]))
                        UrlResUpdated += UrlRes[i];
                }
                
                if (UrlResUpdated.Length > 0)
                    val = int.Parse(UrlResUpdated);
                if(UrlResUpdated == "403")
                {
                    MessageBox.Show("Your Telegram User Blocked The Bot");
                    this.Close();
                }else if (UrlResUpdated == "401")
                {
                    MessageBox.Show("Telegram Token has expired or may has broken ×_× !!");
                    this.Close();
                }else if (UrlResUpdated == "400")
                {
                    MessageBox.Show("Telegram Account [ ID ] Not Found !!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Unknown Err ×_× !!");
                    this.Close();
                }
            }
        }
    }
}
