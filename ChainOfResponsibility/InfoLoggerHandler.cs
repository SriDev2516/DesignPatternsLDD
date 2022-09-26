using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility
{
    public class InfoLoggerHandler : LogProcesssor
    {
        public InfoLoggerHandler(LogProcesssor logProcesssor) : base(logProcesssor)
        {

        }

        public override void Log(LogType type, string message)
        {
            if(type == LogType.Info)
            {
                Console.WriteLine("Info: Log Handler Activated");
            }
            else
            {
                base.Log(type, message);
            }
        }
    }
}
