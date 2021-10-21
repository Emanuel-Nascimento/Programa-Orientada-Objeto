using System;
using System.Collections.Generic;

namespace ProgramPOO
{
    public class Teacher : People
    {
        public Teacher(decimal wage, string name, string document, DateTime birthdate )
            :base(name, document, birthdate)
        {
            Wage = wage;
            Turma = new List<string> { "A", "B" };
        }
        public List<string> Turma { get; private set; }
        public decimal Wage { get; private set; }

        public override void Introduceyourself()
        {
            base.Introduceyourself();
            var turmas = string.Join(',', Turma);

            Console.WriteLine($"Meu salario é {Wage}, e ensino para as turmas {turmas}");


            Console.WriteLine();
        }
    }
}
