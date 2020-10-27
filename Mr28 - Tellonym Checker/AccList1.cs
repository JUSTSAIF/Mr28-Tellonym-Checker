using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mr28___Tellonym_Checker
{
    public partial class AccList1 : Form
    {
        string usedUSRorNot;
        public AccList1()
        {
            InitializeComponent();
        }
        public string GetUsrPass()
        {
            string usr  = Acc_Username.Text;
            string pass = Acc_Password.Text;
            return $"{usr}:{pass}";
        }
        public async void button2_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(Acc_Password.Text) & !String.IsNullOrEmpty(Acc_Username.Text))
            {
                var CkeckUSR = await Api_Create_Token.GetTellToken(Acc_Username.Text,Acc_Password.Text);
                if (!String.IsNullOrEmpty(CkeckUSR))
                {
                    // Save Account User  & Pass
                    var ApplicationDataDirectory = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                    if (!File.Exists(ApplicationDataDirectory + "/Mr28-Tell-Chker/Accounts.json"))
                    {
                        JObject AccTELL = new JObject(
                        new JProperty("AccUser", Acc_Username.Text),
                        new JProperty("AccPass", Acc_Password.Text),
                        new JProperty("Used", "No"));
                        File.WriteAllText(ApplicationDataDirectory + "/Mr28-Tell-Chker/Accounts.json", AccTELL.ToString());
                        // write JSON directly to a file
                        using (StreamWriter file = File.CreateText(ApplicationDataDirectory + "/Mr28-Tell-Chker/Accounts.json"))
                        using (JsonTextWriter writer = new JsonTextWriter(file))
                        {
                            AccTELL.WriteTo(writer);
                        }
                    }
                }
                MessageBox.Show("Done .");
            }
            else
            {
                MessageBox.Show("Please Type Pass & User Acc in Field .");
            }
            this.Close();
        }

        public void AccList1_Load(object sender, EventArgs e)
        {
            // Get Tele Token & ID & set it in Fields
            var ApplicationDataDirectory = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            if (File.Exists(ApplicationDataDirectory + "/Mr28-Tell-Chker/Accounts.json"))
            {
                if (!File.Exists(ApplicationDataDirectory + "/Mr28-Tell-Chker"))
                {
                    System.IO.Directory.CreateDirectory(ApplicationDataDirectory + "/Mr28-Tell-Chker");
                }
                using (StreamReader file = File.OpenText(ApplicationDataDirectory + "/Mr28-Tell-Chker/Accounts.json"))
                using (JsonTextReader reader = new JsonTextReader(file))
                {
                    JObject o1 = JObject.Parse(File.ReadAllText(ApplicationDataDirectory + "/Mr28-Tell-Chker/Accounts.json"));
                    JObject jsDa = (JObject)JToken.ReadFrom(reader);
                    if (!String.IsNullOrEmpty(jsDa["AccUser"].ToString()) & !String.IsNullOrEmpty(jsDa["AccPass"].ToString()))
                    {
                        Acc_Username.Text = jsDa["AccUser"].ToString();
                        Acc_Password.Text = jsDa["AccPass"].ToString();
                        usedUSRorNot      = jsDa["Used"].ToString();
                    }
                }
            }
        }

        private void Acc_Username_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

