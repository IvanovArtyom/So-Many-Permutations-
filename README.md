## Description:

In this kata, your task is to create all permutations of a non-empty input string and remove duplicates, if present.

Create as many "shufflings" as you can!

**Examples:**
```C++
With input 'a':
Your function should return ['a']

With input 'ab':
Your function should return ['ab', 'ba']

With input 'abc':
Your function should return ['abc','acb','bac','bca','cab','cba']

With input 'aabb':
Your function should return ['aabb', 'abab', 'abba', 'baab', 'baba', 'bbaa']
```
**Note:** The order of the permutations doesn't matter.

Good luck!
### My solution
```C#
using System.Collections.Generic;
using System.Linq;

class Permutations
{
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
```
