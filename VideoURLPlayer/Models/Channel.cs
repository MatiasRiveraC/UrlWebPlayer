using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [Serializable]
    public class Channel
    {
        public Uri Url;
        public string Name;

        public Channel(string name, Uri URL)
        {
            this.Name = name;
            this.Url = URL;
        }

        public override string ToString()
        {
            return Name;
        }

    }
}
