using System;

namespace BasicCodes
{
    public class FibonacciSeries
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number upto which u want fibonscci Series:");
            string ? numberString=Console.ReadLine();
            int uptoNumber = int.Parse(numberString);

            int firstNumber = 0;
            int secondNumber = 1;
            List<int> numbers = new List<int>();
            numbers.Add(firstNumber);   
            numbers.Add(secondNumber);
            int nextnumbertoAdd;

            for(var i = 2; i < uptoNumber; i++)
            {
                nextnumbertoAdd = numbers[i - 1] + numbers[i - 2];
                numbers.Add(nextnumbertoAdd);

            }
            Console.WriteLine("Fibonacci series is:");
            foreach(var number in numbers)
            {
                Console.Write(number+ " ");

            }



        }
    }
}