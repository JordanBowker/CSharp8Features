using System;

namespace CSharp8Features
{
    public class IndicesAndRanges
    {
        // Syntax additions for finding elements within arrays, Span<T> and ReadOnlySpan<T>

        public string[] Words => new[]
        {
            "The",
            "quick",
            "brown",
            "fox",
            "jumped",
            "over",
            "the",
            "lazy",
            "dog"
        };
        
        public void OldWay()
        {
            //First word in the array
            var firstWord = Words[0];

            //Last word in the array
            var lastWord = Words[Words.Length - 1];

            //Subrange 

            // "The", "quick","brown"
            var subrange1 = new[] { Words[0], Words[1], Words[2] };

            // "quick","brown","fox","jumped"
            var subrange2 = new[] {Words[1], Words[2], Words[3], Words[4]};

            //"lazy","dog"
            var subrange3 = new[] { Words[Words.Length - 2], Words[Words.Length - 1]};
        }

        public void NewWay()
        {
            //First word in the array
            var firstWord = Words[^Words.Length];

            //Last word in the array
            var lastWord = Words[^1];

            //Subrange 

            // "The", "quick","brown" (last number isn't not in range)
            var subrange1 = Words[..3];

            // "quick","brown","fox","jumped" 
            var subrange2 = Words[1..6];

            //"lazy","dog"
            var subrange3 = Words[^2..];
        }
    }
}
