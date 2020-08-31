using System;

namespace Task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int granny;
            int totalReceptionTime;
            int hour;
            int minute;
            int timeReceipt = 10;

            Console.Write("Сколько людей в очереди? : ");
            granny = Convert.ToInt32(Console.ReadLine());

            totalReceptionTime = granny * timeReceipt;
            hour = totalReceptionTime / 60;
            minute = totalReceptionTime % 60;
            Console.WriteLine($"Вы будете стоять в очереди {hour} часа и {minute} минут");
            Console.ReadKey();
        }
    }
}
