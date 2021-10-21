using System;
using System.Collections.Generic;
using System.Linq;

namespace ProgramPOO
{
    public class Student : People
    {
        public Student(string turma, string name, string document, DateTime birthdate)
            : base(name, document, birthdate)
        {
            Turma = turma;
            Notas = new List<int> { 1, 2, 3, 4, 5, 6, 7 };
        }

        public string Turma { get; private set; }
        public List<int> Notas { get; private set; }

        public override void Introduceyourself()
        {
            base.Introduceyourself();
            var media = Notas.Average();

            Console.WriteLine($"Sou um aluno da Turma {Turma}, Media de Nota: {media}");
        }
    }
}
