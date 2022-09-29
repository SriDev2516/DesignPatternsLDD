using DesignVendingMachineTest.States;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignVendingMachineTest
{
    public class ItemShelf
    {
        public int CodeNumber { get; set; }
        public Item Item { get; set; }
        public bool IsAvailable { get; set; }

    }
}
