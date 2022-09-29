using DesignVendingMachineTest.States;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignVendingMachineTest.Inventory
{
    public class InventoryImpl : IInventory
    {
        ItemShelf[] inventory;
      
            

        public int Size { get; set; }

        public void AddItem(Item item, int itemCode)
        {
            throw new NotImplementedException();
        }

        public Item GetItem()
        {
            throw new NotImplementedException();
        }

        public ItemShelf[] GetInventory()
        {
            return inventory;
        }

        public void RemoveItem(Item item, int itemCode)
        {
            throw new NotImplementedException();
        }

        public void SetInitialInventory()
        {
            inventory = new ItemShelf[Size];

            SeedItemShelf();
            
            int code = 101;

            for (int i = 0; i < inventory.Length; i++)
            {
                Item item = new Item();
                if(i >= 0 && i < 3)
                {
                    item.Price = 10;
                    item.ItemName = ItemType.COKE;
                }
                else if (i >=3 && i < 7)
                {
                    item.Price = 20;
                    item.ItemName = ItemType.PEPSI;
                }
                else if (i >= 7 && i < 10)
                {
                    item.Price = 15;
                    item.ItemName = ItemType.SODA;
                }

                inventory[i].Item = item;
                inventory[i].CodeNumber = code;
                inventory[i].IsAvailable = true;
                code+=1;
            }
        }

        private void SeedItemShelf()
        {
            int StartCode = 101;
            for (int i=0; i < inventory.Length;i++)
            {
                ItemShelf itemShelf = new ItemShelf();
                itemShelf.CodeNumber = StartCode;
                itemShelf.IsAvailable = false;
                inventory[i] = itemShelf;
            }
        }

        public void UpdateInventory(VendingMachine machine, int codeNumber)
        {
            foreach (var item in inventory)
            {
                if(item.CodeNumber == codeNumber)
                {
                    item.IsAvailable = false;
                }
            }
        }
    }
}
