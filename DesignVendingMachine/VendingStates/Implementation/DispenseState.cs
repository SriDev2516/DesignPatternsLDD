using System;
using System.Collections.Generic;
using System.Text;

namespace DesignVendingMachine.VendingStates
{
    public class DispenseState : IState
    {

        public DispenseState()
        {
            Console.WriteLine("In dispense state");
            
        }

        public DispenseState(VendingMachine machine, int codeNumber)
        {
            DispenseProduct(machine, codeNumber);
        }
        public void ChooseProduct(VendingMachine machine, int codeNumber)
        {
            throw new NotImplementedException();
        }

        public void ClickOnInsertCoinButton(VendingMachine machine)
        {
            throw new NotImplementedException();
        }

        public void ClickOnStartProductSelectionButton(VendingMachine machine)
        {
            throw new NotImplementedException();
        }

        public Item DispenseProduct(VendingMachine machine, int codeNumber)
        {
            Console.WriteLine("Product has been dispensed");
            Item item = machine.GetInventory().GetItem(codeNumber);
            machine.GetInventory().UpdateSoldOutItem(codeNumber);
            machine.SetVendingMachineState(new IdleState(machine));
            return item;

        }

        public int GetChange(int returnChangeMoney)
        {
            throw new NotImplementedException();
        }

        public void InsertCoin(VendingMachine machine, CoinType coin)
        {
            throw new NotImplementedException();
        }

        public List<Coin> RefundFullMoney(VendingMachine machine)
        {
            throw new NotImplementedException();
        }

        public void UpdateInventory(VendingMachine machine, Item item, int codeNumber)
        {
            throw new NotImplementedException();
        }
    }
}
