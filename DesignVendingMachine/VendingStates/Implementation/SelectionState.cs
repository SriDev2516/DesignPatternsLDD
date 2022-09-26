using System;
using System.Collections.Generic;
using System.Text;

namespace DesignVendingMachine.VendingStates
{
    public class SelectionState : IState
    {
        public SelectionState()
        {
            Console.WriteLine("In Selection state");
        }
        public void ChooseProduct(VendingMachine machine, int codeNumber)
        {
            Item item = machine.GetInventory().GetItem(codeNumber);

            //2. total amount paid by User
            int paidByUser = 0;
            foreach (Coin coin in machine.Coins)
            {
                paidByUser = paidByUser + coin.Value;
            }

            //3. compare product price and amount paid by user
            if (paidByUser < item.Price)
            {
                Console.WriteLine("Insufficient Amount, Product you selected is for price: " + item.Price + " and you paid: " + paidByUser);
                RefundFullMoney(machine);
                throw new Exception("insufficient amount");
            }
            else if (paidByUser >= item.Price)
            {

                if (paidByUser > item.Price)
                {
                    GetChange(paidByUser - item.Price);
                }
                machine.SetVendingMachineState(new DispenseState(machine, codeNumber));
            }

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
            throw new NotImplementedException();
        }

        public int GetChange(int returnChangeMoney)
        {
            Console.WriteLine("Returned the change in the Coin Dispense Tray: " + returnChangeMoney);
            return returnChangeMoney;

        }

        public void InsertCoin(VendingMachine machine, CoinType coin)
        {
            throw new NotImplementedException();
        }

        public List<Coin> RefundFullMoney(VendingMachine machine)
        {
            Console.WriteLine("Returned the full amount back in the Coin Dispense Tray");
            machine.SetVendingMachineState(new IdleState(machine));
            return machine.Coins;

        }

        public void UpdateInventory(VendingMachine machine, Item item, int codeNumber)
        {
            throw new NotImplementedException();
        }
    }
}
