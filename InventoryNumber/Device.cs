using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryNumber
{
    class Device : IInventory
    {
        public string Number { get; set; }

        public Device() { }
    }
}
