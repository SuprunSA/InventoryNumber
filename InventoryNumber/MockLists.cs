using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryNumber
{
    class MockLists
    {
        public IEnumerable<Building> Buildings => new List<Building>()
        {
            new Building()
            { 
                Number = Helper.MakeCode(1, 1, 0)
            },

            new Building()
            {
                Number = Helper.MakeCode(1, 2, 1)
            },

            new Building()
            {
                Number = Helper.MakeCode(1, 3, 2)
            }
        };

        public IEnumerable<Computer> Computers => new List<Computer>()
        {
            new Computer()
            {
                Number = Helper.MakeCode(3, 1, 3)
            },

            new Computer()
            {
                Number = Helper.MakeCode(3, 2, 4)
            },

            new Computer()
            {
                Number = Helper.MakeCode(3, 3, 5)
            },

            new Computer()
            {
                Number = Helper.MakeCode(3, 4, 6)
            }
        };

        public IEnumerable<Book> Books => new List<Book>()
        {
            new Book()
            {
                Number = Helper.MakeCode(13, 1, 7)
            },

            new Book()
            {
                Number = Helper.MakeCode(13, 2, 8)
            },

            new Book()
            {
                Number = Helper.MakeCode(13, 3, 9)
            },

            new Book()
            {
                Number = Helper.MakeCode(13, 4, 10)
            }
        };
    }
}
