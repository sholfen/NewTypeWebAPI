using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLib
{
    public enum Level
    {
        Error = 0,
        Warning = 1,
        Information = 2,
    }

    public class LoggingSetter
    {
        public static Action<Level, string> ErrorLogger = (l, m) => Console.WriteLine(m.ToString());

        public static Action<Level, string> WarningLogger = (l, m) => Console.WriteLine(m.ToString());

        public static Action<Level,string> InformationLogger = (l, m) => Console.WriteLine(m.ToString());

        public static Action<Level, string> LogMessage = (l, m) => Console.WriteLine(l.ToString());

        public LoggingSetter() 
        {

        }

        public void SetError(Action<Level, string> action)
        {

        }

        public void SetWarning(string warning) 
        {

        }

        public void SetInfo(string info) 
        {

        }    
    }
}
