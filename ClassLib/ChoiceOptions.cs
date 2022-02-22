using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLib;
using Kalkyl;

namespace Kalkyl
{
    /// <summary>
    /// Class med de olika val som användaren behöver gå igenom för att genomföra en ekvation
    /// Denna kommer att fortsäta då programmet ligger i en While-loop. 
    /// Loopen kan brytas efter varje ekvation genom ett val utav användaren i Switchen.
    /// </summary>
    public class ChoiceOptions
    {
        //Instans för att nyttja metoden "UserInputChoice"
        InputChoice choiceOption = new();
        /// <summary>
        /// <see cref="Choice"> Olika val för användaren.
        /// Ifall användaren vill göra uträkningar, Omvandling eller avsluta. </see>
        /// </summary>
        public void Choice()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Input input = new();
            int height, width;
            EsterEgg esterEgg = new();
            Console.WriteLine("För val utav uträkningar Tryck: 1 \n");
            Console.WriteLine("För val utav omvandling utav temperatur Tryck: 2 \n");
            Console.WriteLine("För att avsluta: q");

            //Nyttjar metoden i "UserInputs" för att läsa in användarens val i switchen
            switch (choiceOption.UserInputChoice())
            {
                case "1":
                    Choice1();
                    break;
                case "2":
                    Choice2();
                    break;
                case "xyzzy":
                    Console.WriteLine("Nothing happens");
                    Choice();
                    break;
                case "q":
                    Console.WriteLine("Sluträknat");
                    System.Environment.Exit(0);
                    break;
                case "Art":
                    Console.WriteLine("Gör ett konstverk");
                    Console.WriteLine("Skriv in ett heltal");
                    height = input.UserInputValuesEster();
                    Console.WriteLine("Skriv in ytterligare ett heltal");
                    width = input.UserInputValuesEster();
                    esterEgg.Art(height, width);
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Fel inmatning, var god försök igen");
                    Choice();
                    break;
            }
        }
        /// <summary>
        /// <see cref="Choice1"> Tillåter användaren att välja vilken ekvation som skall genomföras vid val utav uträknignar.
        /// Detta till följt utav de tal som skall ingå. </see>
        /// </summary>
        public void Choice1()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            //Två instanser för att nytja metoder i "Calculations" & "UserInputs"
            Calculation opObj = new();
            Input input = new();

            Console.WriteLine("val utav operator");
            decimal num1, num2;

            //Nyttjar metoden  i "UserInputs" för att läsa in användarens val i switchen
            switch (choiceOption.UserInputChoice())
            {
                case "+":
                    Console.WriteLine("Skriv in ett tal");
                    num1 = input.UserInputValues();
                    Console.WriteLine("Skriv in ytterligare ett tal");
                    num2 = input.UserInputValues();
                    Console.WriteLine("Svaret blir: \n" + opObj.Add(num1, num2));
                    break;
                case "-":
                    Console.WriteLine("Skriv in ett tal");
                    num1 = input.UserInputValues();
                    Console.WriteLine("Skriv in ytterligare ett tal");
                    num2 = input.UserInputValues();
                    Console.WriteLine("Svaret blir: \n" + opObj.Sub(num1, num2));
                    break;
                case "/":
                    Console.WriteLine("Skriv in ett tal");
                    num1 = input.UserInputValues();
                    Console.WriteLine("Skriv in ytterligare ett tal");
                    num2 = input.UserInputValues();
                    //Ifall användaren matar in 0 som nämnare är detta löst med en "while-loop".
                    while (num2 == 0)
                    {
                        Console.WriteLine("Det går ej att dividera med noll \nförsök igen");
                        Console.WriteLine("Skriv in ett andra tal igen");
                        //tillåter användaren skriva in ett tal igen följt utav resultatet.
                        num2 = input.UserInputValues();
                    }
                    Console.WriteLine("Svaret blir: \n" + opObj.Div(num1, num2));
                    break;
                case "*":
                    Console.WriteLine("Skriv in ett tal");
                    num1 = input.UserInputValues();
                    Console.WriteLine("Skriv in ytterligare ett tal");
                    num2 = input.UserInputValues();
                    Console.WriteLine("Svaret blir: \n" + opObj.Mul(num1, num2));
                    break;
                case "xyzzy":
                    Console.WriteLine("Nothing happens");
                    Choice1();
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Fel inmatning, var god försök igen");
                    Choice1();
                    break;
            }
        }
        /// <summary>
        /// <see cref="Choice2"> Användaren får välja vilken enhet som skall omvandlas följt utav antal grader.</see>
        /// </summary>
        public void Choice2()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            //Två instanser för att nytja metoder i "Calculations" & "UserInputs"
            Temperature temp = new Temperature();
            Input input = new();

            Console.WriteLine("Vad vill du omvandla? \n");
            Console.WriteLine("c för Celsius, f för Fahrenheit");

            //Nyttjar metoden  i "UserInputs" för att läsa in användarens val i switchen
            switch (choiceOption.UserInputChoice())
            {
                case "c":
                    Console.WriteLine("Skriv in talet du vill omvandla");
                    decimal tempNum1 = input.UserInputValues();
                    Console.WriteLine(temp.CtoF(tempNum1) + " Grader fahrenheit");
                    break;
                case "f":
                    Console.WriteLine("Skriv in talet du vill omvandla");
                    decimal tempNum2 = input.UserInputValues();
                    Console.WriteLine(temp.FtoC(tempNum2) + " Grader celcius");
                    break;
                case "xyzzy":
                    Console.WriteLine("Nothing happens");
                    Choice2();
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Fel inmatning, var god försök igen");
                    Choice2();
                    break;
            }
        }
    }
}
