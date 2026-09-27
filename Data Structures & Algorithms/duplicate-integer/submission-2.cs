public class Solution {
    public bool hasDuplicate(int[] nums) {

    HashSet<int> repeated = new HashSet<int>();

    foreach(int n in nums){
      if(repeated.Contains(n)){
        return true;
      }
      repeated.Add(n);
    }
    return false;

    }
}