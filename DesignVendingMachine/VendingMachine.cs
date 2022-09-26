using DesignVendingMachine.VendingStates;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignVendingMachine
{
    public class VendingMachine
    {
        private IState VendingMachineState;
        private Inventory Inventory;
        private List<Coin> _coins;

        public List<Coin> Coins { get => _coins; set => _coins = value; }

        public VendingMachine()
        {
            VendingMachineState = new IdleState();
            Inventory = new Inventory(10);
            _coins = new List<Coin>();
        }

        public IState GetVendingMachineState()
        {
            return VendingMachineState;
        }

        public void SetVendingMachineState(IState state)
        {
            VendingMachineState = state;
        }

        public Inventory GetInventory()
        {
            return Inventory;
        }

        public void SetInventory(Inventory inventory)
        {
            Inventory = inventory;
        }


    }
}
