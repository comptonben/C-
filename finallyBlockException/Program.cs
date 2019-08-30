using System;

namespace finallyBlockException
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Hello();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void Hello()
        {
            try
            {
                throw new Exception("Try block exception");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                //Console.WriteLine("This line will be executed");
                //int result = Convert.ToInt32("TEN");
                //Console.WriteLine("This line will NOT be executed");

                throw new Exception("Finally block exception");
            }
        }
    }
}
