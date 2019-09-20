using System;

namespace NullableReferenceTypes
{
	public class NullableReferenceTypes
	{

		public void DoSomething()
		{
			var name = GetName();
			Console.WriteLine($"Name found with length {name.Length}");


			var user = GetUser("john");
			Console.WriteLine($"User found with name {user.Name}");
		}

		public string GetName()
		{
			return null;
		}

		public User GetUser(string name)
		{
			if (name == "cena") return null;
			return new User(name);
		}
	}

	public class User
	{
		public string Name { get; set; }

		public User(string name)
		{
			Name = name;
		}
	}

}
