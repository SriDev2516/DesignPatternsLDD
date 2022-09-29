using DesignVendingMachineTest.HelperModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignVendingMachineTest.States.Implementation
{
    public class DispenseProductState : IState
    {
        public DispenseProductState(VendingMachine machine)
        {
            Console.WriteLine("Currently in Dispense State");
        }
        public void Cancel(VendingMachine machine)
        {
            throw new NotImplementedException();
        }

        public void Dispense(VendingMachine machine)
        {
            machine.State = new IdleState();
        }

        public int GetChange(VendingMachine machine, int ItemCode)
        {
            throw new NotImplementedException();
        }

        public void InsertCoin(VendingMachine machine)
        {
            throw new NotImplementedException();
        }

        public void PressInsertCoinButton(VendingMachine machine)
        {
            throw new NotImplementedException();
        }

        public ItemViewModel PressSelectProductButton(VendingMachine machine, int CodeNumber = 0)
        {
            throw new NotImplementedException();
        }

        public List<Coin> RefundAll(VendingMachine machine)
        {
            throw new NotImplementedException();
        }

        public Item SelectProduct(VendingMachine machine, int CodeNumber = 0)
        {
            throw new NotImplementedException();
        }

       
    }
}
