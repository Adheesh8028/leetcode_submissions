public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {

      var groups = new Dictionary<string, List<string>>();

      foreach(string s in strs)
      {
        char[] chars = s.ToCharArray();
        Array.Sort(chars);
        string key = new string(chars);
        if(!groups.ContainsKey(key)){
            groups[key] = new List<string>();
        }
        groups[key].Add(s);

      }  
      return groups.Values
        .Select(group => (List<string>)group)
        .ToList();
    }
}
