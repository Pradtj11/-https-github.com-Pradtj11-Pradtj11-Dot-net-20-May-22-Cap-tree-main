using System;

/// <summary>
/// Summary description for Class1
/// </summary>
public class Class1
{
	public Class1()
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Enter yor string: ");
			String a = Console.ReadLine();

			char[] temp = a.ToCharArray();
			Array.Reverse(temp);
			string b = new string(temp);

			if (a.Equals(b))
			{
				Console.WriteLine("The given string is palindrome");
			}
			else
			{
				Console.WriteLine("The given string is not a palindrome");
			}

		}
	}
}
