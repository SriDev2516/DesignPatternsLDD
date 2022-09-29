using DesignVendingMachineTest.HelperModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignVendingMachineTest.States
{
    public interface IState
    {
        public void PressInsertCoinButton(VendingMachine machine);
        public void InsertCoin(VendingMachine machine);
        public Item SelectProduct(VendingMachine machine, int CodeNumber = 0);
        public List<Coin> RefundAll(VendingMachine machine);
        public ItemViewModel PressSelectProductButton(VendingMachine machine, int CodeNumber = 0);
        public void Cancel(VendingMachine machine);
        public void Dispense(VendingMachine machine);
        public int GetChange(VendingMachine machine, int ItemCode);

        
    }
}
