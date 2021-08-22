using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;



namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = "C:\\Users\\tedhe\\source\\repos\\CSharp-From-Zero-To-Hero\\Src\\BootCamp.Chapter\\Input\\";
            string corruptedFile = filePath + "balances.corrupted";
            string cleanFile = filePath + "balances.test";

            FileCleaner.Clean(corruptedFile, cleanFile);

            string[] cleanData = File.ReadAllLines(cleanFile);

            Console.WriteLine(BalanceStats.FindHighestBalanceEver(cleanData));
            Console.WriteLine(BalanceStats.FindMostPoorPerson(cleanData));
            Console.WriteLine(BalanceStats.FindPersonWithBiggestLoss(cleanData));
            Console.WriteLine(BalanceStats.FindRichestPerson(cleanData));



        }
    }
}
