using System;
					
public class Program
{
	public void Main()
	{
		Console.WriteLine("How many lines in the number pyramid? (0 - 9)");
		int userNum = Convert.ToInt32(Console.ReadLine()); // Let the user enter a number
		if (userNum < 10 && userNum > -1){
			for(int i = 1; i <= userNum; i++){ // How Many Lines
				for(int j = 1; j <= i; j++){ // How Many to print in that line
				Console.Write(i);
				}
			Console.WriteLine("");
			}
		} else {
			Console.Write("You did not enter a number from 1 - 9"); // In case of user input error
		}
	}
}
