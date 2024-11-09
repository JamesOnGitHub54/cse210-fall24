using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int userNumber = -1;
        List<int> numbers = new List<int>();

        //Get Numbers
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        do
        {
            Console.Write("Enter number: ");
            userNumber = int.Parse(Console.ReadLine());
            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }


        } while (userNumber != 0);

        //Calculations
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }


        float totNumbers = numbers.Count;
        float average = sum / totNumbers;


        int largest = 0;
        foreach (int number in numbers)
        {
            if (number > largest)
            {
                largest = number;
            }
        }

        //Results
        Console.WriteLine($"The sum is: {sum} \nThe average is: {average} \nThe largest number is: {largest}");
    }
}