using System;
using System.Collections.Generic;
using System.Text;

namespace Demo
{
    class Employee
    {
        public string FName { set; get; } //= "" or null; the default value when call the user defined constructor 
        public string? LName { set; get; }
        public Departments Department { set; get; }

        public Employee()
        {
            FName = ""; // to avoid null value for NonNullable String in FName or initialize it in the same line in declaration
        }
    }

    class Departments
    {
        public int code { set; get; }
        public string Name { set; get; }
    }
}
