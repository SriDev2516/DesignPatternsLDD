using ATMDesignImplementation;
using ChainOfResponsibility;
using System;

namespace CORTestProject
{
    internal class Program
    {
        static void Main(string[] args)

        {
            //LogProcesssor infoLoggerHandler = new InfoLoggerHandler(new DebugLogHandler(new ErrorLogHandler(null)));

            //infoLoggerHandler.Log(LogType.Error, "");
            //infoLoggerHandler.Log(LogType.Debug, "");
            //infoLoggerHandler.Log(LogType.Info, "");

            TwoThousandNotesHandler twoThousandNotesHandler = new TwoThousandNotesHandler(
                new FiveHundredNotesHandler(new HunderdNotesHandler(null)), new NotesRespository());
            bool isValid = CheckValidAmount(3650);
            if (isValid)
            {
                twoThousandNotesHandler.Dispense(Denomination.TwoThousand, 3400);

            }
            else
            {
                Console.WriteLine($"The entered amount is incorrect. Please enter multiples of 100");
            }
        }

        private static bool CheckValidAmount(int v)
        {
            if(v % 100 != 0)
                return false;

            return true;
            
        }
    }
}
