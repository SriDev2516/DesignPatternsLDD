using System;
using System.Collections.Generic;
using System.Text;

namespace DesignVendingMachine.VendingStates
{
    public class HasMoneyState : IState
    {
        public HasMoneyState() => Console.WriteLine("Currently in Has Money State");
         
        public void ChooseProduct(VendingMachine machine, int codeNumber)
        {
            throw new NotImplementedException();
        }

        public void ClickOnInsertCoinButton(VendingMachine machine)
        {
            return;
        }

        public void ClickOnStartProductSelectionButton(VendingMachine machine) => machine.SetVendingMachineState(new SelectionState());

        public Item DispenseProduct(VendingMachine machine, int codeNumber)
        {
            throw new NotImplementedException();
        }

        public int GetChange(int returnChangeMoney)
        {
            throw new NotImplementedException();
        }

        public void InsertCoin(VendingMachine machine, CoinType coin)
        {
            Console.WriteLine("Accepted the coin");
            var newCoin = new Coin();
            newCoin.Value = (int)coin;
            machine.Coins.Add(newCoin);

        }

        public List<Coin> RefundFullMoney(VendingMachine machine)
        {
            Console.WriteLine("Returned the full amount back in the Coin Dispense Tray");
            machine.SetVendingMachineState(new IdleState());
            return machine.Coins;
        }

        public void UpdateInventory(VendingMachine machine, Item item, int codeNumber)
        {
            throw new NotImplementedException();
        }
    }
}
