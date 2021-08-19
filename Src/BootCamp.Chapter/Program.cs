using System;
namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine(BalanceStats.FindHighestBalanceEver(PeoplesBalances.Balances));
            Console.WriteLine(BalanceStats.FindPersonWithBiggestLoss(PeoplesBalances.Balances));
            Console.WriteLine(BalanceStats.FindRichestPerson(PeoplesBalances.Balances));
            Console.WriteLine(BalanceStats.FindMostPoorPerson(PeoplesBalances.Balances));



            // Print each of the statistical output using Text Table with padding 3:
        }
    }
}
