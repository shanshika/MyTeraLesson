using System;
using System.Runtime.CompilerServices;
using System.Threading;
  class HomeWork5
  {
    static void Main(string[] args)
    {
      startGame();
    }
    static void startGame()
    {
        Welcome();
        tries();
    }
    static void Welcome()
    {
        Console.WriteLine("Hello, let's start...");
        Console.WriteLine();
        Console.WriteLine("Read the instructions please...");
        Console.WriteLine();
        Instruction();
    }
    static void Instruction()
    {
        Console.WriteLine("I have a hidden number for you ");
        Console.WriteLine("This number is between 0 to 20 ");
        Console.WriteLine("Your must guess this number ");
        Console.WriteLine("You have 3 attempts ");
    }
    static int randomNumber()
    {
      return new Random().Next(0, 21);
    }
       static int enterNumb()
       {
        Console.WriteLine();
        Console.Write("Enter a Number: ");
        return Int32.Parse(Console.ReadLine());
       }
    static void tries()
    {
        int retries = 0;
        while (retries < 3)
        {
            retries++;
            int randomNumb = randomNumber();
            int enterNumber = enterNumb();
            
            string retrygame = Console.ReadLine();

            Console.WriteLine("Right number is: " + randomNumb);
             if (randomNumb == enterNumber)
             {
                Console.WriteLine("You have WON !");
                Console.WriteLine("Do you want to continue game? Y or N");
                
                if (retrygame == "Y")
                {
                    tries();
                }
                else
                {
                    return;
                }
                return;
             }
        }
        
        Console.WriteLine("Yo have Lose!");
               
        string retrygame = Console.ReadLine();
        if (retrygame == "Y")
        {
            tries();
        }
        else
        {
            return;
        }
        Console.ReadLine();
    }
  } 
