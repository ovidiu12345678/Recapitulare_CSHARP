using Recapitulare_CSHARP;
using System;
namespace Recapitulare
{
    class Program
    {
        static void Main(string[] args)
        {
            var studeti = ObtineStudenti();

            var studentiAdulti = studeti.Where(s => s.Age > 22).ToList();
            studentiAdulti.ForEach(a => Console.WriteLine(a));

            var studentiAdultiTimis = studeti.Where(s => s.Address.Oras == "Timisoara" && s.Age > 18).ToList();

            studentiAdultiTimis.ForEach(s => Console.WriteLine(s));

            var celMaiTanarStudent = studeti.Where(s => s.Address.Oras == "Timisoara" && s.Age < 22).ToList();
            celMaiTanarStudent.ForEach(s => Console.WriteLine(s));

            var totiStudentiiDePeStradaLibertatii = studeti.Where(s => s.Address.Strada == "Libertatii").ToList();
            totiStudentiiDePeStradaLibertatii.ForEach(s => Console.WriteLine(s));


            var numeDeLaTastatura = Console.ReadLine();

            var studentulCautat = studeti.Where(s => s.LastName == numeDeLaTastatura);


            if (studentulCautat.Any())
            {
                Console.WriteLine("Am gasit studentul");
            }
            else
            {
                Console.WriteLine("Nu am gasit studentul");
            }


            var celMaiMicStudent = studeti.OrderBy(s => s.Age).ToList();
            celMaiMicStudent.ForEach(s => Console.WriteLine(s));


            var ordoneazaSudentiDupaStrada = studeti.Where(s => s.Address.Strada == "Libertatii" && s.Age > 21)
                .OrderBy(s => s.Age)
                .ToList();
            ordoneazaSudentiDupaStrada.ForEach(s => Console.WriteLine(s));

        }

        private static List<Student> ObtineStudenti() =>
            new List<Student>()
            {
                new Student()
                {
                    FirstName = "Ionel",
                    LastName = "Popescu",
                    Age = 22,
                    Address = new Address()
                    {
                        Oras = "Timisoara",
                        Judet = "Timis",
                        Strada = "Libertatii",
                        Numar = 11
                    }

                },

                new Student()
                {
                    FirstName = "Carp",
                    LastName = "Amalia",
                    Age = 21,
                    Address = new Address()
                    {
                        Oras = "Timisoara",
                        Judet = "Timis",
                        Strada = "Aleea Gornistilor",
                        Numar = 18
                    }
                },

                new Student()
                {
                    FirstName = "Bogdan",
                    LastName = "Petru",
                    Age = 25,
                    Address = new Address()
                    {
                        Oras = "Sibiu",
                        Judet = "Sibiu",
                        Strada = "Alexandru I.C",
                        Numar = 115
                    }
                },

                new Student()
                {
                    FirstName = "Gabriela",
                    LastName = "Rusu",
                    Age = 22,
                    Address = new Address()
                    {
                        Oras = "Iasi",
                        Judet = "Iasi",
                        Strada = "Cuza Voda",
                        Numar = 23
                    }
                },

                new Student()
                {
                    FirstName = "Ionel",
                    LastName = "Racas",
                    Age = 25,
                    Address = new Address()
                    {
                        Oras = "Timisoara",
                        Judet = "Timis",
                        Strada = "Libertatii",
                        Numar = 113
                    }
                }
            };
    }
}