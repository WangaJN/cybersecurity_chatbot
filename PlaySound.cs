
namespace cybersecurity_chatbot
{
using System;
using System.IO;
    using System.Media;
    using System.Windows;
    class PlaySound
    {
        private string fullPath;

        public PlaySound()
        {
            string path = AppDomain.CurrentDomain.BaseDirectory;
            string newPath = Path.GetFullPath(Path.Combine(path, @"..\..\..\")); 
            fullPath = Path.Combine(newPath, "greeting.wav");

            // Check if the file exists
            if (!File.Exists(fullPath))
            {
                Console.WriteLine("Error: Sound file not found at " + fullPath);
            }
        }

        public void Play()
        {
            try
            {

                    if (File.Exists(fullPath)) // Ensure file exists before playing
                    {
                        SoundPlayer player = new SoundPlayer(fullPath);
                        player.PlaySync(); // Play synchronously
                    }
                    else
                    {
                        Console.WriteLine("Error: Cannot play sound, file not found.");
                    }
            }
            catch (Exception error)
            {
                Console.WriteLine("Sound Error: " + error.Message);
            }
        }
    }
}
