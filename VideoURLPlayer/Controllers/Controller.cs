using System;

using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Model
{
    public static class Controller
    {
        private static Form1 mainWindow = new Form1();
        private readonly static string DEFAULT_LIBRARY_PATH = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + @"\Files\library.bin";
        public static Library library = LoadChannels();  

        [STAThread]
        public static void Main()
        {
            mainWindow.ShowDialog();
        }



        public static void SaveChannels()
        {
            //Enter code & eat shit
            BinaryFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(DEFAULT_LIBRARY_PATH, FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, library);
            stream.Close();
        }

        public static Library LoadChannels()
        {
            try
            {
                BinaryFormatter formatter = new BinaryFormatter();
                Stream stream = new FileStream(DEFAULT_LIBRARY_PATH, FileMode.Open, FileAccess.Read, FileShare.None);
                Library libraryLoad = (Library)formatter.Deserialize(stream);
                stream.Close();
                mainWindow.label1.ForeColor = Color.White;
                mainWindow.label1.BackColor = Color.Green;
                mainWindow.label1.Text = "OK";
                return libraryLoad;
            }
            catch
            {
                mainWindow.label1.ForeColor = Color.White;
                mainWindow.label1.BackColor = Color.Red;
                mainWindow.label1.Text = "ERROR";
                return new Library();
            }
        }

        public static void AddChannel(string Name, Uri Url)
        {
            library.Channels.Add(new Channel(Name, Url));
        }

        public static void DeleteChannel(Channel Channel)
        {
            library.Channels.Remove(Channel);
        }

        public static void SelectChannel()
        {
            if(mainWindow.cbChannels.SelectedItem != null)
            {
                Channel channel = (Channel)mainWindow.cbChannels.SelectedItem;
                mainWindow.webBrowser.Navigate(channel.Url);
            }
        }

        public static void DeleteChannel()
        {
            if (mainWindow.cbChannels.SelectedItem != null)
            {
                if (MessageBox.Show("Are you sure you want to delete this channel?", "Delete channel", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    Channel channel = (Channel)mainWindow.cbChannels.SelectedItem;
                    library.RemoveChannel(channel);
                }
            }
        }


        public static void UpdateChannels()
        {
            mainWindow.cbChannels.Items.Clear();
            foreach (Channel channel in library.Channels)
            {
                mainWindow.cbChannels.Items.Add(channel);
            }
 
        }

        
    }
}
