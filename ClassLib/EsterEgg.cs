using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using static System.Console;
using System.Collections.Generic;
using Kalkyl;

namespace ClassLib
{
    public class EsterEgg
    {
        /// <summary>
        /// <see cref="Art"> Metod som kallar på de metoder som skriver ut figurer</see>
        /// </summary>
        /// <param name="height"> Det första heltal som skrivs in till figurens höjd</param>
        /// <param name="width"> Det andra tal som anges för figurens bredd</param>
        public void Art(int height, int width)
        {
            Cube(height, width);
            HollowCube(height, width);
            Triangle(height);
        }

        /// <summary>
        /// Bygger en kub.
        /// <see cref="Cube"> Fyller det ýtan med 'block'</see>
        /// </summary>
        public void Cube(int height, int width)
        {
            Console.WriteLine("En kub");
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.Write("▒");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        /// <summary>
        /// Gör en kub som är ihålig
        /// <see cref="HollowCube">Gör sidorna till ett tecken och insidan till ett annat</see>
        /// </summary>
        public void HollowCube(int height, int width)
        {
            int Wall = 3;
            Console.WriteLine("En ihålig kub");
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    //Använt mig utav || för att göra antingen eller.
                    //Minus 1 används för att få botten att också bli 3 bred.
                    if (i < Wall || i > height - 1 - Wall
                    //Vill få j mindre än väggen för att fylla i de första på höger sida.
                    //Samma som tidigare gäller nedan för att få höger sida ifylld.
                    //Använder mig utav j > än bredden - ett minus väggen
                        || j < Wall || j > width - 1 - Wall)                 
                    {
                        Console.Write("█");
                    }
                    else
                    {
                        Console.Write("░");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Gör en triangel
        /// <see cref="Triangle">Gör en triangel med hjälp utav uträkningar med höjden.</see>
        /// </summary>
        /// <param name="height">Nyttjas för att beräkna bredden och center.</param>
        public void Triangle(int height)
        {
            Console.WriteLine("En Triangel");
            int TriangleWidth = 2 * height - 1;
            int Center = height - 1;
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < TriangleWidth; j++)
                {
                    //See så j är inom center, minus raden(i) OCH inom center + j
                    if (j >= Center - i && j <= Center + i)
                    {
                        Console.Write("▓");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
