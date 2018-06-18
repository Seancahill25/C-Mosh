using System;

namespace summerizingText
{
    class Program
    {
        static void Main(string[] args)
        {
            var sentence = "This is going to be a really really really really long text.";
            var summary = stringUtility.SummerizeText(sentence, 25);
            Console.WriteLine(summary);
        }
    }
}
