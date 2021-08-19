using System;
using System.Collections.Generic;
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
            double highestBalance = 0;
            string name = "";
            string message = "";
            List<string> names = new List<string>();

            if (peopleAndBalances == null || peopleAndBalances.Length == 0)
            {
                message = "N/A.";
            }
            else
            { 
                foreach (var person in peopleAndBalances)
                {
                    string[] balances = person.Split(',');

                    foreach (string balance in balances)
                    {
                        if (double.TryParse(balance, out double currentBalance))
                        {

                            if (currentBalance == highestBalance)
                            {
                                names.Add(balances[0]);
                            }
                            else if (currentBalance > highestBalance)
                            {
                                names.Clear();
                                names.Add(balances[0]);
                                highestBalance = currentBalance;

                            }
                        }
                    }
                }

                if (names.Count <= 1)
                {
                    name = names[0];
                }
                else if (names.Count == 2)
                {
                    name = $"{names[0]} and {names[1]}";
                }
                else
                {
                    for (int i = 0; i < names.Count; i++)
                    {
                        if (i == names.Count - 1)
                        {
                            name = $"{name} and {names[i]}";
                        }
                        else if (i == 0)
                        {
                            name = names[i];
                        }
                        else
                        {
                            name = $"{name}, {names[i]}";
                        }
                    }
                }

                message = $"{name} had the most money ever. {highestBalance.ToString("C0")}.";
            }
            return message;
        }

        /// <summary>
        /// Return name and loss of a person with a biggest loss (balance change negative).
        /// </summary>
        public static string FindPersonWithBiggestLoss(string[] peopleAndBalances)
        {
            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;
            double biggestLoss = 0;
            string name = "";
            string message = "";
            List<string> names = new List<string>();

            if (peopleAndBalances == null || peopleAndBalances.Length == 0)
            {
                message = "N/A.";
            }
            else
            {
                foreach (var person in peopleAndBalances)
                {
                    string[] balances = person.Split(',');
                    double previousBalance = 0;

                    foreach (string balance in balances)
                    {
                        if (double.TryParse(balance, out double currentBalance))
                        {
                            double currentLoss = (currentBalance - previousBalance);
                            if (currentLoss == biggestLoss)
                            {
                                names.Add(balances[0]);
                            }
                            else if (currentLoss < biggestLoss)
                            {
                                names.Clear();
                                names.Add(balances[0]);
                                biggestLoss = currentLoss;

                            }
                            previousBalance = currentBalance;
                        }
                       
                    }
                }
                if (names.Count != 0 && biggestLoss != 0)
                {

                    if (names.Count == 1)
                    {
                        name = names[0];
                    }
                    else if (names.Count == 2)
                    {
                        name = $"{names[0]} and {names[1]}";
                    }
                    else
                    {
                        for (int i = 0; i < names.Count; i++)
                        {
                            if (i == names.Count - 1)
                            {
                                name = $"{name} and {names[i]}";
                            }
                            else if (i == 0)
                            {
                                name = names[i];
                            }
                            else
                            {
                                name = $"{name}, {names[i]}";
                            }
                        }
                    }
                    biggestLoss = biggestLoss * -1;
                    message = $"{name} lost the most money. -{biggestLoss.ToString("C0")}.";
                }
                else
                {
                    message = "N/A.";
                }
            }

            return message;
        }

        /// <summary>
        /// Return name and current money of the richest person.
        /// </summary>
        public static string FindRichestPerson(string[] peopleAndBalances)
        {
            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;
            double largestEndingBalance = 0;
            string name = "";
            string message = "";
            List<string> names = new List<string>();

            if (peopleAndBalances == null || peopleAndBalances.Length == 0)
            {
                message = "N/A.";
            }
            else
            {
                foreach (var person in peopleAndBalances)
                {
                    string[] balances = person.Split(',');
                    int length = balances.Length-1;

                    if (double.TryParse(balances[length], out double EndingBalance))
                    {
                        //double currentLoss = (currentBalance - previousBalance);
                        if (EndingBalance == largestEndingBalance)
                        {
                            names.Add(balances[0]);
                        }
                        else if (EndingBalance > largestEndingBalance)
                        {
                            names.Clear();
                            names.Add(balances[0]);
                            largestEndingBalance = EndingBalance;

                        }
                    }
                }
                if (names.Count != 0)
                {

                    if (names.Count == 1)
                    {
                        name = names[0] + " is the richest person";
                    }
                    else if (names.Count == 2)
                    {
                        name = $"{names[0]} and {names[1]} are  the richest people";
                    }
                    else
                    {
                        for (int i = 0; i < names.Count; i++)
                        {
                            if (i == names.Count - 1)
                            {
                                name = $"{name} and {names[i]}";
                            }
                            else if (i == 0)
                            {
                                name = names[i];
                            }
                            else
                            {
                                name = $"{name}, {names[i]}";
                            }
                        }
                        name = name + " are the richest people";
                    }
                    //largestEndingBalance = largestEndingBalance * -1;
                    message = $"{name}. {largestEndingBalance.ToString("C0")}.";
                }
                else
                {
                    message = "N/A.";
                }
            }

            return message;

        }

        /// <summary>
        /// Return name and current money of the most poor person.
        /// </summary>
        public static string FindMostPoorPerson(string[] peopleAndBalances)
        {
            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;
            double smallestEndingBalance = 9007199254740992;
            string name = "";
            string message = "";
            List<string> names = new List<string>();

            if (peopleAndBalances == null || peopleAndBalances.Length == 0)
            {
                message = "N/A.";
            }
            else
            {
                foreach (var person in peopleAndBalances)
                {
                    string[] balances = person.Split(',');
                    int length = balances.Length - 1;

                    if (double.TryParse(balances[length], out double EndingBalance))
                    {
                        //double currentLoss = (currentBalance - previousBalance);
                        if (EndingBalance == smallestEndingBalance)
                        {
                            names.Add(balances[0]);
                        }
                        else if (EndingBalance < smallestEndingBalance)
                        {
                            names.Clear();
                            names.Add(balances[0]);
                            smallestEndingBalance = EndingBalance;

                        }
                    }
                }
                if (names.Count != 0)
                {

                    if (names.Count == 1)
                    {
                        name = names[0] + " has the least money";
                    }
                    else if (names.Count == 2)
                    {
                        name = $"{names[0]} and {names[1]} have the least money";
                    }
                    else
                    {
                        for (int i = 0; i < names.Count; i++)
                        {
                            if (i == names.Count - 1)
                            {
                                name = $"{name} and {names[i]}";
                            }
                            else if (i == 0)
                            {
                                name = names[i];
                            }
                            else
                            {
                                name = $"{name}, {names[i]}";
                            }
                        }
                        name = name + " have the least money";
                    }
                    //largestEndingBalance = largestEndingBalance * -1;
                    message = $"{name}. {smallestEndingBalance.ToString("C0")}.";
                }
                else
                {
                    message = "N/A.";
                }
            }

            return message;

        }
    }
}
