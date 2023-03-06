using System;
  class HomeWork4

  {
    static void Main(string[] args)
    {
        Console.ReadLine();
    }
    //HomeWork4-1
    static int getSum(int x, int y)
    {
        return x + y;
    }
    //HomeWork4-2
    static void Numbers(double numb1, double numb2, double numb3, double numb4)
    {
        if (numb1 >= numb2 && numb1 >= numb3 && numb1 >= numb4)
        {
            Console.WriteLine("The largest number is: " + numb1);
        }
        else if (numb2 >= numb1 && numb2 >= numb3 && numb2 >= numb4)
        {
            Console.WriteLine("The largest number is: " + numb2);
        }
        else if (numb3 >= numb1 && numb3 >= numb2 && numb3 >= numb4)
        {
            Console.WriteLine("The largest number is:" + numb3);
        }
        else if (numb4 >= numb1 && numb4 >= numb2 && numb4 >= numb3)
        {
            Console.WriteLine("The largest number is: " + numb4);
        }
        else
        {
            Console.WriteLine("These numbers is equal");
        }


        if (numb1 <= numb2 && numb1 <= numb3 && numb1 <= numb4)
        {
            Console.WriteLine("The smallest number is: " + numb1);
        }
        else if (numb2 <= numb1 && numb2 <= numb3 && numb2 <= numb4)
        {
            Console.WriteLine("The smallest number is: " + numb2);
        }
        else if (numb3 <= numb1 && numb3 <= numb2 && numb3 <= numb4)
        {
            Console.WriteLine("The smallest number is:" + numb3);
        }
        else if (numb4 <= numb1 && numb4 <= numb2 && numb4 <= numb3)
        {
            Console.WriteLine("The smallest number is: " + numb4);
        }
        else
        {
            Console.Write("");
        }
    
}
    //HomeWork4-3

    static void Fruits()
    {
        Console.Write("Please, enter fruit: ");
        string FruitInput = Console.ReadLine();
        switch (FruitInput)
        {
            case "Apple":
                Console.WriteLine("This fruit is an Apple");
                break;
            case "Watermelon":
                Console.WriteLine("This fruit is a Watermelon");
                break;
            case "Melon":
                Console.WriteLine("This fruit is a Melon");
                break;
            case "Cherry":
                Console.WriteLine("This fruit is a Cherry");
                break;
            case "Straweberry":
                Console.WriteLine("This fruit is a Strawberry");
                break;
            default:
                Console.WriteLine("You have entered other fruit");
                break;

        }


    }
}
   