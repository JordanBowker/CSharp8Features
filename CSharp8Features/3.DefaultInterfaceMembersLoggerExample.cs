using System;
using System.Diagnostics;

namespace CSharp8Features
{
	// Define implementations onto an interface
	// Very disputable feature 

	public enum LogLevel
	{
		Information,
		Warning,
		Error
	}

	public interface ILogger
	{
		void Write(LogLevel level, string message);

		public void WriteInformation(string message)
		{
			Write(LogLevel.Information, message);
		}

		public void WriteWarning(string message)
		{
			Write(LogLevel.Warning, message);
		}

		public void WriteError(string message)
		{
			Write(LogLevel.Error, message);
		}
	}






	public class ConsoleLogger : ILogger
	{
		public void Write(LogLevel level, string message)
		{
			Console.WriteLine($"{level}: {message}");
		}
	}

	public class TraceLogger : ILogger
	{
		public void Write(LogLevel level, string message)
		{
			switch (level)
			{
				case LogLevel.Information:
					Trace.TraceInformation(message);
					break;

				case LogLevel.Warning:
					Trace.TraceWarning(message);
					break;

				case LogLevel.Error:
					Trace.TraceError(message);
					break;

				default:
					throw new ArgumentOutOfRangeException(nameof(level), level, null);
			}
		}
	}

}
