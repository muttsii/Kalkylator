using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kalkyl;


namespace Kalkyl
{
    /// <summary>
    /// Läser in användarens inmatningar
    /// </summary>
    public class InputChoice
    {
        public string UserInputChoice()
        {
            return Console.ReadLine();
        }
    }

    /// <summary>
    /// Tar emot användarens inmatningar vid tal i formutav decimal.
    /// </summary>
    public class Input
    {
        /// <summary>
        /// Metod som behandlar de inmatade siffrorna.
        /// Ifall användaren skriver in "xyzzy" händer inget med hälp utav en if-sats.
        /// En try som konverterar till Decimal.
        /// Catch fångar upp ifall inget av ovanstående fungerar.
        /// </summary>
        /// <returns> Returnerar antingen inmatat tal alternativt tillbaka till metoden för ny inmatning</returns>
        public decimal UserInputValues()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            string input = Console.ReadLine();
            if (input == "xyzzy")
            {
                NothingHappens();
            }
            else if (input == "q")
            {
                Console.WriteLine("Sluträknat");
                System.Environment.Exit(0);
            }
            try
            {
                decimal i = Convert.ToDecimal(input);
                    return i;   
            }
            catch
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Fel inmatning, var god försök igen");
                    return UserInputValues();
            }
        }

        /// <summary>
        /// Skriver ut "Nothing happens"
        /// </summary>
        public void NothingHappens()
        {
            Console.WriteLine("Nothing happens");
        }

        /// <summary>
        /// Metod som behandlar de värden som skrivs in för ester-egg.
        /// Läser in int värden enbart och försöker convertera.
        /// Catch fångar upp ifall inget av ovanstående fungerar.
        /// </summary>
        /// <returns>Ett intvärde eller ber om en ny ínmatning.</returns>
        public int UserInputValuesEster()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            string input = Console.ReadLine();
            if (input == "xyzzy")
            {
                NothingHappens();
            }
            else if(input == "q")
            {
                Console.WriteLine("Sluträknat");
                System.Environment.Exit(0);
            }
            try
            {
                int i = Convert.ToInt32(input);
                return i;
            }
            catch
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Fel inmatning, var god försök igen");
                return UserInputValuesEster();
            }
        }
    }
}
