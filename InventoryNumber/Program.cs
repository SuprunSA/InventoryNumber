using System;

namespace InventoryNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            MockLists mockLists = new MockLists();
            foreach(var building in mockLists.Buildings)
            {
                Console.WriteLine(building.Number);
            }

            Console.WriteLine();

            foreach (var computer in mockLists.Computers)
            {
                Console.WriteLine(computer.Number);
            }

            Console.WriteLine();

            foreach (var book in mockLists.Books)
            {
                Console.WriteLine(book.Number);
            }
        }
    }
}
