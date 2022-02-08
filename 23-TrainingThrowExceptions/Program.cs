using System;

namespace _23_TrainingThrowExceptions
{
    class Program
    {
        public static void Intern(string activity)
        {

            var date = Convert.ToDateTime(activity);

        }
        private static void Programmer(string activity)
        {
            Intern(activity);
        }
        private static void Architect(string activity)
        {
            try
            {
                Programmer(activity);
            }
            catch (Exception E)
            {
                throw new Exception("Occured an error by Architect");
            }
        }
        private static void Coordinator(string activity)
        {
            Architect(activity);
        }
        private static void Manager(string activity)
        {
            try
            {
                Coordinator(activity);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        static void Main(string[] args)
        {
            string activity = "99/99/99999";
            Manager(activity);
            Console.ReadLine();

        }
    }
}
