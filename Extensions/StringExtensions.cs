using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace coderun;

public static class StringExtensions
{
    public static List<int> ConvertFromStringToListOfInt(this string s)
        => [.. s.Split().Select(i => int.Parse(i))];

    public static string Reverse(this string s)
    {
        StringBuilder stringBuilder = new();

        for (int l = s.Length - 1; l >= 0; l--)
        {
            stringBuilder.Append(s[l]);
        }
        return stringBuilder.ToString();
    }   
}
