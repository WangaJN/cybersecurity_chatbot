using System;
using System.Collections;
using System.Linq;
namespace cybersecurity_chatbot
{

    class FilterAll
{
    //declare variables
    ArrayList replies = new ArrayList();
    ArrayList ignore = new ArrayList();

        //constructor 
        public FilterAll()
        {
            // call both methods to store values
            store_ignore();
            store_replies();


            //make use of split function to store each word 
            string[] store_word = userInteraction.user_asking.Split(" ");
            ArrayList store_final_words = new ArrayList();

            //loop to check the words and to store 
            for (int i = 0; i < store_word.Length; i++)
            {
                //check if this running 
                //Console.WriteLine(store_word[i]);

                //if to check if words stored in 1D array are not ignored
                if (!ignore.Contains(store_word[i]))
                {
                    //the store the not ignored words in store_final_word to perform functions on these 
                    store_final_words.Add(store_word[i]);
                }
            }

            //temp variables
            Boolean found = false;
            string message = string.Empty;
            //for loop to get answers
            foreach (var reply in replies)
            {


                //search answer for the answer by a word from the temp array list 
                foreach (string word in store_final_words)
                {
                    {
                        if (((string)reply).ToLower().Contains(word.ToLower()))
                        {
                            //append the answers
                            message += reply + "\n";
                            found = true;

                        }
                        if (found) break;
                    }
                }

                //display error messages or answers
                if (found)
                {
                    Console.WriteLine(message);

                }
                else
                {
                    Console.WriteLine("Search something related to cybersecurity ");
                }

            }
        }//end of constructor

    //method to store replies
    //store values of replies 
    private void store_replies()
    {
        replies.Add("A strong password should be at least 12 characters long.");
        replies.Add("SQL injection is a code injection technique that exploits vulnerabilities.");
        replies.Add("Phishing is one of the most common cybersecurity threats.");
    }

    //method to store ignore words
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
