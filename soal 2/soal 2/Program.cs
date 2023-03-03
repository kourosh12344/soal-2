using System;

class Program
{
    static void Main(string[] args)
    {
        int[,] array = new int[10, 10];
        Random random = new Random();
        for (int x = 0; x < 10; x++)
        {
            for (int y = 0; y < 10; y++)
            {
                array[x, y] = random.Next(1, 101);
            }
        }
         Console.WriteLine("a:");
        for (int x = 0; x < 10; x++)
        {
            for (int y = 0; y < 10; y++)
            {
                Console.Write(array[x, y] + "\t");
            }
            Console.WriteLine();
        }
        Console.Write("number 1: ");
        int num1 = int.Parse(Console.ReadLine());
        Console.Write("number 2: ");
        int num2 = int.Parse(Console.ReadLine()); 
        Console.WriteLine("pasokh:");
        for (int y = 0; y < 10; y++)
        {
            bool foundNum1 = false;
            bool foundNum2 = false;
            for (int x = 0; x < 10; x++)
            {
                if (array[x, y] == num1)
                {
                    foundNum1 = true;
                }
                if (array[x, y] == num2)
                {
                    foundNum2 = true;
                }
            }
            if (foundNum1 && foundNum2)
            {
                Console.WriteLine(y);
            }
        }
        Console.ReadLine();
    }
}
