using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//good number divisible by 7 but not contain 7 in it
namespace BasicCodes
{
    internal class GoodNumber
    {
        
        public static void Main()
        {
            Console.WriteLine("Enter Number:");
            try
            {
                string? numberInString = Console.ReadLine();
                int numberInInt;
                if (numberInString == null)
                {
                    Console.WriteLine("Number not Entered");
                }

                else if (numberInString.Contains('7'))
                {
                    Console.WriteLine("Not Good Number");
                }
                else
                {
                    numberInInt = int.Parse(numberInString);
                    if (numberInInt % 7 == 0)
                    {
                        Console.WriteLine("Good Number");

                    }
                }
            }

            catch (NullReferenceException ex1)
            {
                Console.WriteLine(ex1.Message);
            }
            catch(FormatException ex2)
            {
                Console.WriteLine(ex2.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
            

        }


    }
}
