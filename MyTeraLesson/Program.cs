using System;
  class HomeWork5
  {
    static void Main(string[] args)
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

