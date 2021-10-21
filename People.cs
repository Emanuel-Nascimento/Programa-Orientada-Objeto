using System;

namespace ProgramPOO
{
    public abstract class People
    {
        public People(string name, string document, DateTime birthdate)
        {
            Name = name;
            Document = document;
            BirthDate = birthdate;

        }
        public string Name { get; protected set; }
        public string Document { get; protected set; }
        public DateTime BirthDate { get; protected set; }

        public virtual void Introduceyourself()
        {
            Console.WriteLine($"Olá, meu nome é {Name}, Document {Document}, BirthDate {BirthDate}");
        }

    }
}
