using ASPCoreConsoleApp.Entities;
using System;

namespace ASPCoreConsoleApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            using (var db = new ActorDbContext())
            {
                db.Actors.AddRange(
                    new Actor {
                        Name = "Chris Evans",
                        Age = 35,
                        AcademyWinner = true,
                    },
                    new Actor
                    {
                        Name = "Heith Ledger",
                        Age = 65,
                        AcademyWinner = true,
                    }
                );
                var count = db.SaveChanges();
                System.Console.WriteLine($"{count} records added.");
                foreach (var Actor in db.Actors)
                {
                    Console.WriteLine($"Name: {Actor.Name}, \t\t"
                        + $"Age: { Actor.Age},\t\t" + $"Academy Winner: {Actor.AcademyWinner}");
                }
                Console.ReadLine();   
            }
        }
    }
}
