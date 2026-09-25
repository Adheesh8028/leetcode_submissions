public class Solution {
    public bool hasDuplicate(int[] nums) {

      HashSet<int> repeated = new HashSet<int>();

      foreach(int num in nums){
        if(repeated.Contains(num)){
            return true;
        }
        repeated.Add(num);
      }
      return false;

    }
}