using Kalkyl;

//Färgschema för att få det att se ut som windows-StoneAge
Console.BackgroundColor = ConsoleColor.DarkBlue;
Console.ForegroundColor = ConsoleColor.Cyan;
/// <summary>
/// Startar programmet och gör en instans utav biblioteket "ChoiceOptions"
/// Sätter användaren i en While-loop oh dirigerar in till Choice metoden
/// <see cref="ChoiceOptions"> Ny instans utav Classen</see>/>
/// </summary>
ChoiceOptions choice = new();

while (true)
{
        choice.Choice(); 
}

