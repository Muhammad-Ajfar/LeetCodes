using System;
using System.Collections.Generic;

public class Solution {
    public int MaximumSum(int[] nums) {
        Dictionary<int, (int max1, int max2)> Map = new Dictionary<int, (int, int)>();

        foreach (int number in nums) {
            int sum = GetDigitSum(number);

            if (Map.ContainsKey(sum)) {
                var (max1, max2) = Map[sum];

                if (number > max1) {
                    max2 = max1;
                    max1 = number;
                } else if (number > max2) {
                    max2 = number;
                }

                Map[sum] = (max1, max2);
            } else {
                Map[sum] = (number, -1);
            }
        }

        int res = -1;
        foreach (var value in Map.Values) {
            if (value.max2 != -1) {
                res = Math.Max(res, value.max1 + value.max2);
            }
        }

        return res;
    }

    private int GetDigitSum(int num) {
        int sum = 0;
        while (num > 0) {
            sum += num % 10;
            num /= 10;
        }
        return sum;
    }
}
