using System;

namespace ABCheckCodeByte
{
    class Program
    {
        static void Main(string[] args)
        {
            string testString = "lane borrowed";
            bool abCheckResult = AbCheck(testString);
            Console.WriteLine(abCheckResult);
        }
        /**
         * Have the function abCheck(str) take the str parameter being passed and return
         * the string true if the characters a and b are separated by exactly 3 places
         * anywhere in the string at least once (ie. "lane borrowed" would result in
         * true because there is exactly three characters between a and b). Otherwise
         * return the string false.
         */
        public static bool AbCheck(string strTest)
        {
            char[] searchChars = { 'a', 'b' };
            int space = 3;

            if (strTest.Length < space + 2)
            {
                return false;
            }

            for (int x = 0; x < strTest.Length - space - 1; x++)
            {
                if (strTest[x] == searchChars[0])
                {
                    if (strTest[x + space + 1] == searchChars[1])
                    {
                        return true;
                    }
                }

                if (strTest[x] == searchChars[1])
                {
                    if (strTest[x + space + 1] == searchChars[0])
                    {
                        return true;
                    }
                }
            }

            return false;
        }
    }
}
