using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helpers
{
    public static class StringHelper
    {
        /// <summary>
        /// Reports the zero-based index of the first ocurrence of the specified Unicode character in this string plus one.
        /// </summary>
        /// <param name="value">A Unicode character to seek.</param>
        /// <returns>The zero-based index of the first ocurrence of the specified Unicode character in this string plus one.</returns>
        public static int RightIndexOf(this string source, char value)
        {
            return source.IndexOf(value) + 1;
        }

        /// <summary>
        /// Reports the zero-based index of the first ocurrence of the specified string in this instance plus the length of it.
        /// </summary>
        /// <param name="value">The string to seek.</param>
        /// <returns>The zero-based index of the first ocurrence of the specified string in this instance plus the length of it.</returns>
        public static int RightIndexOf(this string source, string value)
        {
            return source.IndexOf(value) + value.Length;
        }

        /// <summary>
        /// Returns the number of ocurrences of the specified Unicode character in this string.
        /// </summary>
        /// <param name="value">A Unicode character to count ocurrences.</param>
        /// <returns>The number of ocurrences of the specified Unicode character in this string.</returns>
        public static int CountOcurrences(this string source, char value)
        {
            int ocurrences = 0;
            string notSearched = source;

            while (notSearched.Contains(value))
            {
                ocurrences++;
                notSearched = notSearched.Substring(notSearched.RightIndexOf(value));
            }

            return ocurrences;
        }

        /// <summary>
        /// Returns the number of ocurrences of the specified string in this string.
        /// </summary>
        /// <param name="value">The string to count ocurrences.</param>
        /// <returns>The number of ocurrences of the specified string in this string.</returns>
        public static int CountOcurrences(this string source, string value)
        {
            int ocurrences = 0;
            string notSearched = source;

            while (notSearched.Contains(value))
            {
                ocurrences++;
                notSearched = notSearched.Substring(notSearched.RightIndexOf(value));
            }

            return ocurrences;
        }

        private static char[] separators = new char[] { ' ', ',', '.', ';', ':', '?', '!', '-', '_', '(', ')', '[', ']', '{', '}', '\n', '\r', '\t' };
        /// <summary>
        /// Returns the number of words from the string.
        /// </summary>
        /// <param name="source">The source string.</param>
        /// <returns>The number of words on the string.</returns>
        public static int CountWords(this string source)
        {
            return source.Split(separators).Length;
        }
    }
}
