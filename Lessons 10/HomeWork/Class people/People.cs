using System;

namespace Class_people
{
    public class People
    {
        string name;
        public string Name
        {
            set
            {
                name = value;
            }
        }

        public int age;
        public string Age
        {
            set
            {
                age = Convert.ToInt32(value);
            }
        }

        public int AgeAfter_4_Years
        {
            get
            {
                return age + 4;
            }
        }

        public string Description
        {
            get
            {                
                return "Name: " + name + ", age in 4 years: ";
            }
        }
    }
}
