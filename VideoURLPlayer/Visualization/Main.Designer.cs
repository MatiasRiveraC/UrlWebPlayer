namespace Model
{
    partial class Form1
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
            this.tbURL = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.cbChannels = new System.Windows.Forms.ComboBox();
            this.URLTB = new System.Windows.Forms.TextBox();
            this.NameTB = new System.Windows.Forms.TextBox();
            this.Addbtn = new System.Windows.Forms.Button();
            this.SaveBN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.DeleteBN = new System.Windows.Forms.Button();
            this.SelectBN = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbURL
            // 
            this.tbURL.Location = new System.Drawing.Point(73, 49);
            this.tbURL.Name = "tbURL";
            this.tbURL.Size = new System.Drawing.Size(389, 20);
            this.tbURL.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(489, 47);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // webBrowser
            // 
            this.webBrowser.Location = new System.Drawing.Point(13, 95);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(1396, 483);
            this.webBrowser.TabIndex = 3;
            this.webBrowser.Url = new System.Uri("", System.UriKind.Relative);
            // 
            // cbChannels
            // 
            this.cbChannels.FormattingEnabled = true;
            this.cbChannels.Location = new System.Drawing.Point(1209, 55);
            this.cbChannels.Name = "cbChannels";
            this.cbChannels.Size = new System.Drawing.Size(121, 21);
            this.cbChannels.TabIndex = 4;
            // 
            // URLTB
            // 
            this.URLTB.Location = new System.Drawing.Point(776, 47);
            this.URLTB.Name = "URLTB";
            this.URLTB.Size = new System.Drawing.Size(263, 20);
            this.URLTB.TabIndex = 5;
            // 
            // NameTB
            // 
            this.NameTB.Location = new System.Drawing.Point(776, 13);
            this.NameTB.Name = "NameTB";
            this.NameTB.Size = new System.Drawing.Size(263, 20);
            this.NameTB.TabIndex = 6;
            // 
            // Addbtn
            // 
            this.Addbtn.Location = new System.Drawing.Point(1063, 46);
            this.Addbtn.Name = "Addbtn";
            this.Addbtn.Size = new System.Drawing.Size(75, 23);
            this.Addbtn.TabIndex = 7;
            this.Addbtn.Text = "Add";
            this.Addbtn.UseVisualStyleBackColor = true;
            this.Addbtn.Click += new System.EventHandler(this.Addbtn_Click);
            // 
            // SaveBN
            // 
            this.SaveBN.Location = new System.Drawing.Point(1063, 13);
            this.SaveBN.Name = "SaveBN";
            this.SaveBN.Size = new System.Drawing.Size(75, 23);
            this.SaveBN.TabIndex = 8;
            this.SaveBN.Text = "Save";
            this.SaveBN.UseVisualStyleBackColor = true;
            this.SaveBN.Click += new System.EventHandler(this.SaveBN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1166, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "EAT SHIT AND DIE";
            // 
            // DeleteBN
            // 
            this.DeleteBN.Location = new System.Drawing.Point(1350, 25);
            this.DeleteBN.Name = "DeleteBN";
            this.DeleteBN.Size = new System.Drawing.Size(75, 23);
            this.DeleteBN.TabIndex = 10;
            this.DeleteBN.Text = "Delete";
            this.DeleteBN.UseVisualStyleBackColor = true;
            this.DeleteBN.Click += new System.EventHandler(this.DeleteBN_Click);
            // 
            // SelectBN
            // 
            this.SelectBN.Location = new System.Drawing.Point(1350, 55);
            this.SelectBN.Name = "SelectBN";
            this.SelectBN.Size = new System.Drawing.Size(75, 23);
            this.SelectBN.TabIndex = 11;
            this.SelectBN.Text = "Select";
            this.SelectBN.UseVisualStyleBackColor = true;
            this.SelectBN.Click += new System.EventHandler(this.SelectBN_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(738, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "URL:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(690, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Channel Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1206, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Channels:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(1437, 802);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SelectBN);
            this.Controls.Add(this.DeleteBN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SaveBN);
            this.Controls.Add(this.Addbtn);
            this.Controls.Add(this.NameTB);
            this.Controls.Add(this.URLTB);
            this.Controls.Add(this.cbChannels);
            this.Controls.Add(this.webBrowser);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.tbURL);
            this.Name = "Form1";
            this.Text = "URL Video Player";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbURL;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox URLTB;
        private System.Windows.Forms.TextBox NameTB;
        private System.Windows.Forms.Button Addbtn;
        public System.Windows.Forms.ComboBox cbChannels;
        private System.Windows.Forms.Button SaveBN;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button DeleteBN;
        private System.Windows.Forms.Button SelectBN;
        public System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

