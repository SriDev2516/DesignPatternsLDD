using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility
{
    public class DebugLogHandler : LogProcesssor
    {
        public DebugLogHandler(LogProcesssor logProcesssor) : base(logProcesssor)
        {
        }

        public override void Log(LogType logType, string message)
        {
            if(logType == LogType.Debug)
            {
                Console.WriteLine("Debug handler activated");
            }
            else
            {
                base.Log(logType, message);
            }
        }
    }
}
