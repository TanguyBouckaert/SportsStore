using System;

namespace SportsStore
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new ApplicationDBContext();
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();
            Console.WriteLine("Database created...");
            Console.ReadLine();
        }
    }
}
