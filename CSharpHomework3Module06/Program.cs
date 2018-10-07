using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CSharpHomework3Module06
{
    class Program
    {
        static void Main(string[] args)
        {
            string menu = "";
            Console.WriteLine("Press 1 to task1");
            Console.WriteLine("Press 2 to task2");

            menu = Console.ReadLine();
            if (menu == "1")
            {
                ConsoleLibrary.Person p1 = new ConsoleLibrary.Person();
                Console.WriteLine("Enter Person Name");
                p1.SetName(Console.ReadLine());
                Console.WriteLine("Enter Person SerName");
                p1.SetSerName(Console.ReadLine());

                Console.WriteLine(ConsoleLibrary.Person.Person_(p1));
            }

            else if (menu == "2")
            {
                ConsoleLibrary.StringNumbers sn1 = new ConsoleLibrary.StringNumbers();
                Console.WriteLine(sn1.GetSTRING() + " " + sn1.GetINT());
                
            }
            Console.ReadLine();
        }
    }
}
