using System;
using System.Collections;
using System.Linq;
namespace cybersecurity_chatbot
{


    class FilterAll
    {
        // Declare variables
        List<string> replies = new List<string>();
        ArrayList ignore = new ArrayList();

        // Constructor 
        public FilterAll()
        {
            // Call both methods to store values
            store_ignore();
            store_replies();

            // Split user input into words
            string[] store_word = UserInteraction.user_asking.Split(" ");
            ArrayList store_final_words = new ArrayList();

            // Filter ignored words
            foreach (var word in store_word)
            {
                if (!ignore.Contains(word.ToLower()))
                {
                    store_final_words.Add(word.ToLower());
                }
            }

            // Match replies
            List<string> matchedReplies = new List<string>();
            foreach (string word in store_final_words)
            {
                foreach (string reply in replies)
                {
                    if (reply.ToString().ToLower().Contains(word) && !matchedReplies.Contains(reply.ToString()))
                    {
                        matchedReplies.Add(reply.ToString());
                    }
                }
            }

            // Show results
            if (matchedReplies.Count > 0)
            {

                List<string> followUpPrompts = new List<string>
            {
               "Would you like another tip?",
               "Let me know if you want to learn more!",
               "Is there a topic you're curious about?",
               "I can share another safety trick if you’d like.",
               "Ready for the next one?"
            };
                Random random = new Random();
                int index = random.Next(matchedReplies.Count);
                int chosenIndex = random.Next(followUpPrompts.Count);


                Console.WriteLine(matchedReplies[index] + followUpPrompts[chosenIndex] + "If that is all enter 'exit'.");
            }
            else
            {
                List<string> unknownInputResponses = new List<string> {
                    "Hmm, I didn’t understand that. Could you try asking in another way?",
                    "Oops! That’s outside my current knowledge. Try asking about cybersecurity topics.",
                    "I'm not sure I follow — but I'm happy to help with cybersecurity advice!",
                    "That doesn’t compute! Maybe rephrase your question?",
                    "Sorry, I’m still learning! Let’s try something else."
                };

                Random random = new Random();
                int pickedIndex = random.Next(unknownInputResponses.Count);
                Console.WriteLine(unknownInputResponses[pickedIndex]);
            }
        }

        // Method to store replies
        private void store_replies()
        {
            replies.Add("A strong password should be at least 12 characters long.");
            replies.Add("SQL injection is a code injection technique that exploits vulnerabilities.");
            replies.Add("Phishing is one of the most common cybersecurity threats.");
            replies.Add("Always check the sender's email address before clicking on links.");
            replies.Add("Never give out your personal information via email.");
            replies.Add("Phishing emails often create a sense of urgency — pause and verify!");
            replies.Add("Hover over links to see where they lead before clicking.");
            replies.Add("If it sounds too good to be true, it probably is.");
            replies.Add("Use a unique password for every account you own.");
            replies.Add("Use a password manager to generate and store complex passwords.");
            replies.Add("Avoid reusing passwords across different platforms.");
            replies.Add("Change your passwords regularly to reduce risk");
            replies.Add("Adjust privacy settings on social media to control who sees your posts.");
            replies.Add("Avoid sharing sensitive information on public forums.");
            replies.Add("Think twice before granting apps access to your camera, location, or contacts.");
            replies.Add("Use encrypted messaging apps when discussing private matters.");
            replies.Add("Log out of websites and apps when you're done, especially on public devices.");
            replies.Add("Always use HTTPS websites for secure connections.");
            replies.Add("Avoid downloading files from untrusted sources");
            replies.Add("Keep your browser and extensions up to date.");
            replies.Add("Don't click on suspicious pop-ups or ads.");
            replies.Add("Use incognito mode when browsing on shared devices.");
        }

        // Method to store ignore words
        private void store_ignore()
        {
            ignore.Add("me");
            ignore.Add("tell");
            ignore.Add("about");
            ignore.Add("is");
            ignore.Add("the");
        }
    }
}


