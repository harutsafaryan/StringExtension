namespace Extension
{
    public static class StringExtension
    {
        /// <summary>
        /// Return space count for string
        /// </summary>
        /// <param name="source">Given string</param>
        /// <returns>Space count for given string</returns>
        public static int _SpaceCount(this string source)
        {
            int count = 0;
            for (int i = 0; i < source.Length; i++)
            {
                if (source[i] == ' ')
                {
                    count++;
                }
            }
            return count;
        }

        /// <summary>
        /// Return digit count for string
        /// </summary>
        /// <param name="source">Given string</param>
        /// <returns>Digit count for given string</returns>
        public static int _DigitCount(this string source)
        {
            int count = 0;
            for (int i = 0; i < source.Length; i++)
            {
                if (source[i] >= '0' && source[i] <= '9')
                {
                    count++;
                }
            }
            return count;
        }

        /// <summary>
        /// Return true if string contains given word
        /// </summary>
        /// <param name="source">Source string</param>
        /// <param name="word">Given string</param>
        /// <returns>return true if string contains given word</returns>
        public static bool _IsContainWord(this string source, string givenWord)
        {
            string temp = "";
            for (int i = 0; i < source.Length; i++)
            {
                if (source[i] != ' ')
                {
                    temp += source[i];
                }
                else if (temp == givenWord)
                {
                    return true;
                }
                else
                {
                    temp = "";
                }
            }
            if (temp == givenWord)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Return letter with maximum count in given string
        /// </summary>
        /// <param name="source">Source string</param>
        /// <returns>letter that contains the maximum in the given string</returns>
        public static char _LetterWithMaxCount(this string source)
        {
            char[] letters = new char[source.Length];
            int[] counts = new int[source.Length];

            int t = 0;
            for (int i = 0; i < source.Length; i++)
            {
                bool contain = false;
                for (int j = 0; j < letters.Length; j++)
                {
                    if (source[i] == letters[j])
                    {
                        counts[j]++;
                        contain = true;
                        break;
                    }
                }
                if (!contain)
                {
                    letters[t] = source[i];
                    t++;
                }
            }

            int max = 0;
            int index = 0;
            for (int j = 0; j < counts.Length; j++)
            {
                if (max < counts[j])
                {
                    max = counts[j];
                    index = j;
                }
            }

            return letters[index];
        }

        public static string _RemoveSpaces(this string source)
        {
            string result = "";

            for (int i = 0; i < source.Length; i++)
            {
                if (source[i] != ' ') 
                {
                    result = string.Concat(result, source[i]);
                }
            }

            return result;
        }
    }
}

