using System;
using System.Collections.Generic;
using System.Text;

namespace mave_assistant
{
    class Clothes
      
    {
        public string name;
        public bool availability;
        public string path;
        public Clothes(string n, bool av,string p)
        {
            name = n;
            availability = av;
            path = p;
        }

        public string getPath()
        {
            return path;
        }
    }

}
