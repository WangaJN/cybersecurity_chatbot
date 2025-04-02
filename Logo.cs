using System;
using System.Drawing;
using System.IO;

namespace cybersecurity_chatbot
{
    class Logo // Capitalized class name
    {
        private string fullPath;

        public Logo()
        {
            string path = AppDomain.CurrentDomain.BaseDirectory;
            string newPath = path.Replace("\\bin\\Debug", "");
            fullPath = Path.Combine(newPath, "cybersecurity.jpeg");
        }

        public string FullPath
        {
            get => fullPath;
            set => fullPath = value;
        }

        public void DisplayAsciiArt()
        {
            Bitmap image = new Bitmap(fullPath); // Initialize Bitmap with file path
            image = new Bitmap(image, new Size(210, 200)); // Correctly use Size constructor

            for (int height = 0; height < image.Height; height++)
            {
                for (int width = 0; width < image.Width; width++) // Correct loop variable
                {
                    // ASCII design
                    Color pixelColor = image.GetPixel(width, height);
                    int color = (pixelColor.R + pixelColor.G + pixelColor.B) / 3;

                    char asciiDesign = color > 200 ? '.' : color > 150 ? '*' : color > 100 ? 'O' : color > 50 ? '#' : '@';
                    Console.Write(asciiDesign); // Use Console.Write to avoid new lines
                }
                Console.WriteLine(); // Skip the line
            }
        }
    }
}

