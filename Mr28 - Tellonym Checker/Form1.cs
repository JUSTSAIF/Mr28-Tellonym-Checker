using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mr28___Tellonym_Checker
{
    public partial class Form1 : Form
    {
        int mov;
        int movX;
        int movY;
        string FilePath;
        string user = "";
        string pass = "";
        int UserId;
        string usraccc;
        string passaccc;
        bool userfound = false;
        int inv_user;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Visible = false;
            listBox2.Visible = false;
            var ApplicationDataDirectory = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            if (!File.Exists(ApplicationDataDirectory + "/Mr28-Tell-Chker"))
            {
                System.IO.Directory.CreateDirectory(ApplicationDataDirectory + "/Mr28-Tell-Chker");
            }
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void Form1_Move(object sender, EventArgs e)
        {

        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        private void Form1_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }
        

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("INSTAGRAM : @qq_iq");
            Process.Start("https://instagram.com/qq_iq");
        }
        public void pictureBox3_Click(object sender, EventArgs e)
        {
            // Show the dialog and get result.
            OpenFileDialog LoadUSRFile = new OpenFileDialog();
            if (LoadUSRFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                pictureBox5.Visible = true;
                pictureBox6.Visible = true;
                pictureBox8.Visible = true;
                listBox2.Visible = true;
                listBox1.Visible = true;
                label1.Visible = true;
                checkBox1.Visible = true;
                checkBox2.Visible = true;
                checkBox3.Visible = true;
                Enable_AccOP.Visible = true;

                listBox1.Items.Remove(0);
                string FilePath = LoadUSRFile.FileName;
                listBox1.DataSource = File.ReadAllLines(FilePath);
            }
            if (listBox1.Items.Count > 1)
            {
                pictureBox4.Cursor = Cursors.Hand;
            }
        }


        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
        //async Task
        public void pictureBox4_Click(object sender, EventArgs e)
        {            
            // Array of user-agents to change from it random ;
            string[] userAgents = { "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/85.0.4183.121 Safari/537.36", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/85.0.4183.102 Safari/537.36", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/85.0.4183.121 Safari/537.36 Edg/85.0.564.63", "Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:81.0) Gecko/20100101 Firefox/81.0", "Mozilla/4.0 (compatible; MSIE 7.0; AOL 9.7; AOLBuild 4343.19; Windows NT 5.1; Trident/4.0; .NET CLR 2.0.50727; .NET CLR 3.0.04506.30; .NET CLR 3.0.04506.648; .NET CLR 3.0.4506.2152; .NET CLR 3.5.30729; .NET4.0C; .NET4.0E)", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/85.0.4183.121 Safari/537.36", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/84.0.4147.125 Safari/537.36 Aoyou/DTVfYj4gU31MWQ17IFJuZQ9Bk-ZaoMSslw2goppX1pMGOM35wrZIzIk0vg==", "Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 10.0; WOW64; Trident/7.0; .NET4.0C; .NET4.0E; .NET CLR 2.0.50727; .NET CLR 3.0.30729; .NET CLR 3.5.30729; InfoPath.3; wbxvdi 1.0.0; Zoom 3.6.0; Microsoft Outlook 15.0.5085; ms-office; MSOffice 15)", "Mozilla/5.0 (Linux; Android 11; LM-Q710(FGN)) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/85.0.4183.127 Mobile Safari/537.36", "Mozilla/5.0 (Android 11; Mobile; LG-M255; rv:81.0) Gecko/81.0 Firefox/81.0", "Mozilla/5.0 (Linux; U; Android 2.2) AppleWebKit/533.1 (KHTML, like Gecko) Version/4.0 Mobile Safari/533.1", "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_11_6) AppleWebKit/605.1.15 (KHTML, like Gecko) Version/11.1.2 Safari/605.1.15", "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_10_1) AppleWebKit/600.2.5 (KHTML, like Gecko) Version/8.0.2 Safari/600.2.5", "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_10_5) AppleWebKit/601.2.7 (KHTML, like Gecko) Version/9.0.1 Safari/601.2.7", "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_11_6) AppleWebKit/602.3.12 (KHTML, like Gecko) Version/10.0.2 Safari/602.3.12", "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_11_6) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/70.0.3538.102 Safari/537.36", "Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/44.0.2403.157 Safari/537.36", "Mozilla/5.0 (X11; Ubuntu; Linux x86_64; rv:65.0) Gecko/20100101 Firefox/65.0", "Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) HeadlessChrome/78.0.3904.70 Safari/537.36", "Opera/9.80 (Windows NT 6.1; WOW64) Presto/2.12.388 Version/12.18", "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/47.0.2526.73 Safari/537.36 OPR/34.0.2036.25", "Mozilla/5.0 (Linux armv7l) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/53.0.2785.143 Safari/537.36 OPR/40.0.2207.0 OMI/4.9.0.237.Martell-2.258 Model/Hisense-MT5658-SDK4-9 (Hisense;HU43K303UW;V1000.01.00a.I1207) CE-HTML/1.0 HbbTV/1.2.1 MTK5658US Hisense-MT5658-US" };
            int iCount = 0;
            int iCount2 = 0;
            if (listBox1.Items.Count > 1)
            {
                listBox2.Items.Clear();
                pictureBox4.Enabled = false;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                InvalidUser.Visible = true;
                InvalidUsertxt.Visible = true;
                pictureBox4.Cursor = Cursors.Hand;
                int UserUnCheckedCount = listBox1.Items.Count;
                async void stratappwork()
                {
                    for (int i = 0; i < UserUnCheckedCount; i++)
                    {
                        string userC = listBox1.Items[i].ToString();
                        if (userC.Last().ToString() == "." | userC.First().ToString() == ".")
                        {
                            inv_user += 1;
                            InvalidUser.Invoke((MethodInvoker)(() => InvalidUser.Text = inv_user.ToString()));
                        }
                        else
                        {
                            System.Threading.Thread.Sleep(100);
                            if (i + 1 == UserUnCheckedCount)
                            {
                                MessageBox.Show("End ^_^ .");
                                //pictureBox4.Enabled = true;
                                //pictureBox4.Cursor = Cursors.Hand;
                                pictureBox4.Invoke((MethodInvoker)(() => pictureBox4.Enabled = true));
                                pictureBox4.Invoke((MethodInvoker)(() => pictureBox4.Cursor = Cursors.Hand));
                            }
                            try
                            {
                                Random random = new Random();
                                int start2 = random.Next(0, userAgents.Length);
                                WebClient wc = new WebClient();
                                wc.Headers.Set("user-agent", userAgents[start2]);
                                wc.DownloadString("https://tellonym.me/" + userC);
                                iCount = iCount + 1;
                                //label3.Text = iCount.ToString();
                                label3.Invoke((MethodInvoker)(() => label3.Text = iCount.ToString()));
                            }
                            catch (WebException a)
                            {
                                string UrlRes = a.Message;
                                string UrlResUpdated = string.Empty;
                                int val;
                                for (int w = 0; w < UrlRes.Length; w++)
                                {
                                    if (Char.IsDigit(UrlRes[w]))
                                        UrlResUpdated += UrlRes[w];
                                }
                                if (UrlResUpdated.Length > 0)
                                    val = int.Parse(UrlResUpdated);
                                ///////////////////////////////////////////////

                                if (UrlResUpdated == "404")
                                {
                                    iCount2 = iCount2 + 1;
                                    //label5.Text = iCount2.ToString();
                                    label5.Invoke((MethodInvoker)(() => label5.Text = iCount2.ToString()));

                                    //listBox2.Items.Add(userC);
                                    listBox2.Invoke((MethodInvoker)(() => listBox2.Items.Add(userC)));

                                    // Msg Alert When Catch New User :
                                    //1
                                    bool chkbox1 = false;
                                    var checkCheckBox1 = new Action(() => chkbox1 = checkBox1.Checked);
                                    if (checkBox1.InvokeRequired)
                                        checkBox1.Invoke(checkCheckBox1);
                                    else
                                        checkCheckBox1();
                                    //2
                                    bool chkbox2 = false;
                                    var checkCheckBox2 = new Action(() => chkbox2 = checkBox2.Checked);
                                    if (checkBox1.InvokeRequired)
                                        checkBox1.Invoke(checkCheckBox2);
                                    else
                                        checkCheckBox2();
                                    //3
                                    bool chkbox3 = false;
                                    var checkCheckBox3 = new Action(() => chkbox3 = checkBox3.Checked);
                                    if (checkBox1.InvokeRequired)
                                        checkBox1.Invoke(checkCheckBox3);
                                    else
                                        checkCheckBox3();
                                    //4
                                    bool chkbox4 = false;
                                    var checkCheckBox4 = new Action(() => chkbox4 = Enable_AccOP.Checked);
                                    if (Enable_AccOP.InvokeRequired)
                                        Enable_AccOP.Invoke(checkCheckBox4);
                                    else
                                        checkCheckBox4();


                                    if (chkbox4 == true)
                                    {
                                        try 
                                        {
                                            AccList1 acclst = new AccList1();
                                            acclst.AccList1_Load(null, null);
                                            string Before(string value, string t)
                                            {
                                                int posA = value.IndexOf(t);
                                                if (posA == -1)
                                                {
                                                    return "";
                                                }
                                                return value.Substring(0, posA);
                                            }
                                            string After(string value, string y)
                                            {
                                                int posA = value.LastIndexOf(y);
                                                if (posA == -1)
                                                {
                                                    return "";
                                                }
                                                int adjustedPosA = posA + y.Length;
                                                if (adjustedPosA >= value.Length)
                                                {
                                                    return "";
                                                }
                                                return value.Substring(adjustedPosA);
                                            }
                                            usraccc  = Before(acclst.GetUsrPass(), ":");
                                            passaccc = After(acclst.GetUsrPass(), ":");
                                            Api_Change_Username.changeUsername(usraccc, passaccc, userC);
                                            var rm_file = Environment.SpecialFolder.ApplicationData +"/Mr28-Tell-Chker/Accounts.json";
                                            if (File.Exists(rm_file))
                                            {
                                                File.Delete(rm_file);
                                            }
                                        
                                        }
                                        catch (Exception)
                                        {
                                            MessageBox.Show("Err on Change acc USR . ×_x");
                                        }
                                    }

                                    if (chkbox1 == true)
                                    {
                                        if (chkbox4 == true)
                                        {
                                            MessageBox.Show($"New Tellonym User : @{userC} | Pass : {passaccc}");
                                        }
                                        else
                                        {
                                            MessageBox.Show("New Tellonym User : @" + userC);
                                        }
                                    }
                                    if (chkbox2 == true)
                                    {
                                        if (chkbox4 == true)
                                        {
                                            Telegram tele = new Telegram();
                                            tele.Telegram_Load(null, null);
                                            tele.TelegramSendMessage($"New Tellonym User : @{userC} | Pass : {passaccc}");
                                        }
                                        else
                                        {
                                            Telegram tele = new Telegram();
                                            tele.Telegram_Load(null, null);
                                            tele.TelegramSendMessage("New Tellonym User : @" + userC);
                                        }
                                    }
                                    if (chkbox3 == true)
                                    {
                                        if (chkbox4 == true)
                                        {
                                            Discord dis = new Discord();
                                            dis.Discord_Load(null, null);
                                            string DisMSG = $"```New Tellonym User : @{userC} | Pass : {passaccc}```";
                                            dis.SendMessageDiscord(DisMSG);
                                        }
                                        else
                                        {
                                            Discord dis = new Discord();
                                            dis.Discord_Load(null, null);
                                            string DisMSG = "```New Tellonym User : @" + userC + "🥳```";
                                            dis.SendMessageDiscord(DisMSG);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                Thread StartAppJob = new Thread(stratappwork);
                StartAppJob.Start();
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            
            Telegram teleForm = new Telegram();
            teleForm.Show();

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Discord discordForm = new Discord();
            discordForm.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            info io = new info();
            io.Show();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            AccList1 AccList = new AccList1();
            AccList.Show();
        }

        private void Enable_AccOP_CheckedChanged(object sender, EventArgs e)
        {
            if (Enable_AccOP.Checked == true)
            {
                var ApplicationDataDirectory = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                if (!File.Exists(ApplicationDataDirectory + "/Mr28-Tell-Chker/Accounts.json"))
                {
                    MessageBox.Show("You can't Enable this option because you don't set any account in \"Account List\"");
                    Enable_AccOP.Checked = false;
                }
            }
        }

        private void Enable_AccOP_MouseHover(object sender, EventArgs e)
        {
            //if (Enable_AccOP.Enabled == false)
            //{
            //    AccLOP_Check.Visible = true;
            //}
        }

        private void Enable_AccOP_MouseLeave(object sender, EventArgs e)
        {
            //if (Enable_AccOP.Enabled == false)
            //{
            //    AccLOP_Check.Visible = false;
            //}
        }
    }
}
