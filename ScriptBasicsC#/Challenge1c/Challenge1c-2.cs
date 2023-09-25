using System;
					
public class Program
{
	static public void Main()
	{
		String[] favFoods = {"cold", "hot", "favorite"};
		Console.WriteLine("What is your favorite cold food?");
		favFoods[0] = Console.ReadLine();
		Console.WriteLine("What is your favorite hot food?");
		favFoods[1] = Console.ReadLine();
		Console.WriteLine("What is your favorite food overall?");
		favFoods[2] = Console.ReadLine();
		
		foreach (var food in favFoods){
			Console.WriteLine("I Like: " + food);
		}
	}
}