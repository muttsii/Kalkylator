using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kalkyl;

namespace Kalkyl
{
    /// <summary>
    /// Här är de metoder som nyttjas vid uträkningar.
    /// metoderna innefattar Addition, subtraktion, division och mulitplikation.
    /// </summary>
    public class Calculation
    {
        /// <summary>
        /// <see cref="Add"> Metod för addition med två "decimal"</see>
        /// </summary>
        /// <param name="num1">Det första talet som läses in till vänster om operand</param>
        /// <param name="num2">Det andra talet som läses in till vänster om operand</param>
        /// <returns> Retunerar summan.</returns>
        public decimal Add(decimal num1, decimal num2)
        {
            return num1 + num2;
        }

        /// <summary>
        /// <see cref="Sub"> Metod för att subtrahera</see>
        /// </summary>
        /// <param name="num1">Första inlästa Termen</param>
        /// <param name="num2">Andra inlästa termen</param>
        /// <returns> Returnerar en Differens mellan termerna</returns>
        public decimal Sub(decimal num1, decimal num2)
        {
            return num1 - num2;
        }

        /// <summary>
        /// <see cref="Div"> Metod för att beräkna Kvoten</see>
        /// </summary>
        /// <param name="num1"> Täljaren i beräkningen</param>
        /// <param name="num2"> Nämnaren i beräkningen</param>
        /// <returns> Returnerar kvoten utav täljaren och kvoten</returns>
        public decimal Div(decimal num1, decimal num2)
        {
                return num1 / num2; 
        }

        /// <summary>
        /// <see cref="Mul"> Metod för att beräkna produkten</see>
        /// </summary>
        /// <param name="num1"> Första inlästa faktorn</param>
        /// <param name="num2"> Andra inlästa faktorn</param>
        /// <returns> Returnerar produkten utav två faktorer</returns>
        public decimal Mul(decimal num1, decimal num2)
        {
            return num1 * num2;
        }
    }
    /// <summary>
    /// Class som inefattar de två metoder som beräknar omvanlding mellan celsius och fahrenheit.
    /// Metoderna i klassen är begränsade till enbart två decimaler vid return.
    /// </summary>
    public class Temperature
    {
        /// <summary>
        /// <see cref="CtoF"> Beräknar omvandling från celsius till fahrenheit</see>
        /// </summary>
        /// <param name="celsius"> Den inmatade graden användaren har anget för omvandling</param>
        /// <returns> Ger antal grader fahrenheit</returns>
        public decimal CtoF(decimal celsius)
        {
            try
            {
                return decimal.Round((celsius * 9) / 5 + 32, 2);
            }
            catch
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Aja baja, du gjorde fel... försök igen");
                return CtoF(0);
            }
        }
        /// <summary>
        /// <see cref="FtoC"> Beräknar från fahrenheit till celsius</see>
        /// </summary>
        /// <param name="fahrenheit">Den inmatade graden användaren har anget för omvandling</param>
        /// <returns> Ger antalet grader celsius</returns>
        public decimal FtoC(decimal fahrenheit)
        {
            try
            {
                return decimal.Round((fahrenheit - 32) * 5 / 9, 2);
            }
            catch
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Aja baja, du gjorde fel... försök igen");
                return FtoC(0);
            }
        }
    }
}
