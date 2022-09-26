using System;
using System.Collections.Generic;
using System.Text;

namespace DesignVendingMachine
{
    public class Item
    {
        private ItemType _itemType;
        private int _price;

        public ItemType ItemType { get => _itemType; set => _itemType = value; }
        public int Price { get => _price; set => _price = value; }
    }
}
