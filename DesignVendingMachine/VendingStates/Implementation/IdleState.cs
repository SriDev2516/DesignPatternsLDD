using System;
using System.Collections.Generic;
using System.Text;

namespace DesignVendingMachine.VendingStates
{
    public class IdleState : IState
    {
        public IdleState() => Console.WriteLine("Currently machine is in Ideal State");
        public IdleState(VendingMachine machine) => machine.Coins = new List<Coin>();
        public void ChooseProduct(VendingMachine machine, int codeNumber) => throw new Exception("you can not choose Product in idle state");

        public void ClickOnInsertCoinButton(VendingMachine machine) => machine.SetVendingMachineState(new HasMoneyState());

        public void ClickOnStartProductSelectionButton(VendingMachine machine) => throw new Exception("first you need to click on insert coin button");

        public Item DispenseProduct(VendingMachine machine, int codeNumber) => throw new Exception("proeduct can not be dispensed idle state");

        public int GetChange(int returnChangeMoney) => throw new Exception("you can not get change in idle state");

        public void InsertCoin(VendingMachine machine, CoinType coin) => throw new Exception("you can not insert Coin in idle state");

        public List<Coin> RefundFullMoney(VendingMachine machine) => throw new Exception("you can not get refunded in idle state");

        public void UpdateInventory(VendingMachine machine, Item item, int codeNumber)
        {
            machine.GetInventory().AddItem(item, codeNumber);
        }
    }
}
