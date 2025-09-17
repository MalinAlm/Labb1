
using System.Numerics;

static void FindNumbersInString(string userInput)
{
  
    BigInteger totalMatchedNumbersSum = 0;

    List<string> matchedNumbers = new List<string>();

    for (int startIndex = 0; startIndex < userInput.Length; startIndex++)
    {

        int endIndex = userInput.IndexOf(userInput[startIndex], startIndex + 1);
        bool containsLetterOrSign = false;
        string numberMatch = "";

        if (endIndex == -1) continue;

        for (int isDigitCheckIndex = startIndex; isDigitCheckIndex <= endIndex; isDigitCheckIndex++)
        {
            
            if (!char.IsDigit(userInput[isDigitCheckIndex]))
            {
                containsLetterOrSign = true;
                break;
            }
        }

        if (containsLetterOrSign) continue;

        for (int matchIndex = startIndex; matchIndex <= endIndex; matchIndex++)
        {
            numberMatch += userInput[matchIndex];
        }

        matchedNumbers.Add(numberMatch);

        for (int digitIndex = 0; digitIndex < userInput.Length; digitIndex++)
        {

            if (digitIndex >= startIndex && digitIndex <= endIndex)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.White;
            }

            Console.Write(userInput[digitIndex]);
        }

        Console.WriteLine();
    }

    Console.ResetColor();

    Console.WriteLine("\nSumman av alla matchade tal:\n");

    foreach (var numberMatch in matchedNumbers)
    {
        if (BigInteger.TryParse(numberMatch, out BigInteger parsedNumber))
        {
            totalMatchedNumbersSum += parsedNumber;
        }
    }

    Console.WriteLine(totalMatchedNumbersSum);
}

Console.Write("Skriv in en sträng bestående av mestadels siffror och någon/några bokstäver: ");

FindNumbersInString(Console.ReadLine());
