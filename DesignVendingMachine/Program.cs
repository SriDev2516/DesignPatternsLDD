using DesignVendingMachine.VendingStates;
using System;

namespace DesignVendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            VendingMachine vendingMachine = new VendingMachine();

            try
            {
                Console.WriteLine("|");
                Console.WriteLine("Filling up the inventory");
                Console.WriteLine("|");

                FillUpTheInventory(vendingMachine);
                DisplayInventory(vendingMachine);

                Console.WriteLine("|");
                Console.WriteLine("clicking on InsertCoinButton");
                Console.WriteLine("|");

                IState vendingState = vendingMachine.GetVendingMachineState();
                vendingState.ClickOnInsertCoinButton(vendingMachine);

                vendingState = vendingMachine.GetVendingMachineState();
                vendingState.InsertCoin(vendingMachine, CoinType.NICKEL);
                vendingState.InsertCoin(vendingMachine, CoinType.QUARTER);

                Console.WriteLine("|");
                Console.WriteLine("clicking on ProductSelectionButton");
                Console.WriteLine("|");
                vendingState.ClickOnStartProductSelectionButton(vendingMachine);

                vendingState = vendingMachine.GetVendingMachineState();
                vendingState.ChooseProduct(vendingMachine, 102);

                DisplayInventory(vendingMachine);



            }
            catch (Exception)
            {

                throw;
            }
        }

        
        private static void FillUpTheInventory(VendingMachine vendingMachine)
        {
            ItemShelf[] solts = vendingMachine.GetInventory().GetInventory();

            for (int i = 0; i < solts.Length; i++)
            {
                Item newItem = new Item();
                if(i >= 0 && i < 3)
                {
                    newItem.ItemType = ItemType.COKE;
                    newItem.Price = 12;
                }
                else if (i >= 3 && i < 5)
                {
                    newItem.ItemType = (ItemType.PEPSI);
                    newItem.Price = 9;
                }
                else if (i >= 5 && i < 7)
                {
                    newItem.ItemType = (ItemType.JUICE);
                    newItem.Price = 13;
                }
                else if (i >= 7 && i < 10)
                {
                    newItem.ItemType = (ItemType.SODA);
                    newItem.Price = 7;
                }

                solts[i].Item = newItem;
                solts[i].IsSoldOut = false;

        }
    }

        private static void DisplayInventory(VendingMachine vendingMachine)
        {
            var slots = vendingMachine.GetInventory().GetInventory();

            for (int i = 0; i < slots.Length; i++)
            {
                var item = slots[i];
                Console.WriteLine($"Code Number : {item.Code},  " +
                    $"Item Type: {item.Item.ItemType},  Price: {item.Item.Price},  Is Available: {!item.IsSoldOut}");
            }
        }

    }
}
