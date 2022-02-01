using System;

namespace DatingProfile
{

    class Profile
    {

        // fields

        private string name;
        private int age;
        private string city;
        private string country;
        private string pronouns;
        private string[] hobbies;

        // constructors

        public Profile(string name, int age, string city, string country, string pronouns = "they/them")
        {

            this.name = name;
            this.Age = age;
            this.city = city;
            this.country = country;
            this.pronouns = pronouns;
            this.hobbies = new string[] { };

        }

        // age validation property

        private int Age
        {
            get { return age; }
            set
            {
                if ((value >= 18) && (value <= 58))
                {
                    age = value;
                }
            }
        }


        // methods

        // view profile method
        public string ViewProfile()
        {

            string hobbiesArray = "";
            foreach (string element in this.hobbies)
            {
                hobbiesArray = hobbiesArray + "\n" + element;
            }
            string profileInfo = $"{name}\n{age}\n{city}\n{country}\n{pronouns}{hobbiesArray}";
            return profileInfo;
        }


        // set hobbies method 
        public void SetHobbies(string[] hobbies)
        {
            this.hobbies = hobbies;
        }

    }


}
