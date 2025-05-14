using System;

namespace cybersecurity_chatbot
{

	public class UserInteraction
	{
		// private string user_name = string.Empty;
		public delegate string user_info();
		public delegate void userInterface(string user_name);
		static public string user_asking = string.Empty;

		List<string> worriedKeywords = new List<string> { "worried", "nervous", "scared", "afraid", "concerned" };
		List<string> curiousKeywords = new List<string> { "curious", "interested", "wonder", "learn" };
		List<string> frustratedKeywords = new List<string> { "frustrated", "angry", "upset", "annoyed" };



		//constructor
		public UserInteraction()
		{
			//welcome user  and prompt for name 
			Console.ForegroundColor = ConsoleColor.Blue;
			Console.WriteLine("\t----------------------------------------------");
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("\t Welcome to your cyber security chatbot \t");
			Console.ForegroundColor = ConsoleColor.Blue;
			Console.WriteLine("\t----------------------------------------------");
			Console.ForegroundColor = ConsoleColor.White;


			//making use of the delegate method (user_info())
			user_info user_info = () =>
			{

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
				string user_name = Console.ReadLine();

				//returning the name of the user
				return user_name;

			};//eod(user_info)

			string name = user_info();


			//recreate interface 
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.Write("Chatbot->");
			userInterface userInterface = (string user_name) =>
			{

				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine($"Good Day {user_name} ,how can i assist you today?");
				do
				{

					Console.ForegroundColor = ConsoleColor.Yellow;
					Console.Write($"{user_name} ->");
					Console.ForegroundColor = ConsoleColor.White;
					user_asking = Console.ReadLine();

					string sentiment = DetectSentiment(user_asking);
					if (sentiment != "neutral")
					{
						Console.ForegroundColor = ConsoleColor.Cyan;
						Console.WriteLine("Chatbot-> " + GetSentimentResponse(sentiment));
						Console.ForegroundColor = ConsoleColor.White;
					}


					answer(user_asking);
				} while (user_asking != "exit");

			};


			userInterface(name);

		}
		//answering method

		string GetSentimentResponse(string sentiment)
		{
			switch (sentiment)
			{
				case "worried":
					return "It's completely understandable to feel that way. Cyber threats can be scary, but you're not alone.";
				case "curious":
					return "Curiosity is great! Let's explore more about staying safe online.";
				case "frustrated":
					return "I’m sorry you're feeling frustrated. Let’s take it step by step — I’m here to help.";
				default:
					return "Thanks for sharing. Let's talk more about cybersecurity.";
			}
		}
		string DetectSentiment(string input)
		{
			input = input.ToLower();

			if (worriedKeywords.Any(word => input.Contains(word)))
				return "worried";
			if (curiousKeywords.Any(word => input.Contains(word)))
				return "curious";
			if (frustratedKeywords.Any(word => input.Contains(word)))
				return "frustrated";

			return "neutral";
		}
		public void answer(string asked)
		{
			//do checking condition
			if (asked != "exit")
			{

				// //use filter project to check question and answers
				new FilterAll();



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
