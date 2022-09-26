using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility
{
    public class ErrorLogHandler : LogProcesssor
    {
        public ErrorLogHandler(LogProcesssor logProcesssor) : base(logProcesssor)
        {
        }

        public override void Log(LogType logType, string message)
        {
            if(logType == LogType.Error)
            {
                Console.WriteLine("Error Log handler activated");
            }
            else
            {
                base.Log(logType, message);
            }
        }
    }
}
