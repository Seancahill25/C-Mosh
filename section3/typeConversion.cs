using System;


namespace TypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            //byte b = 1;
            //int i = b;
            //Console.WriteLine(i);

            // int i = 1;
            //byte b = (byte) i;
            //Console.WriteLine(b);

            //try
            //{
            //    var number = "1234";
            //    byte b = Convert.ToByte(number);
            //    Console.WriteLine(b);
            //}
            //  catch (Exception)
            // {
            //     Console.WriteLine("The number could not be converted to a byte");
            // }

            try
            {
                string str = "true";
                bool b = Convert.ToBoolean(str);
                Console.WriteLine(b);
            }
            catch (Exception)
            {
                Console.WriteLine("The string could not be converted to a bool");
            }
        }
    }
}
