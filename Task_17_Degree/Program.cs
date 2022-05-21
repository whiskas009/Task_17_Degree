using System;

namespace Task_17_Degree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maxLimitRandom = 1000;
            int minLimitRandom = 0;
            Random random = new Random();
            int limitForMultiplication = random.Next(minLimitRandom, maxLimitRandom);
            
            int multiplyNumber = 2;
            int degree = 1;
            int sumMultiply = multiplyNumber;
            
            for (int i = multiplyNumber; i < limitForMultiplication; i *= multiplyNumber)
            {
                sumMultiply *= multiplyNumber;
                degree++;
            }

            Console.WriteLine($"Исходное число: {limitForMultiplication} \nСтепень: {degree} \nЧисло {multiplyNumber} в степени {degree}: {sumMultiply}");
        }
    }
}
