using System;

namespace _01._Student_Information
{
    class Program
    {
        static void Main(string[] args)
        {
            string studentName = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            double grade = double.Parse(Console.ReadLine());
            Console.Write($"Name: {studentName}, Age: {age}, Grade: {grade:F2}");

        }
    }
}
