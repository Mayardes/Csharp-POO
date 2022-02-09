using System;

namespace _25_AbstractClassesAndInterfaces
{
    public interface IDBConnection
    {
        void Open();
        void Close();
        void StartTransaction();
    }
    public abstract class DBConnection : IDBConnection
    {
        public string ConnectionString { get; set; }
        public virtual void Open()
        {
            Console.WriteLine("Opening connection..");
            Console.WriteLine("Connected on " + this.ConnectionString);
        }
        public void Close()
        {
            Console.WriteLine("Closing conection...");
        }
        public void StartTransaction()
        {
            throw new NotImplementedException();
        }
    }
    public class OracleConnection : DBConnection
    {
        public override void Open()
        {
            Console.WriteLine("Opening new connection..");
            Console.WriteLine("Connected on " + this.ConnectionString);
        }
    }
    public class SqlConnection : DBConnection
    {
    }




    class Program
    {
        static void Main(string[] args)
        {
            //could to use a factory method, or abstract factory
            IDBConnection con = new OracleConnection()
            {
                ConnectionString = "Oracle"
            };

            con.Open();
            con.Close();

        }
    }
}
