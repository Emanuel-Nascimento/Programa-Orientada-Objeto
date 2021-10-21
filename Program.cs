using System;
using System.Collections.Generic;

namespace ProgramPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            var teacher = new Teacher(5000, "Emanuel", "14789", new DateTime(1985, 03, 09));
            var studant = new Student("A", "Lucas", "123654", new DateTime(2007, 10, 04));

            var peaples = new List<People> { studant, teacher };

            foreach(var peaple in peaples)
            {
                peaple.Introduceyourself();
            }

            Console.Read();
        }
    }
}
