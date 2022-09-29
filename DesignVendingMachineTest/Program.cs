using DesignVendingMachineTest.HelperModel;
using DesignVendingMachineTest.Inventory;
using DesignVendingMachineTest.States;
using DesignVendingMachineTest.States.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DesignVendingMachineTest
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                IInventory inventory = new InventoryImpl();
                inventory.Size = 10;
                VendingMachine machine = new VendingMachine(inventory);
                Console.WriteLine("Items Available");
                DisplayInventory(machine);
                IState state = GetState(machine);
                state.PressInsertCoinButton(machine);
                state = GetState(machine);
                state.InsertCoin(machine);
                state = GetState(machine);
                List<Coin> coin = new List<Coin>() { new Coin() { Value = (int)CoinType.DIME }, new Coin() { Value = (int)CoinType.QUARTER } };
                machine.Coins.AddRange(coin);
                int codeNumber = 104;
                ItemViewModel selectedItem = state.PressSelectProductButton(machine, codeNumber);
                Console.WriteLine($"Please collect your change {selectedItem.Change}");
                state = GetState(machine);
                state.Dispense(machine);
                Console.WriteLine($"Current state is {machine.State}");
                DisplayInventory(machine);
                Console.WriteLine("List of Available Items:");
                DisplayAvailableInventory(machine);
            }
            catch (Exception ex)
            {

                Console.WriteLine($"There was an error. {ex.Message}"); ;
            }
            

        }

        private static void DisplayAvailableInventory(VendingMachine machine)
        {
            var items = machine.GetAvailableItems().Where(i => i.IsAvailable == true).ToArray();
            PrintItemsToScreen(items);
        }

        private static void PrintItemsToScreen(ItemShelf[] items)
        {
            foreach (var product in items)
            {
                Console.WriteLine($"Item Code: {product.CodeNumber}, |" +
                    $"Item Type: {product.Item.ItemName}, |" +
                    $"Item Price: {product.Item.Price}, |" +
                    $"Available:  {product.IsAvailable} |");
            }
        }

        private static IState GetState(VendingMachine machine)
        {
            return machine.State;
        }

        private static void DisplayInventory(VendingMachine machine)
        {
            var items = machine.GetAvailableItems();
            PrintItemsToScreen(items);


        }
    }
}
