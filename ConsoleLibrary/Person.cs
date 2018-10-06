using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLibrary
{
    public class Person
    {
        private string name;
        private string sername;

        public void SetName(string name)
        {
            this.name = name;
        }

        public void SetSerName(string sername)
        {
            this.sername = sername;
        }

        public string GetName()
        {
            return name;
        }

        public string GetSerName()
        {
            return sername;
        }

        static public string Person_(Person p1)
        {
            string Person = "Person name is " + p1.GetName() + " person ser name is " + p1.GetSerName();
            return Person;
        }
    }
}
