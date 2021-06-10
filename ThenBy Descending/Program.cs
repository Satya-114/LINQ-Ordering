using System;
using System.Collections.Generic;
using System.Linq;

namespace ThenBy_Descending
{
    class Program
    {
        static void Main(string[] args)
        {
            //Method Syntax
            var MS = Student.GetAllStudents()
                              .OrderBy(x => x.FirstName)
                              .ThenByDescending(y => y.LastName)
                              .ToList();

            foreach (var student in MS)
            {
                Console.WriteLine("First Name :" + student.FirstName + ", Last Name : " + student.LastName);
            }
            Console.ReadKey();
        }
    }
}
