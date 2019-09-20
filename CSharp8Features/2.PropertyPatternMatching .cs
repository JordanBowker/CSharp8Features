using System;

namespace CSharp8Features
{
	public class Animal
	{
		public string Colour { get; set; }
		public string Type { get; set; }
	}

	public class PropertyPatternMatching
	{
		// Switch statements can now be used to match against an objects properties in a cleaner way

		public void OldWay(Animal animal)
		{
			string animalDescription;
			if (animal.Colour == "Brown" && animal.Type == "Cat")
				animalDescription = "Brown Cat";

			else if (animal.Colour == "White" && animal.Type == "Cat")
				animalDescription = "White Cat";

			else if (animal.Colour == "Black" && animal.Type == "Cat")
				animalDescription = "Black Cat";

			else if (animal.Colour == "White" && animal.Type == "Dog")
				animalDescription = "White Dog";

			else if (animal.Colour == "Pink" && animal.Type == "Flamingo")
				animalDescription = "Pink Flamingo";

			else throw new Exception("I dont know what animal it is");

			Console.WriteLine($"The animal is a {animalDescription}");
		}

		public void OldWay2(Animal animal)
		{
			string animalDescription;
			switch (animal.Colour)
			{
				case "Brown" when animal.Type == "Cat":
					animalDescription = "Brown Cat";
					break;

				case "White" when animal.Type == "Cat":
					animalDescription = "White Cat";
					break;

				case "Black" when animal.Type == "Cat":
					animalDescription = "Black Cat";
					break;

				case "White" when animal.Type == "Dog":
					animalDescription = "White Dog";
					break;

				case "Pink" when animal.Type == "Flamingo":
					animalDescription = "Pink Flamingo";
					break;

				default:
					throw new Exception("I dont know what animal it is");
			}

			Console.WriteLine($"The animal is a {animalDescription}");
		}

		public void NewWay(Animal animal)
		{
			var animalDescription = animal switch
			{
				{ Colour: "Brown", Type: "Cat" } => "Brown Cat",
				{ Colour: "White", Type: "Cat" } => "White Cat",
				{ Colour: "Black", Type: "Cat" } => "Black Cat",
				{ Colour: "White", Type: "Dog" } => "White Dog",
				{ Colour: "Pink", Type: "Flamingo" } => "Pink Flamingo",
				_ => throw new Exception("I dont know what animal it is")
			};

			Console.WriteLine($"The animal is a {animalDescription}");
		}
	}
}
