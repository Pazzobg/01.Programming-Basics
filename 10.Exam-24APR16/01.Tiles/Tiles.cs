using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Tiles
{
    class Tiles
    {
        static void Main(string[] args)
        {
            var aSquare = int.Parse(Console.ReadLine());
            var wTile = decimal.Parse(Console.ReadLine());
            var lTile = decimal.Parse(Console.ReadLine());
            var wBench = int.Parse(Console.ReadLine());
            var lBench = int.Parse(Console.ReadLine());

            var areaSquare = aSquare * aSquare;
            var areaTile = wTile * lTile;
            var areaBench = wBench * lBench;
            var constructionArea = areaSquare - areaBench;

            var numberTiles = constructionArea / areaTile;
            var time = numberTiles * 0.2m;

            Console.WriteLine(numberTiles);
            Console.WriteLine(time);
        }
    }
}
