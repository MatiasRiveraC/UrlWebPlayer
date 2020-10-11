using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [Serializable]
    public class Library
    {
        public List<Channel> Channels;

        public Library(List<Channel> channels)
        {
            this.Channels = channels;
        }

        public Library()
        {
            this.Channels = new List<Channel>();
        }



   
        public void AddChannel(string Name, Uri Url)
        {
            Channels.Add(new Channel(Name, Url));
        }

        public void RemoveChannel(Channel channel)
        {
            Channels.Remove(channel);
        }
        
       


    }
}
