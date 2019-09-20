using System.Collections.Generic;

namespace CSharp8Features
{
	public class UsingDeclarations
	{
		// A small syntax change for when there is nothing after a using body 

		public void OldWay(List<string> lines)
		{
			using (var file = new System.IO.StreamWriter("WriteLines2.txt"))
			{
				foreach (string line in lines)
				{
					file.WriteLine(line);
				}
			}
		}

		public void NewWay(List<string> lines)
		{
			using var file = new System.IO.StreamWriter("WriteLines2.txt");

			foreach (string line in lines)
			{
				file.WriteLine(line);
			}
		}
	}
}
