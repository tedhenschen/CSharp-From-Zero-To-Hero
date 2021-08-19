namespace BootCamp.Chapter
{
    /// <summary>
    /// Part 2.
    /// </summary>
    public static class PeoplesBalances
    {
        /// <summary>
        /// Here are people and their balances.
        /// One line = one person.
        /// Line is made by name (no spaces), follow by balances separated by comma (",").
        /// Example: "Gily, 1, 0". Means that currently Gily has 0, which dropped from initial 1.
        /// </summary>
        /// 

        public static string[] Null => null;

        public static string[] Balances => new[]
        {
            //"Tom, 1, 3, -1", "Gillie, 2, 3, 1", "Thor, 1000, 1001, 1002"
            //"Tom, 1", "Gillie, 1", "Agnes, 1" 
            "tom, 15.5, 200, 500, 600, 200, 500, 1000",
            "katherine, 85, 0, -500, 0, 500, 10000, 1500.99",
            "bill, 99999, , 99970, 99900",
            "catie, 0, 500, 990, 1300"
        };

    }
}
