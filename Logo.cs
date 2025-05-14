
namespace cybersecurity_chatbot
{
using System;
using System.Drawing;
using System.IO;
    class Logo
    {
        private string fullPath;

        public Logo()
        {
            string path = AppDomain.CurrentDomain.BaseDirectory;
            string newPath = Path.GetFullPath(Path.Combine(path, @"..\..\..\")); // Move up three levels
            fullPath = Path.Combine(newPath, "cybersecurity.jpeg");

            // Check if file exists
            if (!File.Exists(fullPath))
            {
                Console.WriteLine("Error: Image file not found at " + fullPath);
            }
        }

        public void DisplayAsciiArt()
        {
            if (!File.Exists(fullPath))
            {
                Console.WriteLine("Error: Cannot display logo, file not found.");
                return;
            }

            try
            {
                using (Bitmap image = new Bitmap(fullPath)) // Open image safely
                {
                    Bitmap resizedImage = new Bitmap(image, new Size(70, 50)); // Adjust size for better ASCII output

                    for (int height = 0; height < resizedImage.Height; height++)
                    {
                        for (int width = 0; width < resizedImage.Width; width++)
                        {
                            Color pixelColor = resizedImage.GetPixel(width, height);
                            int color = (pixelColor.R + pixelColor.G + pixelColor.B) / 3;

                            char asciiDesign = color > 200 ? '.' : color > 150 ? '*' : color > 100 ? 'O' : color > 50 ? '#' : '@';
                            Console.Write(asciiDesign);
                        }
                        Console.WriteLine();
                    }
                }
            }
            catch (Exception error)
            {
                Console.WriteLine("Logo Error: " + error.Message);
            }
        }
    }
}
