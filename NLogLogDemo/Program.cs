using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLogLogDemo
{
    class Program
    {


        private static NLog.Logger log = NLog.LogManager.GetCurrentClassLogger();


        static void Main(string[] args)
        {
            log.Debug("App start");
            log.Debug("Test 1 - tekst");
            //log.Debug("App slutt");


        
        }
    }
}
