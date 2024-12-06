namespace FinalProject;

public class Register {

	public Register() {
		
		Console.Clear();
		
		Console.WriteLine("Register System:");
		
		Console.WriteLine();
		Console.WriteLine("-----------------");
		Console.WriteLine();
		
		Console.WriteLine("Press enter to start an order.");

		ConsoleKey keyInfo = Console.ReadKey(true).Key;
		
		if(keyInfo == ConsoleKey.Spacebar) {

			Console.WriteLine("TEST");

		}
	}
	
}