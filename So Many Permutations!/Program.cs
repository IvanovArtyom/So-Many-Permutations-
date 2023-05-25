using System.Collections.Generic;
using System.Linq;

class Permutations
{
    public static void Main()
    {
        // Test
        var t = SinglePermutations("abc");
        // ...should return ["abc","acb","bac","bca","cab","cba"]
    }

    public static List<string> SinglePermutations(string s)
    {
        List<string> permutation = new();

        if (s.Length == 1)
            permutation.Add(s);

        else
        {
            for (int i = 0; i < s.Length; i++)
                permutation.AddRange(SinglePermutations(s.Remove(i, 1)).Select(str => s[i] + str));
        }

        return permutation.Distinct().ToList();
    }
}
