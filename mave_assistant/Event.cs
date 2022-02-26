using System;
using System.Collections.Generic;
using System.Text;

namespace mave_assistant
{
    class Event
    {
        public string username;
        public string date;
        public string type;
        public string details;

        public Event()
        {
            username = SignUp.SetValueForUsername;
        }
    }
}
