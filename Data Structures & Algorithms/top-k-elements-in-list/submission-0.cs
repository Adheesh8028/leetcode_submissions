public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        
        Dictionary<int,int> storevalue = new Dictionary<int,int>();

        for(int i = 0; i < nums.Length; i++){
          if(storevalue.ContainsKey(nums[i])){
            storevalue[nums[i]]++;
          }
          else{
            storevalue[nums[i]] = 1;
          }
        }
        return storevalue.OrderByDescending(x => x.Value).Take(k).Select(x => x.Key)
                .ToArray();
    }
}
