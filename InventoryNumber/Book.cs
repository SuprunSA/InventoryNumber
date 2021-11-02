using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryNumber
{
    class Book : IInventory
    {
        public string Name { get; set; }
        public string Authors { get; set; }
        public int Year { get; set; }
        public string Number { get; set; }

        public Book()
        {

        }
    }
}
