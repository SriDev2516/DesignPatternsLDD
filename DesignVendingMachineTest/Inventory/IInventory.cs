using DesignVendingMachineTest.States;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignVendingMachineTest
{
    public interface IInventory
    {
        int Size { get; set; }

        public void SetInitialInventory();
        public ItemShelf[] GetInventory();
        public Item GetItem();
        public void AddItem(Item item, int itemCode);
        public void RemoveItem(Item item, int itemCode);
        void UpdateInventory(VendingMachine machine, int codeNumber);
    }
}
