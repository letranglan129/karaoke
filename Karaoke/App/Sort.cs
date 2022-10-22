using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karaoke.App
{
    class Sort
    {
        string type;
        string name;

        public Sort(string name, string type)
        {
            this.Name = name;
            this.Type = type;
        }

        public string Type
        {
            get { return type; }
            set
            {
                type = type == "ASC" ? "DESC" : "ASC";
            }
        }
        public string Name { 
            get {
                return name;
            } 
            set  {
                name = value;
            } 
        }
    }
}
