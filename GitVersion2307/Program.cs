using System;
using System.Reflection;

namespace GitVersion2307
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine($"Hello {typeof(Program).Assembly.GetCustomAttribute<AssemblyInformationalVersionAttribute>().InformationalVersion}"!);
		}
	}
}
