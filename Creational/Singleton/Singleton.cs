using System;

namespace Singleton
{
    public class Singleton
    {
        private static Singleton instance = null;
        private string _logger = "";

        private Singleton()
        {
            Console.WriteLine("Singleton create");
        }

        public static Singleton GetInstance()
        {
            if (instance == null)
            {
                instance = new Singleton();
            }

            return instance;
        }

        public void AddSingletonLog(string newString)
        {
            _logger += "|" + newString;
        }

        public string GetSingletonLog()
        {
            return _logger;
        }
    }
}