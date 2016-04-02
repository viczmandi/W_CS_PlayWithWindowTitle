using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PlayWithWindowTitle
{
    class Program
    {
        const int maxProgressBarLength = 28;
        const string progressBarElement = "-";
        const string codecool = "CODECOOL";

        static void Main(string[] args)
        {
            Console.WriteLine("Look at the title! How awesome is that?!");

            var title = "";

            do
            {
                title = GenerateTitle(title);
                Console.Title = title;
                Thread.Sleep(100);
            } while (true);
        }

        private static string GenerateTitle(string currentTitle)
        {
            int textStart = 11;
            int textEnd = 18;

            if (currentTitle.Length < textStart || currentTitle.Length > textEnd)
            {
                currentTitle += progressBarElement;
            }
            else
            {
                currentTitle += codecool[currentTitle.Length - textStart];
            }

            if (currentTitle.Length > maxProgressBarLength)
            {
                currentTitle = progressBarElement;
            }

            return currentTitle;
        }
    }

}
