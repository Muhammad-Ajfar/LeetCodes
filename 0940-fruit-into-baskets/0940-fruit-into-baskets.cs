public class Solution {
    public int TotalFruit(int[] fruits) {
        var hashMap = new Dictionary<int, int>{{fruits[0], 1}};
        int res = 0;
        int left = 0;
        int f1= fruits[0];
        int f2= -1;

        for(int i = 1; i< fruits.Length; i++) {
            int fruit = fruits[i];
            if(hashMap.Count < 2 && fruit != f1) {
                hashMap[fruit] = 1;
                f2 = fruit;
            }
            else if(fruit == f1 || fruit == f2) {
                hashMap[fruit]++;
            }
            else {
                res = Math.Max(res, i - left);

                int invalid;
                if(f1 == fruits[i - 1]) {
                    invalid = f2;
                    f2 = fruit;
                } 
                else {
                    invalid = f1;
                    f1 = fruit;
                }

                hashMap[fruit] = 1;

                while(hashMap[invalid] > 0) {
                    hashMap[fruits[left]]--;
                    left++;
                }
            }
        }

        res = Math.Max(res, fruits.Length - left);
        return res;
    }
}
