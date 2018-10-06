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
            ConsoleLibrary.Person p1 = new ConsoleLibrary.Person();
            Console.WriteLine("Enter Person Name");
            p1.SetName(Console.ReadLine());
            Console.WriteLine("Enter Person SerName");
            p1.SetSerName(Console.ReadLine());

            Console.WriteLine(ConsoleLibrary.Person.Person_(p1));
            Console.ReadLine();
        }
    }
}
