using System;
using System.Collections.Generic;
using System.Text;

namespace mave_assistant
{
    class User
    {
        public string username { get; set; }
        public string password { get; set; }
        public string name { get; set; }
        public string dob { get; set; } // date of birth
        public string picture { get; set; }

        //constructor
        public User()
        {
            username = SignUp.SetValueForUsername;
            password = SignUp.SetValueForPassword;
            name = SignUp.SetValueForName;
            dob = SignUp.SetValueForDob;
            picture = SignUp.SetValueForPicture;
        }
    }
}
