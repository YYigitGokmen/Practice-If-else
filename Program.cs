using System;


namespace practiceıfelse;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Lütfen bir sayı giriniz: ");
        int number = int.Parse(Console.ReadLine());


        if (number > 10)
        {
            Console.WriteLine("Girilen Sayı 10'dan büyüktür.");
        }
        else if (number < 10)
        {
            Console.WriteLine("Girilen Sayı 10'dan küçüktür");
        }
        else
        {
            Console.WriteLine("Girilen Sayı 10'a eşittir.");
        }
        if ( number % 2 == 0)
        {
            Console.WriteLine("Girilen sayı çiftir.");
        }
           else {
            Console.WriteLine("Girilen sayı tektir.");
            }
    }
}
