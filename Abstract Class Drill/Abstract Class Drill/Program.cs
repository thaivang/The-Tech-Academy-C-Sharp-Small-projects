﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class_Drill
{
    class Program
    {
        static void Main(string[] args)
        {
            IQuittable employee = new Employees();

            employee.Quit();
            Employees name = new Employees() { FirstName = "Sample", LastName = "Student" }; //instantiate the object and initialize it
            name.SayName(); //call the sayName method
            Console.ReadLine();
        }
    }
}
