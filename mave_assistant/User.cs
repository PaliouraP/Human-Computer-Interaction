using System;
using System.Collections.Generic;
using System.Text;

namespace mave_assistant
{
    class User
    {
        public string username;
        public string password;
        public string name;
        public string dob; // date of birth
        public string picture;
        public string pet;

        //constructor
        public User()
        {
            username = SignUp.SetValueForUsername;
            password = SignUp.SetValueForPassword;
            name = SignUp.SetValueForName;
            dob = SignUp.SetValueForDob;
            picture = SignUp.SetValueForPicture;
            pet = SignUp.SetValueForPet();
        }
    }
}
