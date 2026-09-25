public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        
        if(s1.Length > s2.Length){
            return false;
        }
        int left = 0;
        int[] need = new int[26];
        int[] window = new int[26];

        foreach(char c in s1){
            need[c - 'a']++;
        }
        for(int right = 0; right < s2.Length; right++){
           window[s2[right] - 'a']++;
        
        if(right -left +1 > s1.Length){
            window[s2[left] - 'a']--;
            left++;
        }
        if(need.SequenceEqual(window)){
            return true;
        }
        }
        return false;
    }
}
