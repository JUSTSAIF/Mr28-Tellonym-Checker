namespace Mr28___Tellonym_Checker
{
    partial class Telegram
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Telegram));
            this.tele_token = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.accid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.statusofTele = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tele_token
            // 
            this.tele_token.Location = new System.Drawing.Point(15, 40);
            this.tele_token.Multiline = true;
            this.tele_token.Name = "tele_token";
            this.tele_token.Size = new System.Drawing.Size(278, 31);
            this.tele_token.TabIndex = 0;
            this.tele_token.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Telegram Token : ";
            // 
            // accid
            // 
            this.accid.Location = new System.Drawing.Point(14, 104);
            this.accid.Multiline = true;
            this.accid.Name = "accid";
            this.accid.Size = new System.Drawing.Size(278, 31);
            this.accid.TabIndex = 0;
            this.accid.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Your Telegram Account ID : ";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(15, 141);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 44);
            this.button1.TabIndex = 2;
            this.button1.Text = "Done";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // statusofTele
            // 
            this.statusofTele.AutoSize = true;
            this.statusofTele.Location = new System.Drawing.Point(279, 185);
            this.statusofTele.Name = "statusofTele";
            this.statusofTele.Size = new System.Drawing.Size(0, 13);
            this.statusofTele.TabIndex = 3;
            // 
            // Telegram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 199);
            this.Controls.Add(this.statusofTele);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.accid);
            this.Controls.Add(this.tele_token);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Telegram";
            this.Text = "Send MSG : Settings";
            this.Load += new System.EventHandler(this.Telegram_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tele_token;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox accid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label statusofTele;
    }
}