using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestingExample
{
    public static class StringMethods
    {
        public static string DoubleString(string source)
        {
                 return source + source;
        }

        public static string CutHeadString(string source)
        {
            if (!string.IsNullOrWhiteSpace(source) && source.Length > 2)
                return source.Remove(0, 2);
            else return source;
        }

        public static string CutTailString(string source)
        {
            {
                if (!string.IsNullOrWhiteSpace(source) && source.Length > 2)
                    return source.Remove(source.Length - 2);
                else return source;
            }
        }

        public static string MixStrings(string source1, string source2)
        {
            if (!string.IsNullOrWhiteSpace(source1) && !string.IsNullOrWhiteSpace(source2))
            {
                int range = source1.Length < source2.Length ? source1.Length : source2.Length;
                string temp;
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < range; i++)
                {
                    builder.Append(source1[i]);
                    builder.Append(source2[i]);
                }
                if (source1.Length > range)
                {
                    temp = source1.Remove(0, range);
                    builder.Insert(range * 2, temp);

                }
                else if (source2.Length > range)
                {
                    temp = source2.Remove(0, range);
                    builder.Insert(range * 2, temp);

                }
                return builder.ToString();
            }
            else
                return source1 + source2;
        }
    }
}
