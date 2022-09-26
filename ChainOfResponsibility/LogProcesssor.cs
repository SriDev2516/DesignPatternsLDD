using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility
{
    public abstract class LogProcesssor
    {
        LogProcesssor nextlogProcesssor;
        public LogProcesssor(LogProcesssor logProcesssor)
        {
            this.nextlogProcesssor = logProcesssor;
        }

        public virtual void Log(LogType logType, string message)
        {
            if (this.nextlogProcesssor != null)
            {
                nextlogProcesssor.Log(logType, message);
            }
        }

       
    }
}
