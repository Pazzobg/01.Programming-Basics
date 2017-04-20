using System;

namespace _21.Battles
{
    class Battles
    {
        static void Main(string[] args)
        {
            int firstPlayerPoks = int.Parse(Console.ReadLine());
            int secondPlayerPoks = int.Parse(Console.ReadLine());
            int maxBattleNumber = int.Parse(Console.ReadLine());
            int battleCounter = 0;

            for (int i = 1; i <= firstPlayerPoks; i++)
            {
                if (maxBattleNumber == 0) break;
                for (int j = 1; j <= secondPlayerPoks; j++)
                {
                    battleCounter++;
                    Console.Write($"({i} <-> {j}) ");
                    if (battleCounter == maxBattleNumber) break;
                }
                if (battleCounter == maxBattleNumber) break;
            }
            Console.WriteLine();
        }
    }
}
