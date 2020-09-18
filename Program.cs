using System;

namespace Labb1
{
    class Program
    {
        static void Main(string[] args)
        {

            long sum = 0;
            string textSum = "";
            Console.WriteLine("Mata in en sträng");
            string bigString = Console.ReadLine();
            if (string.IsNullOrEmpty(bigString) || string.IsNullOrWhiteSpace(bigString))
            {
                Console.WriteLine("Felaktig inmatning");
                return;
            }
            for (int numeral = 0; numeral < bigString.Length; numeral++)

            {
                if (Char.IsDigit(bigString[numeral]))

                {
                    for (int nextnumeral = numeral + 1; nextnumeral < bigString.Length; nextnumeral++)
                    {
                        if (!Char.IsDigit(bigString[nextnumeral]))
                        {
                            break;
                        }

                        if (bigString[numeral] == bigString[nextnumeral])
                        {
                            for (int search = 0; search < bigString.Length; search++)
                            {

                                if (search >= numeral && search <= nextnumeral)
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                                    Console.Write(bigString[search]);
                                    textSum = textSum + bigString[search];
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.Write(bigString[search]);
                                    long.TryParse(textSum, out long highlightSum);
                                    sum = sum + highlightSum;
                                    textSum = "";
                                }


                            }
                            Console.WriteLine();
                            break;
                        }
                    }
                }
            }
            long.TryParse(textSum, out long lastSum);
            sum = sum + lastSum;
            Console.Write($"Summan av din sträng som markerats är: {sum}");
            Console.ReadKey(true);
        }
    }
}
