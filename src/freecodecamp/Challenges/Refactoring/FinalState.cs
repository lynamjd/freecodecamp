public class FinalState
{
    /// <summary>
    ///     Reverses a string, counts the number of 
    ///     times a particular letter appears and prints the 
    ///     revered string and count to the console.
    /// </summary>
    public static void Run()
    {        
        string message = "The quick brown fox jumps over the lazy dog.";

        char[] messageLetters = message.ToCharArray();
        Array.Reverse(messageLetters);

        int letterCount = 0;
        foreach (char letter in messageLetters) 
        { 
            if (letter == 'o') 
            { 
                letterCount++; 
            } 
        }

        string messageReversed = new String(messageLetters);

        Console.WriteLine(messageReversed);
        Console.WriteLine($"'o' appears {letterCount} times.");
    }
}