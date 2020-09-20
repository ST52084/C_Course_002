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
                if (string.IsNullOrEmpty(value.ToString()) == true)
                {
                    throw new ArgumentException("Имя не должно быть пустым.");
                }

                for (int i = 0; i < value.Length; i++)
                {
                    array[i] = value[i];
                    if (!char.IsLetter(array[i]))
                    {
                        throw new ArgumentException("В имени должны быть только печатные символы.");
                    }
                    else
                    {
                        name = value;
                    }
                }
            }
        }

        public int age;
        private int _ageAfter_4_Years;

        public string Age
        {
            set
            {
                try
                {
                    age = Convert.ToInt32(value);
                }
                catch (FormatException)
                {

                    throw new InvalidOperationException("Возраст должен быть целым числом.");
                }

            }
        }

        public int AgeAfter_4_Years
        {
            get
            {
                _ageAfter_4_Years = age + 4;
                return _ageAfter_4_Years;
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
