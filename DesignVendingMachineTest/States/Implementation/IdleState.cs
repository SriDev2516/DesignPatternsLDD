using DesignVendingMachineTest.HelperModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignVendingMachineTest.States.Implementation
{
    public class IdleState : IState
    {
        public IdleState()
        {
            Console.WriteLine("Currently in Idle State");
        }
        public void Cancel(VendingMachine machine)
        {
            machine.State = new IdleState();
            RefundAll(machine);
        }

        public void Dispense(VendingMachine machine)
        {
            throw new NotImplementedException();
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
            machine.State = new InsertCoinState(machine);
        }

        public ItemViewModel PressSelectProductButton(VendingMachine machine, int CodeNumber = 0)
        {
            throw new NotImplementedException();
        }

        public List<Coin> RefundAll(VendingMachine machine)
        {
            return machine._coins;
        }

        public Item SelectProduct(VendingMachine machine, int CodeNumber = 0)
        {
            throw new NotImplementedException();
        }
    }
}
