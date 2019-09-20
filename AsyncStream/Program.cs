using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AsyncStream
{
	class Program
	{
		static async Task Main(string[] args)
		{
			var numbersOldWay = await GetNumbersOldWay();
			foreach (var dataPoint in numbersOldWay)
			{
				Console.WriteLine(dataPoint);
			}

			//            var numbersNewWay = GetNumbersNewWay();
			//            await foreach (var number in numbersNewWay)
			//            {
			//                Console.WriteLine($"Processing number {number}");
			//            }

			Console.ReadLine();
		}

		static async Task<IEnumerable<int>> GetNumbersOldWay()
		{
			var numbers = new List<int>();
			for (var i = 1; i <= 10; i++)
			{
				await Task.Delay(1000); //Simulate waiting for data to come through. 
				Console.WriteLine($"Number {i} retrieved");
				numbers.Add(i);
			}

			return numbers;
		}

		static async IAsyncEnumerable<int> GetNumbersNewWay()
		{
			for (var i = 1; i <= 10; i++)
			{
				await Task.Delay(1000); //Simulate waiting for data to come through. 
				Console.WriteLine($"Number {i} retrieved");
				yield return i;
			}
		}

	}
}
