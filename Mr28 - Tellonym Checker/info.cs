using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mr28___Tellonym_Checker
{
    public partial class info : Form
    {
        private void change_color()
        {
            while (true)
            {
                string[] color_hex = { "#3B1EEE", "#AD16F9", "#1665F9", "#F2F916", "#F91616", "#F9168E", "#16E1F9", "#008E11" };
                Random random = new Random();
                int s_c = random.Next(0, color_hex.Length);
                int s_c2 = random.Next(0, color_hex.Length);
                Color _color2 = System.Drawing.ColorTranslator.FromHtml(color_hex[s_c2]);
                Color _color = System.Drawing.ColorTranslator.FromHtml(color_hex[s_c]);
                label5.ForeColor = _color2;
                label6.ForeColor = _color;
                Thread.Sleep(500);
            }
        }

        public info()
        {
            InitializeComponent();
        }
        private void label5_Click(object sender, EventArgs e){}
        private void info_Load(object sender, EventArgs e){ new Thread(new ThreadStart(() => change_color())).Start(); }
        private void label1_Click(object sender, EventArgs e){}
        private void label6_Click(object sender, EventArgs e){}
        private void info_MouseHover(object sender, EventArgs e){}
        private void info_MouseLeave(object sender, EventArgs e){}
    }
}
