using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
namespace Mr28___Tellonym_Checker
{
    public partial class Discord : Form
    {


        public Discord()
        {
            InitializeComponent();
        }

        public void Discord_Load(object sender, EventArgs e)
        {
            // Get Discord Token & set it in Textbox1
            var ApplicationDataDirectory = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            if (File.Exists(ApplicationDataDirectory + "/Mr28-Tell-Chker/Config-mr28.json"))
            {
                JObject o1 = JObject.Parse(File.ReadAllText(ApplicationDataDirectory + "/Mr28-Tell-Chker/Config-mr28.json"));
                using (StreamReader file = File.OpenText(@ApplicationDataDirectory + "/Mr28-Tell-Chker/Config-mr28.json"))
                using (JsonTextReader reader = new JsonTextReader(file))
                {
                    JObject o2 = (JObject)JToken.ReadFrom(reader);
                    if(o2["discordWebhookToken"] != null) { 
                    textBox1.Text = o2["discordWebhookToken"].ToString();
                    }
                }
            }

        }


        public void SendMessageDiscord(string msg) {
            string discordtoken = textBox1.Text;
            WebRequest wr = (HttpWebRequest)WebRequest.Create(discordtoken);

            wr.ContentType = "application/json";

            wr.Method = "POST";

            using (var sw = new StreamWriter(wr.GetRequestStream()))
            {
                string json = JsonConvert.SerializeObject(new
                {
                    username = "Mr28 剣 - Tellonym Checker",
                    avatar_url = "https://cdn.discordapp.com/attachments/753606265216696430/758854737754849353/14.png",
                    embeds = new[]
                    {
                        new {
                            description = msg,
                            title = "Mr28 - Tellonym Checker | New User",
                            color = "3746294",
                            footer = new {
                                icon_url = "https://images-ext-2.discordapp.net/external/LgEsY4kP1lm-AGI4on8ol-SF0536G1bPs7Gd0RrtMYU/https/images-ext-2.discordapp.net/external/Qo6ZJuC332ft2Qw6NG-pNOj0t_f2LJkiwxktq2g31pE/https/media.tenor.com/images/c194b475661046e135a237d33f9df658/tenor.gif",
                                text = "Programmed By @qq_iq"
                            },
                            image = new {
                                url = "https://media.giphy.com/media/JXibbAa7ysN9K/giphy.gif"
                            },
                            author = new
                            {
                                name = " ~剣",
                                url = "https://instagram.com/qq_iq",
                                icon_url = "https://images-ext-2.discordapp.net/external/keJ0crshq25S1TnX3HwQaeBu6rA_xb7QEoCkosVN9us/https/i.pinimg.com/originals/c9/c9/ff/c9c9ff2eed3dff5c3b9f7c0c033704da.gif"
                            },
                        }
                    }
                }); ; ;
                // More GIF pic
                //https://media.giphy.com/media/JXibbAa7ysN9K/giphy.gif
                //https://media.giphy.com/media/NPboRWBv3qzfi/giphy.gif
                //https://media1.tenor.com/images/668ceb4f6e9f39ed92fce087dc60ef0a/tenor.gif
                //https://media1.tenor.com/images/9bbc7339ddc6bd82a060d22231055dd3/tenor.gif
                sw.Write(json);
            }
            var response = (HttpWebResponse)wr.GetResponse();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            var ApplicationDataDirectory = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            try
            {
                
                string discordtoken = textBox1.Text;
                WebClient wc = new WebClient();
                string json = wc.DownloadString(discordtoken);
                dynamic dobj = JsonConvert.DeserializeObject<dynamic>(json);
                string temp = dobj["type"].ToString();
                // Save Discord Webhook 
                if (!File.Exists(ApplicationDataDirectory + "/Mr28-Tell-Chker/Config-mr28.json"))
                {

                    JObject mr28_Config = new JObject(
                    new JProperty("discordWebhookToken", discordtoken),
                    new JProperty("TeleToken", null),
                    new JProperty("TeleAccID", null));
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
                    jsonObj["discordWebhookToken"] = discordtoken;
                    string output = Newtonsoft.Json.JsonConvert.SerializeObject(jsonObj, Newtonsoft.Json.Formatting.Indented);
                    File.WriteAllText(ApplicationDataDirectory + "/Mr28-Tell-Chker/Config-mr28.json", output);
                }
                this.Close();
            }
            catch (Exception a)
            {
                MessageBox.Show("WEBHOOK has expired or may has broken ×_× !!");
            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
