using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deliverables
{
    class Robot
    {
        public string Name { get; set; }
        public string DisplayName()
        {
            return Name;
        }
        public void DisplayGreeting()
        {
            Console.WriteLine($"Beep, Beep");
        }
        public void StartUp()
        {
            Console.WriteLine($"Started...");
        }
        public void Shutdown()
        {
            Console.WriteLine($"Shutdown...");
        }
        public string IsTerminator()
        {
            if Robot is IsTerminator
            return true
        
        }
        public bool shutdown { get; set; }
        public bool IsASleep()
        {
            shutdown = true;
            return true;
        }
    }
}
