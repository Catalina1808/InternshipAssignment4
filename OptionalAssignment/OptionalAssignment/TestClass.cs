using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class TestClass
    {
        public static void Main()
        {
            //testing the App Tag Interpreter
            OptionalAssignment optionalAssignment = new OptionalAssignment();
            Console.WriteLine(optionalAssignment.AppTagInterpreter("<app></app></app><app><app>"));

           

        }
    }
}
