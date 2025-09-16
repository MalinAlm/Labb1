
/*
 LABB 1
 Hitta tal i sträng med tecken
 
- spara siffermatchningar i lista
- addera ihop alla tal och skriv ut totalen

 */


Console.WriteLine("Skriv in en sträng bestående av mestadels siffror och något/några bokstäver:");
string userInput = Console.ReadLine();

for (int number = 0; number < userInput.Length; number++)
{

    int stopIndex = userInput.IndexOf(userInput[number], number + 1);
    bool isLetterInMatch = false;

    if (stopIndex == -1) continue;

    for (int i = number; i <= stopIndex; i++)
    {
        if (char.IsLetter(userInput[i]))
        {
            isLetterInMatch = true;
            break;
        }
    }

    if (isLetterInMatch) continue;

    for (int i = 0; i < userInput.Length; i++)
    {

        if (i >= number && i <= stopIndex)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.White;
        }
        Console.Write(userInput[i]);
    }

    Console.WriteLine();
}

Console.ResetColor();

