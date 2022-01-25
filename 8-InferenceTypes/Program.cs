using Microsoft.CSharp.RuntimeBinder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_InferenceTypes
{
    public class Connection
    {
        public string ConnectionString;
        public void Connect()
        {
            Console.WriteLine("Connecting..." + ConnectionString);
        }

        public void Close()
        {
            Console.WriteLine("Closing..." + ConnectionString);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var conn = new Connection() { ConnectionString = "SqlServer" };
            conn.Connect();
            conn.Close();

            try
            {
                dynamic conn2 = new Connection() { ConnectionString = "Oracle" };
                conn2.Opening();
            }
            catch (RuntimeBinderException e)
            {
                Console.WriteLine("Occurred an error: " + e.Message);
            }

            Console.Read();
        }
    }
}
