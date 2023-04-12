using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Pictures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int gold;
            int crystals;
            int pricePurchase = 5;

            Console.WriteLine("Добро пожаловать в магазин КРИСТАЛ! Сегодня кристалы по " + pricePurchase + " золотых.");
            Console.Write("Сколько у Вас золота: ");
            gold = Convert.ToInt32(Console.ReadLine());
            Console.Write("Сколько кристалов вы хотите купить: ");
            crystals = Convert.ToInt32(Console.ReadLine());
            gold -= (crystals * pricePurchase);
            Console.WriteLine($"Поздравляю, вы купили {crystals} кристалов, а золота теперь у вас {gold}.");
            Console.ReadKey();
        }
    }
}