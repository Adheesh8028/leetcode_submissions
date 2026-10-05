public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {
       int left = 1;
       int right = piles.Max();

       while(left <= right){
        int k = left + (right - left)/2;
        long hours = 0;
        foreach(int pile in piles){
            hours += (pile + k - 1)/k;
        }
        if(hours <= h){
          right = k - 1;
        }
        else{
            left = k + 1;
        }
       }
       return left;
    }
}
