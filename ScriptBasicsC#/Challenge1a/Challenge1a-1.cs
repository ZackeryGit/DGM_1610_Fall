using System;
					
public class Program
{
	public void Main()
	{
		int number = 5;
		Console.WriteLine(number);
		string word = "potato";
		Console.WriteLine("Today's word is: " + word);
		float decNumber = 0.5f;
		Console.WriteLine("Decimal Number is: " + decNumber);
		
		bool onOrOff = true;
		if (onOrOff) {
			Console.WriteLine("The Light Swtich is on!");
		} else {
			Console.WriteLine("The Light Switch is off!");
		}
	}
}