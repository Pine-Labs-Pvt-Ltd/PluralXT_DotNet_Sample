using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RapidPayIntegration
{
    public class VPCStringComparer : IComparer<String>
    {
        /// <summary>
        /// Compare method using Ordinal comparison
        /// </summary>
        /// <param name="a">The first string in the comparison.</param>
        /// <param name="b">The second string in the comparison.</param>
        /// <returns>An int containing the result of the comparison.</returns>
        public int Compare(String a, String b)
        {
            try
            {
                // Return if we are comparing the same object or one of the 
                // objects is null, since we don't need to go any further.
                if (a == b) return 0;
                if (a == null) return -1;
                if (b == null) return 1;

                // Ensure we have string to compare
                string sa = a as string;
                string sb = b as string;

                // Get the CompareInfo object to use for comparing
                System.Globalization.CompareInfo myComparer = System.Globalization.CompareInfo.GetCompareInfo("en-US");
                if (sa != null && sb != null)
                {
                    // Compare using an Ordinal Comparison.
                    return myComparer.Compare(sa, sb, System.Globalization.CompareOptions.Ordinal);
                }
                else
                {
                    return -3;
                }
                // throw new ArgumentException("a and b should be strings.");
            }

            catch (Exception ex)
            {
               

                return -2;
            }
        }
    }

}
