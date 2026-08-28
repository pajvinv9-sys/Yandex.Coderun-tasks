using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coderun;

public static class Combinatorics
{
    public static long GetPascalTriangleNumber(int stringNum, int inStringNum)
    {
        long ans = 1;

        for (int k = 0; k < inStringNum; k++)
        {
            ans = ans * (stringNum - k) / (k + 1);
        }

        return ans;
    }
}