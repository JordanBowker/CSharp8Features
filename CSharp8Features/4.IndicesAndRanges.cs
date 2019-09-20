namespace CSharp8Features
{
	public class IndicesAndRanges
	{
		// Syntax additions for finding elements within arrays, Span<T> and ReadOnlySpan<T>

		public string[] Words => new[]
		{
			"The",    // 0 from start or ^9 from end
			"quick",  // 1 from start or ^8 from end
			"brown",  // 2 from start or ^7 from end
			"fox",    // 3 from start or ^6 from end
			"jumped", // 4 from start or ^5 from end
			"over",   // 5 from start or ^4 from end
			"the",    // 6 from start or ^3 from end
			"lazy",   // 7 from start or ^2 from end
			"dog"     // 8 from start or ^1 from end
		};

		public void OldWay()
		{
			//First word in the array
			var firstWord = Words[0];

			//Last word in the array
			var lastWord1 = Words[Words.Length - 1];
			var lastWord2 = Words[8];

			//Subrange 

			// "The", "quick","brown"
			var subrange1 = new[] { Words[0], Words[1], Words[2] };

			// "quick","brown","fox","jumped"
			var subrange2 = new[] { Words[1], Words[2], Words[3], Words[4] };

			//"lazy","dog"
			var subrange3 = new[] { Words[Words.Length - 2], Words[Words.Length - 1] };
		}

		public void NewWay()
		{
			//First word in the array
			var firstWord1 = Words[^Words.Length];
			var firstWord2 = Words[^9];

			//Last word in the array
			var lastWord = Words[^1];

			//Subrange 

			// "The", "quick","brown" (last number isn't not in range)
			var subrange1 = Words[..3];

			// "quick","brown","fox","jumped" 
			var subrange2 = Words[1..5];

			//"lazy","dog"
			var subrange3 = Words[^2..];
		}
	}
}
