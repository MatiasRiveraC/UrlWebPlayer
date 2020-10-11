using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Model
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Controller.UpdateChannels();
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbURL.Text))
            {
                webBrowser.Navigate(new Uri(tbURL.Text));
            }
        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            try
            {

                Controller.AddChannel(NameTB.Text, new Uri(URLTB.Text));
                Controller.UpdateChannels();
            }
            catch
            {
                MessageBox.Show("URL inserted incorrectly.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SaveBN_Click(object sender, EventArgs e)
        {
            Controller.SaveChannels();
        }

        private void SelectBN_Click(object sender, EventArgs e)
        {
            Controller.SelectChannel();
        }

        private void DeleteBN_Click(object sender, EventArgs e)
        {
            Controller.DeleteChannel();
            Controller.UpdateChannels();

        }
    }
}
