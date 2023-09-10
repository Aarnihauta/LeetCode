using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrueLeetCode.Emax;
public static class BitCounting
{
    public static int HammingWeight(int n)
    {
        int res = 0;
        while (n != 0)
        {
            res += n & 1;
            n = n >> 1;
        }
        return res;
    }
}
