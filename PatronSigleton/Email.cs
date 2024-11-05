using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronSigleton
{
    public class Email
    {
        public string Mensaje {  get; set; }

        private static Email _instance;

        public static Email Instance
        {
            get 
            { 
                if (_instance == null)
                {
                    _instance = new Email();
                }
                return _instance;
            }

        }
        public void Send()
        {
            Console.WriteLine(Mensaje);
        }


    }
}
