using DesignVendingMachineTest.Inventory;
using DesignVendingMachineTest.States.Implementation;
using System;
using System.Collections.Generic;

namespace DesignVendingMachineTest.States
{
    
    public class VendingMachine
    {
        private readonly IInventory _inventory;
        private IState _state;
        public List<Coin> _coins;
        public IInventory Inventory { 
            get  { return _inventory; } 
        }

        public VendingMachine(IInventory inventory)
        {
            _state = new IdleState();
            _inventory = inventory;
            _coins = new List<Coin>();
            _inventory.SetInitialInventory();
        }

        public IState State
        {
            get
            {
                return _state;
            }
            set
            {
                _state = value;
            }
        }

        public List<Coin> Coins { get; set; } = new List<Coin>();

        public ItemShelf[] GetAvailableItems()
        {
            return _inventory.GetInventory();
        }

       
    }
}