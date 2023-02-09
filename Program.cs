using System;
using System.Threading;

namespace Piano
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Нажмите F1, F2, F3 и т.д. для переключения между октавами.");

            int[] firstOctave = new int[] { 200, 300, 400 };
            int[] secondOctave = new int[] { 800, 900, 1000 };
            int[] thirdOctave = new int[] { 1600, 1700, 1800 };
            int[] currentOctave = firstOctave;

            while (true)
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey();
                switch (keyInfo.Key)
                {
                    case ConsoleKey.F1:
                        currentOctave = firstOctave;
                        break;
                    case ConsoleKey.F2:
                        currentOctave = secondOctave;
                        break;
                    case ConsoleKey.F3:
                        currentOctave = thirdOctave;
                        break;
                    default:
                        int index = Array.IndexOf(currentOctave, keyInfo.KeyChar);
                        if (index >= 0)
                        {
                            PlaySound(currentOctave[index]);
                        }
                        break;
                }
            }
        }

        static void PlaySound(int frequency)
        {
            Console.Beep(frequency, 500);
        }
    }
}