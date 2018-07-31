using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningHowToMakeIntAndRestANullTypeV1._0._0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Podaj datę urodzenia: ");
            string birthday = Console.ReadLine();
            Console.Write("Podaj wzrost w centymetrach: ");
            string height = Console.ReadLine();
            RobustGuy guy = new RobustGuy(birthday, height);
            Console.WriteLine(guy.ToString());
            Console.ReadKey();
        }
    }
}
