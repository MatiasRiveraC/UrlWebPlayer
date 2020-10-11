using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [Serializable]
    public class Library
    {
        public List<Channel> Channels;


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
