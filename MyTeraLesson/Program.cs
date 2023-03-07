using System;
using System.Diagnostics.CodeAnalysis;

class FirstHomeWork 
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to C# ");
        Console.WriteLine("Mr.Pirce");

        //HomeWork3-1     
        
        Console.WriteLine("Please enter x: ");
        int x = Int32.Parse(Console.ReadLine());

        Console.WriteLine("Please enter y: ");
        int y = Int32.Parse(Console.ReadLine());

        Console.WriteLine("Please enter z: ");
        int z = Int32.Parse(Console.ReadLine());

        int Sum = x + (y * z);
        Console.WriteLine("Your answer is: " + Sum);

        // HomeWork3-2

        Console.WriteLine("Enter Your Name: ");
        Console.ReadLine();

        Console.WriteLine("Enter Your Surname:");
        Console.ReadLine();

        Console.WriteLine("Enter Your age: ");
        int age = Int32.Parse(Console.ReadLine());

        Console.WriteLine("Enter Your weight: ");
        decimal weight = decimal.Parse(Console.ReadLine());

        Console.WriteLine("Enter Your height: ");
        decimal height = decimal.Parse(Console.ReadLine());

        //HomeWork3-3
        
        Console.WriteLine("Enter Your Weight: ");
        decimal Weight = decimal.Parse(Console.ReadLine());

        Console.WriteLine("Enter Your Height: ");
        decimal Height = decimal.Parse(Console.ReadLine());

         decimal BMI = (Weight / ((Height / 100) * (Height / 100)));

        Console.WriteLine("Your BMI is:" +  BMI);

        Console.ReadLine();


        //HomeWork3-4


        Console.WriteLine();
        Console.WriteLine(" " +"|" + " "+ "|" + " ");
        Console.WriteLine("1"+ "|" + "2" +"|" + "3");
        Console.WriteLine("__"+"|" +"__" +"|" +"__");
        Console.WriteLine(" " +"|" + " " +"|" + " ");
        Console.WriteLine("4" +"|" + "5" +"|" + "6");
        Console.WriteLine("__"+"|" +"__" +"|" +"__");
        Console.WriteLine(" " +"|" + " " +"|" + " ");
        Console.WriteLine("7" +"|" + "8" +"|" + "9");
        Console.WriteLine(" " +"|" + " " +"|" + " ");
        Console.WriteLine();
        Console.WriteLine();

    }
}
