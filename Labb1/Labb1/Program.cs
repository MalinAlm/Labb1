
/*
 LABB 1
 Hitta tal i sträng med tecken
 
- spara siffermatchningar i lista
- addera ihop alla tal och skriv ut totalen

 */

static void FindNumbersInString(string userInput)
{
    List<string> numberMatches = new List<string>();

    for (int number = 0; number < userInput.Length; number++)
    {

        int stopIndex = userInput.IndexOf(userInput[number], number + 1);
        bool isLetterInMatch = false;
        string numberMatch = "";

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

        for (int i= number; i <= stopIndex; i++)
        {

            numberMatch += userInput[i];

        }

        numberMatches.Add(numberMatch);

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

    Console.WriteLine("\nSaved number Matches:\n");
    foreach (var numberMatch in numberMatches)
    {
        Console.WriteLine(numberMatch);
    }

}

Console.WriteLine("Skriv in en sträng bestående av mestadels siffror och något/några bokstäver:");

FindNumbersInString(Console.ReadLine());
