using System;

namespace SRP
{
    class RegistraLog : Ilogger
    {
        public void Info(string info)
        {
            Console.WriteLine(info);
        }
    }
}
