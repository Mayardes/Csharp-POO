using System;
using System.Data.SqlClient;
using System.Text;

namespace _27_InterfacesIDisposable
{
    public class Connection : IDisposable
    {
        public string Handle; //its same that a pointer for an resource
        public void Dispose()
        {
            this.Handle = "";
            Console.WriteLine("Resource released successfully");
        }

        public Connection()
        {
            this.Handle = "Resource Allocated";
            Console.WriteLine("Resource allocated sucessfully");

        }

        public void Close()
        {
            Console.WriteLine("Closing connection...");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            using (var con = new Connection())
            {
                Console.WriteLine("Open connection..");
                con.Close();
            }

            Console.ReadKey();
        }

        private static void TestConnection()
        {
            var obj = new SqlConnection();
            try
            {

            }
            catch (Exception E)
            {

            }
            finally
            {
                if (obj != null)
                    obj.Dispose();

            }

            //using(var obj2 = new SqlConnection())
            //{

            //}//call method dispose automatically
        }
    }
}
