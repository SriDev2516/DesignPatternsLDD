using DesignVendingMachineTest.HelperModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignVendingMachineTest.States.Implementation
{

    public class SelectProductState : IState
    {
        ItemViewModel selectedItem;
        
        public SelectProductState(VendingMachine machine)
        {
            selectedItem = new ItemViewModel();
            Console.WriteLine("Currently in Select Product State");
        }
        public void Cancel(VendingMachine machine)
        {
            machine.State = new IdleState();
            RefundAll(machine);
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
            var items = machine.Inventory.GetInventory();
            var enteredAmount = IsSufficientAmount(machine.Coins);
            foreach (var item in items)
            {
                if(item.CodeNumber == CodeNumber && item.IsAvailable)
                {
                    if(item.Item.Price > enteredAmount)
                    {
                        Cancel(machine);
                        throw new Exception("Insufficient Funds!");
                    }
                    else
                    {
                        
                        int change = enteredAmount - item.Item.Price;
                        item.IsAvailable = false;
                        selectedItem.Change = change;
                        selectedItem.Item = item.Item;
                    }
                }
            }
            machine.State = new DispenseProductState(machine);
            return selectedItem;
        }

        private int IsSufficientAmount(List<Coin> coins)
        {
            int sum = 0;
            foreach(var coin in coins)
            {
                sum += coin.Value;
            }

            return sum;
        }
        public List<Coin> RefundAll(VendingMachine machine)
        {
            return machine.Coins;
        }

        public Item SelectProduct(VendingMachine machine, int CodeNumber = 0)
        {
            throw new NotImplementedException();
        }

        public void Dispense(VendingMachine machine)
        {
            throw new NotImplementedException();
        }

        public int GetChange(VendingMachine machine, int ItemCode)
        {
            throw new NotImplementedException();
        }

    }
}
