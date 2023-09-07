using System;
					
public class Program
{
	public void Main()
	{
		int number = 5; // CHALLENGE 1
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
		
		Console.WriteLine("------------------"); // CHALLENGE 2
		int number2 = 10;
		int number3 = number2 + number;
		Console.WriteLine("Number 1: " + number + " Number 2: " + number2 + " Number 3: " + number3);
		
		float decNumber2 = 1.2f;
		float decNumber3 = decNumber + decNumber2;
		Console.WriteLine(decNumber3);
		
		string sentance = "Today's word is: still " + word;
		Console.WriteLine(sentance);
		
		Console.WriteLine("------------------"); // CHALLENGE 3
		
		Console.WriteLine("What is your name?");
		string name = Console.ReadLine();
		Console.WriteLine("What is your age?");
		int age = Convert.ToInt16(Console.ReadLine());
		int halfAge = age / 2;
		Console.WriteLine(name + " is " + age + " years old. Did you know half of " + age + " is: " + halfAge);
		
	}
}