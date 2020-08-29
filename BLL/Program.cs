using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using System.Xml;

 [assembly: log4net.Config.XmlConfigurator(Watch=true)] //using xml configuration to configure log4net

namespace LoginProject1.BLL
{
    class Program
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public static void Main(string[] args)
        {

            log.Error("This is an error message");
        }

    }
}
