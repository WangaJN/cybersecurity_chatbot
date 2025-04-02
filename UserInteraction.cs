using System;
//design prompt class
namespace cybersecurity_chatbot
{

public class UserInteraction
{
	private string user_name = string.Empty;
	 static public string user_asking = string.Empty;
	//constructor
	public UserInteraction()
	{
		//welcome user  and prompt for name 
		Console.ForegroundColor = ConsoleColor.Blue;
		Console.WriteLine("\t_----------------------------------------------_");
		Console.ForegroundColor = ConsoleColor.Yellow;
		Console.WriteLine("\t |Welcome to your cyber security chatbot| \t");
		Console.ForegroundColor = ConsoleColor.Blue;
		Console.WriteLine("\t_----------------------------------------------_");
		Console.ForegroundColor = ConsoleColor.White;


		//ask for name 
		Console.ForegroundColor = ConsoleColor.Blue;
		Console.WriteLine("\t----------------------------------------------");
		Console.ForegroundColor = ConsoleColor.Yellow;
		Console.Write("Chatbot->");
		Console.ForegroundColor = ConsoleColor.Red;
		Console.WriteLine("\t Enter your name \t");
		Console.ForegroundColor = ConsoleColor.Blue;
		Console.WriteLine("\t----------------------------------------------");
		Console.ForegroundColor = ConsoleColor.White;
		user_name = Console.ReadLine();
		//recreate interface 
		Console.ForegroundColor = ConsoleColor.White;
		Console.Write("CHATBOT");

		Console.ForegroundColor = ConsoleColor.Gray;
		Console.WriteLine($"hi {user_name} ,how can i assist you today?");
		do
		{

			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.Write($"{user_name} ->");
			Console.ForegroundColor = ConsoleColor.White;
			user_asking = Console.ReadLine();

			answer(user_asking);
		} while (user_asking != "exit");




	}
	//answering method
	public void answer(string asked)
	{
		//do checking condition
		if (asked != "exit")
		{

			// //use filter project to check question and answers
			new FilterAll();
			// Console.Write("Chatbot :->");
			// //change color of response 
			// Console.ForegroundColor = ConsoleColor.Red;
			// Console.WriteLine("Example answer");
			// Console.ForegroundColor = ConsoleColor.White;//reset      


		}
		else
		{
			//then exit application
			Console.WriteLine("Thank you for using the Chatbot ,bye ");
			System.Environment.Exit(0);

		}
	}
}
}
