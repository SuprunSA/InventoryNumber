using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryNumber
{
    class Building : IInventory
    {
        public string Adress { get; set; }
        public string Number { get; set; }

        public Building()
        {

        }
    }
}
