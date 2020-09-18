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
                char[] array = new char[value.Length];
                for (int i = 0; i < value.Length; i++)
                {
                    array[i] = value[i];
                    if (!char.IsLetter(array[i]) | (string.IsNullOrEmpty(value.ToString()) == true))
                    {
                        throw new Exception("В имени должны быть только печатные символы.");
                    }
                    else
                    {
                        name = value;
                    }
                }
            }
        }

        private int _ageAfter_4_Years;

        public string Age
        {
            set
            {
                try
                {
                    _ageAfter_4_Years = Convert.ToInt32(value) + 4;
                }
                catch (FormatException)
                {

                    throw new Exception("Возраст должен быть целым числом.");
                }

            }
        }

        public int AgeAfter_4_Years
        {
            get
            {
                return _ageAfter_4_Years;
            }
        }

        public string Description
        {
            get
            {
                return "Name: " + name + ", age in 4 years: " + _ageAfter_4_Years;
            }
        }
    }
}
