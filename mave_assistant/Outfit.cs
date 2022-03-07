using System;
using System.Collections.Generic;
using System.Text;

namespace mave_assistant
{
    public class Outfit
    {
        public bool available;
        public string pic;
        public string category;

        public Outfit(bool available, string pic, string category)
        {
            this.available = available;
            this.pic = pic;
            this.category = category;
        }
    }
}
