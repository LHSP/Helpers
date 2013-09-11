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
        /// <returns></returns>
        public static int RightIndexOf(this string source, char value)
        {
            return source.IndexOf(value) + 1;
        }

        /// <summary>
        /// Reports the zero-based index of the first ocurrence of the specified string in this instance plus the length of it.
        /// </summary>
        /// <param name="value">The string to seek.</param>
        /// <returns></returns>
        public static int RightIndexOf(this string source, string value)
        {
            return source.IndexOf(value) + value.Length;
        }

        /// <summary>
        /// Returns the number of ocurrences of the specified Unicode character in this string.
        /// </summary>
        /// <param name="value">A Unicode character to count ocurrences.</param>
        /// <returns></returns>
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
        /// <returns></returns>
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
    }
}
