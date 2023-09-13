using System;
					
public class Program
{
	public void Main()
	{
		Console.WriteLine("What Grade did you get?");
		int grade = Convert.ToInt16(Console.ReadLine());
		if (grade > 100){
			Console.WriteLine("A+ Either your lying, or you got some extra credit!");
		} else if (grade >= 90 && grade <= 100){
			Console.WriteLine("A! you did great!");	
		} else if (grade >= 80 && grade <= 89){
			Console.WriteLine("B! So close! But you did good!");	
		} else if (grade >= 70 && grade <= 79){
			Console.WriteLine("C! You got an average grade! Nice!");	
		} else if (grade >= 60 && grade <= 69){
			Console.WriteLine("D! Well, You gave it your all! Try studying more!");	
		} else if (grade < 60){
			Console.WriteLine("F! You should've studied man");	
		}
		
		Console.WriteLine("What Subject is your favorite?");
		string subject = Console.ReadLine();
		subject = subject.ToLower();
		Console.WriteLine(subject);
		
		switch (subject) {
			case "math":
				Console.WriteLine("Math is great! You should try calculus!");
				break;
			case "science":
				Console.WriteLine("Science is fun! Chemistry my be your route!");
				break;
			case "history":
				Console.WriteLine("History is a great blast from the past! May I recommend some geography to you?");
				break;
			case "english":
				Console.WriteLine("English helps get your word across! I recommend creative writing!");
				break;
		}
	}
}