public class Solution {
    public bool IsPalindrome(string s) {

      string filteredstring = new string(s.Where(char.IsLetterOrDigit).ToArray());
        int left = 0;
        int right = filteredstring.Length - 1;

        while(left < right)
        {
            if(char.ToLower(filteredstring[left]) != char.ToLower(filteredstring[right])){
                return false;
            }
            left++;
            right--;
        }
        return true;
    }
}
