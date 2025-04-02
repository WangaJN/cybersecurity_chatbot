using System.Media.SoundPlayer;

namespace cybersecurity_chatbot
{
    class PlaySound
    {
        private string fullPath;

        public PlaySound()
        {
            string path = AppDomain.CurrentDomain.BaseDirectory;
            string newPath = path.Replace("\\bin\\Debug", "");
            fullPath = Path.Combine(newPath, "greeting.wav");
        }

        public string FullPath
        {
            get => fullPath;
            set => fullPath = value;
        }

        public void Play()
        {
            try
            {
                using (var player = new System.Media.SoundPlayer(fullPath))
                {
                    player.PlaySync();
                }
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }
        }
    }
}
