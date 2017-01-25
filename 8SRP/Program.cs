using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8SRP
{
    class Program
    {
        static void Main(string[] args)
        {
            var ui = new UI();

            ui.AddProcess("Blubb");
        }
    }

    class UI
    {
        private readonly  Manager _manager;
        private readonly Logger _logger;

        public UI()
        {
            _manager = new Manager();
            _logger = new Logger();
        }

        public void AddProcess(string foo)
        {
            _logger.Log("Log...");
            _manager.Add(foo);
            RefreshUI("Hallo welt");
        }

        private void RefreshUI(string message)
        {
            Console.WriteLine(message);
        }
    }

    class Logger
    {
        public void Log(string message)
        {
            File.WriteAllText("log.txt", message);
        }
    }

    class Manager
    {
        public void Add(string foo)
        {
            // DB.Add(foo);
        }
    }
}
