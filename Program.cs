// See https://aka.ms/new-console-template for more information

namespace variables
{
    class program
    {
        static void Main(string[] arg)
        {
            /*  {
                  byte number;
                  number = 255;
                  Console.WriteLine(number);
              }
            */
            //Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);
            string number = "1234";
            int num=Convert.ToInt32(number);
            Console.WriteLine(number);
        }
    }
}
