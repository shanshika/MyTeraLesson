using System;

class HomeWork4
{   static void Main(string[] args)
   {
        Console.ReadLine();
   }
        static int getSum(int x, int y)
        {
            return x + y;
        }
        static void GetParams()
        {
            Console.WriteLine("Please enter number1:");
            decimal number1 = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Please enter number2:");
            decimal number2 = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Please enter number3:");
            decimal number3 = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Please enter number4:");
            decimal number4 = decimal.Parse(Console.ReadLine());
            Console.WriteLine();

            if (number1 <= number2 && number1 <= number3 && number1 <= number4)
            {
                Console.WriteLine("The smallest number is:" + number1);
            }
            else if (number2 <= number3 && number2 <= number4)
            {
                Console.WriteLine("The smallest number is:" + number2);
            }
            else if (number3 <= number4)
            {
                Console.WriteLine("The smallest number is:" + number3);
            }
            else
            {
                Console.WriteLine("The smallest number is:" + number4);
            }
            if (number1 >= number2 && number1 >= number3 && number1 >= number4)
            {
                Console.WriteLine("The biggest number is:" + number1);
            }
            else if (number2 >= number3 && number2 >= number4)
            {
                Console.WriteLine("The biggest number is:" + number2);
            }
            else if (number3 >= number4)
            {
                Console.WriteLine("The biggest number is:" + number3);
            }
            else
            {
                Console.WriteLine("The biggest number is:" + number4);
            }
        }
}
   
