using System;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage?: ");
        int grade_percent = int.Parse(Console.ReadLine());

        // Determine user grade
        string letter = "";

        if (grade_percent >= 93)
        {
            letter = "A";
        }
        else if (grade_percent >= 90)
        {
            letter = "A-";
        }
        else if (grade_percent >= 87)
        {
            letter = "B+";
        }
        else if (grade_percent >= 83)
        {
            letter = "B";
        }
        else if (grade_percent >= 80)
        {
            letter = "B-";
        }
        else if (grade_percent >= 77)
        {
            letter = "C+";
        }
        else if (grade_percent >= 73)
        {
            letter = "C";
        }
        else if (grade_percent >= 70)
        {
            letter = "C-";
        }
        else if (grade_percent >= 67)
        {
            letter = "D+";
        }
        else if (grade_percent >= 63)
        {
            letter = "D";
        }
        else if (grade_percent >= 60)
        {
            letter = "D-";
        }
        else
        {
            letter = "F";
        }

        // Determine if user passes course
        string result_message = "";
        if (grade_percent >= 70)
        {
            result_message = "Congratulations! You have passed the course!";
        }
        else
        {
            result_message = "Unfortunately, you have failed the course. You will get it next time!";
        }


        Console.WriteLine($"You have earned the grade of {letter}. \n{result_message}");
    }
}