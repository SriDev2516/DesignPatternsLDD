using System;
using System.Collections.Generic;
using System.Text;

namespace DesignVendingMachine
{
    public class ItemShelf
    {
        private int _code;
        private Item _item;
        private bool _isSoldOut;

        public int Code { get => _code; set => _code = value; }
        public Item Item { get => _item; set => _item = value; }
        public bool IsSoldOut { get => _isSoldOut; set => _isSoldOut = value; }
    }
}
