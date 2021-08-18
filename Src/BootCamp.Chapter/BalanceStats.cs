using System;
using System.Globalization;

namespace BootCamp.Chapter
{
    public static class BalanceStats
    {
        /// <summary>
        /// Return name and balance(current) of person who had the biggest historic balance.
        /// </summary>
        /// 
        public static string FindHighestBalanceEver(string[] peopleAndBalances)
        {
            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;
            int highestBalance = 0;
            string name = "";

            foreach (var person in peopleAndBalances)
            {
                string[] balances = person.Split(',');
               
                foreach (string balance in balances)
                {
                    Int32.TryParse(balance, out int currentBalance);
                    if (currentBalance == highestBalance || name == "")
                    {
                        //highestBalance = currentBalance;
                        name = balances[0];
                    }
                    else if (currentBalance == highestBalance || name != "")
                    {
                        //highestBalance = currentBalance;
                        name = $"{name} and {balances[0]}";
                    }
                    else if (currentBalance > highestBalance)
                    {
                        highestBalance = currentBalance;
                        name = balances[0];
                    }
                }
            }
            return $"{name} had the most money ever. {highestBalance.ToString("C0")}.";
        }

        /// <summary>
        /// Return name and loss of a person with a biggest loss (balance change negative).
        /// </summary>
        public static string FindPersonWithBiggestLoss(string[] peopleAndBalances)
        {
            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;
            int biggestLoss = 0;
            string name = "";

            foreach (var person in peopleAndBalances)
            {
                string[] balances = person.Split(',');
                int length = balances.Length;
                int currentBalance = 0;
                int previousBalance = 0;

                for (int i = 1; i < length; i++)
                {
                    int loss = 0;
                    Int32.TryParse(balances[i], out currentBalance);

                    loss = previousBalance - currentBalance;
                    
                    if (loss > biggestLoss)
                    {
                        biggestLoss = loss;
                        name = balances[0];
                    }

                }

            }

            return $"{name}  -  {biggestLoss.ToString()}";
        }

        /// <summary>
        /// Return name and current money of the richest person.
        /// </summary>
        public static string FindRichestPerson(string[] peopleAndBalances)
        {
            return "";
        }

        /// <summary>
        /// Return name and current money of the most poor person.
        /// </summary>
        public static string FindMostPoorPerson(string[] peopleAndBalances)
        {
            return "";
        }
    }
}
