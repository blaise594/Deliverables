using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deliverables
{
    class Human
    {
        public string Name { get; set; }
        public string DisplayName()
        {
            return Name;
        }
        public void DisplayGreeting()
        {
            Console.WriteLine($"Hello, nice to meet you.");
        }
        public string cheeseburger { get; set; }
        public void Eat(string food)
        {
            Console.WriteLine($"Yum, I ate {food}");
        }
    
    public void GoToSleep()
        {

        }
        public void WakeUp()
        {

        }
        public bool Asleep { get; set; }
        public bool IsASleep()
        {
            Asleep = true;
            return true;
        }
    }
}
