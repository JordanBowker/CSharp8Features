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

    }
}
