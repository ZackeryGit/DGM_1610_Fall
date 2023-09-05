using System;
					
public class Program
{
	
	public Player player1;
	public SpeedPowerUp speedUp;
	public HealPowerUp healUp;
	
	public void Main()
	{
		player1 = new Player();
		speedUp = new SpeedPowerUp();
		healUp = new HealPowerUp();
		
		player1.health -= 30;
		Console.WriteLine("Player1 Health: " + player1.health);
		Console.WriteLine("Player1 Speed: " + player1.speed);
		
		Console.WriteLine("Player Obtained Speed Powerup!"); // Player gets powerup
		player1.speed = speedUp.speed;

		Console.WriteLine("Player1 Health: " + player1.health);
		Console.WriteLine("Player1 Speed: " + player1.speed);
		
		Console.WriteLine("Powerup wears off"); // Player looses poweup
		player1.speed = player1.normSpeed;
		
		Console.WriteLine("Player1 Health: " + player1.health);
		Console.WriteLine("Player1 Speed: " + player1.speed);
		
		Console.WriteLine("Player grabs a heal!"); // Player looses poweup
		player1.health += healUp.health;
		if (player1.health > player1.MaxHealth) { // checks is player exceeds their max health
			player1.health = player1.MaxHealth; // if they health exceeds the max, the health will be set to the player's max health
		}
		Console.WriteLine("Player1 Health: " + player1.health);
		Console.WriteLine("Player1 Speed: " + player1.speed);
	}
}

public class Player {
	public int MaxHealth = 100; // The Max Player Health
	public int normHealth = 100; // The Normal Player Health
	public int normSpeed = 16; // The Normal Player Speed
	public int health = 100; // The Current Player Health
	public int speed = 16; // The Current Player Speed
}

public class SpeedPowerUp {
	public int speed = 32;
}

public class HealPowerUp {
	public int health = 50;
}