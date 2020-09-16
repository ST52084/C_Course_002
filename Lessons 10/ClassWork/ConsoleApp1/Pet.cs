namespace ConsoleApp1
{
	public class Pet
	{
		string kind;
		public string Kind
		{
			set
			{
				if (value != "")
				{
					kind = value;
				}

			}
			get
			{
				return kind;
			}
		}

		string name;
		public string Name
		{
			set
			{
				if (value != "")
				{
					name = value;
				}

			}
			get
			{
				return name;
			}
		}

		char sex;
		public char Sex
		{
			set
			{
				if (value == 'M' | value == 'F')
				{
					sex = value;
				}

			}
			get
			{
				return sex;
			}
		}

		int age;
		public int Age
		{
			set
			{
				if (value < 100)
				{
					age = value;
				}
			}
			get
			{
				return age;
			}
		}

		public string Description
		{
			get
			{
				return $"{name},{kind},{sex},{age}";
			}
		}

	}
}
