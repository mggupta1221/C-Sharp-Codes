using System;

namespace BasicCodes
{
    public class EvenOdd
    {
        static void Main(string[] args)
        {
            try
            {
                int number = Convert.ToInt32(Console.ReadLine());
                if (number == 0)
                {
                    Console.WriteLine("Number enteres is 0");
                }
                else if (number % 2 == 0)
                {
                    Console.WriteLine("Number entered is Even");

                }
                else
                {
                    Console.WriteLine("Number entered is odd");

                }

            }
            catch (FormatException e)
            {
                Console.WriteLine(e);
            }


            


        }



    }




}