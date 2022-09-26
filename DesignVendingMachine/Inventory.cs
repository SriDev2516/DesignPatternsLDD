using System;

namespace DesignVendingMachine
{
    public class Inventory
    {
        ItemShelf[] inventory = null;
        public Inventory(int itemCount)
        {
            inventory = new ItemShelf[itemCount];
            initialEmptyInventory();
        }

        public ItemShelf[] GetInventory()
        {
            return inventory;
        }

        public void SetInventory(ItemShelf[] inventory)
        {
            this.inventory = inventory;
        }

        private void initialEmptyInventory()
        {
            int startCode = 101;
            for (int i = 0; i < inventory.Length; i++)
            {
                ItemShelf itemShelf = new ItemShelf();
                itemShelf.Code = startCode;
                itemShelf.IsSoldOut = true;
                inventory[i] = itemShelf;
                startCode++;
            }
        }

        public void AddItem(Item newItem, int codeNumber)
        {
            foreach (var item in inventory)
            {
                if(item.Code == codeNumber)
                {
                    if (item.IsSoldOut)
                    {
                        item.Item = newItem;
                        item.IsSoldOut = false;
                    }
                        
                    else
                    {
                        throw new Exception("already item is present, you can not add item here");
                    }
                }
            }
        }

        public Item GetItem(int codeNumber)
        {
            foreach (var item in inventory)
            {
                if (item.Code == codeNumber)
                {
                    if (item.IsSoldOut)
                    {
                        throw new Exception("Item alreadt sold out");
                    }

                    else
                    {
                        return item.Item;
                    }
                }
            }

            return null;
        }

        public void UpdateSoldOutItem(int codeNumber)
        {
            foreach (var item in inventory)
            {
                if(item.Code == codeNumber)
                {
                    item.IsSoldOut = true;
                }
            }
        }
    }
}