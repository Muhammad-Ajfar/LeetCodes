using System;
using System.Collections.Generic;

public class Solution
{
    public long CountOfSubstrings(string word, int k)
    {
        long F(int k)
        {
            long ans = 0;
            int l = 0, x = 0;
            var cnt = new Dictionary<char, int>();
            
            bool IsVowel(char c) => "aeiou".Contains(c);

            foreach (char c in word)
            {
                if (IsVowel(c))
                {
                    if (!cnt.ContainsKey(c))
                        cnt[c] = 0;
                    cnt[c]++;
                }
                else
                {
                    x++;
                }

                while (x >= k && cnt.Count == 5)
                {
                    char d = word[l++];
                    if (IsVowel(d))
                    {
                        if (--cnt[d] == 0)
                            cnt.Remove(d);
                    }
                    else
                    {
                        x--;
                    }
                }
                ans += l;
            }
            return ans;
        }

        return F(k) - F(k + 1);
    }
}
