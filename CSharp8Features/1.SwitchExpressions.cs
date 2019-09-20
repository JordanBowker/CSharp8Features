using System;

namespace CSharp8Features
{
	public class SwitchExpressions
	{
		// We can now write switch expressions in a more concise format

		public enum Animals
		{
			Cat,
			Dog,
			Sheep,
			Cow
		}

		public void OldWay(Animals animal)
		{
			string animalSound;
			switch (animal)
			{
				case Animals.Dog:
					animalSound = "Woof";
					break;

				case Animals.Cat:
					animalSound = "Meow";
					break;

				case Animals.Sheep:
					animalSound = "Baa";
					break;

				case Animals.Cow:
					animalSound = "Moo";
					break;

				default:
					throw new ArgumentOutOfRangeException();
			}

			Console.WriteLine($"The animal makes the sound: {animalSound}");
		}

		public void NewWay(Animals animal)
		{
			var animalSound = animal switch
			{
				Animals.Dog => "Woof",
				Animals.Cat => "Meow",
				Animals.Sheep => "Baa",
				Animals.Cow => "Moo",
				_ => throw new ArgumentOutOfRangeException()
			};

			Console.WriteLine($"The animal makes the sound: {animalSound}");
		}

		// Limitations
		// - The switch needs to return a value. 
		// - Multi-line statements are 'hacky'

		public void OldWayMultiline(Animals animal)
		{
			string animalSound;
			switch (animal)
			{
				case Animals.Dog:
					Console.WriteLine("The animal is Dog");
					animalSound = "Woof";
					break;

				case Animals.Cat:
					Console.WriteLine("The animal is Cat");
					animalSound = "Meow";
					break;

				case Animals.Sheep:
					Console.WriteLine("The animal is Sheep");
					animalSound = "Baa";
					break;

				case Animals.Cow:
					Console.WriteLine("The animal is Cow");
					animalSound = "Moo";
					break;

				default:
					throw new ArgumentOutOfRangeException();
			}

			Console.WriteLine($"The animal makes the sound: {animalSound}");
		}

		public void NewWay2(Animals animal)
		{
			var animalSound = animal switch
			{
				Animals.Dog => ((Func<string>)(() =>
				{
					Console.WriteLine("The animal is Dog");
					return "Woof";
				}))(),

				Animals.Cat => AnimalIsACat(),
				Animals.Sheep => AnimalIsASheep(),
				Animals.Cow => AnimalIsACow(),
				_ => throw new ArgumentOutOfRangeException()
			};

			Console.WriteLine($"The animal makes the sound: {animalSound}");
		}

		private string AnimalIsACat()
		{
			Console.WriteLine("The animal is Cat");
			return "Meow";
		}

		private string AnimalIsASheep()
		{
			Console.WriteLine("The animal is Sheep");
			return "Baa";
		}

		private string AnimalIsACow()
		{
			Console.WriteLine("The animal is Cow");
			return "Moo";
		}


	}
}
