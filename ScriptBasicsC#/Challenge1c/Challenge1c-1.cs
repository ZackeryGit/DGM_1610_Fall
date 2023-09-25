using System;
					
public class Program
{
	public void Main()
	{
		Random random = new Random(); // Creates random object
		bool guessed = false;
		int guess; // user's guess
		int randomNum = random.Next(1, 11); // Makes a random number from 1 - 10
		Console.WriteLine("I have generated a random number, try to guess it, its between 1 - 10");
		Console.WriteLine("Awnser is:" + randomNum);
		
		/* Note: For some reason .Net fiddle will repeat the entire code rather than what is in the brackets,
		   I used anther compiler and it worked just fine
		*/
		
		while (guessed == false){ // while the awnser isn't guessed
			guess = Convert.ToInt16(Console.ReadLine());
			if (guess == randomNum) { // got the right awnser
				Console.WriteLine("Correct! The number was indeed: " + randomNum);
				guessed = true;
			} else if (guess > randomNum) {
				Console.WriteLine("Your guess was to high, try again");	// to high
			} else {
				Console.WriteLine("Your guess was to low, try again");	// to low
			}
		}
	}
}