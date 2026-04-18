using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Synthesis;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SpeechSynthesizer speak = new SpeechSynthesizer();

            Console.Write("Enter text: ");
            string text = Console.ReadLine();

            speak.Speak(text);
        }
    }
}
