using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWork5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int gold;
            int crystals;
            int crystalPrice = 10;

            Console.WriteLine("Доброго времени суток, сегодня у нас акция, один кристалл стоит " + crystalPrice + " золотых");
            
            Console.Write("Сколько у вас с собой золота? ");
            gold = Convert.ToInt32(Console.ReadLine());

            Console.Write("Сколько вы хотите приобрести кристаллов? ");
            crystals = Convert.ToInt32(Console.ReadLine());

            gold -= crystals * crystalPrice;
            Console.WriteLine($"И того у вас {crystals} кристаллов и {gold} золотых ");

        }

    }
}
