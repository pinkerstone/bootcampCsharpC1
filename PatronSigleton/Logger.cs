using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronSigleton
{
    public static class Logger
    {
        public static string Mensaje {  get; set; }

        public static void Send()
        {
            Console.WriteLine(Mensaje);
        }
    }


}
