using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryNumber
{
    class Computer : Device
    {
        public string CPU { get; set; }
        public double MemorySize { get; set; }
        public double RAM { get; set; }

        public Computer() : base()
        {

        }
    }
}
