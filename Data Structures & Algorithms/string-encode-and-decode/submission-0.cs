public class Solution {

    public string Encode(IList<string> strs) {
        StringBuilder result = new StringBuilder();

        foreach(string s in strs){
            result.Append(s.Length);
            result.Append("#");
            result.Append(s);
        }
        return result.ToString();
        
    }

    public List<string> Decode(string s) {

        List<string> result = new List<string>();
        if(string.IsNullOrEmpty(s)){
            return result;
        }
        int i = 0;
        
        while(i < s.Length){
            int j = s.IndexOf("#", i);
            int length = int.Parse(s.Substring(i, j- i));
            string word = s.Substring(j+1,length);
            result.Add(word);

            i = j + 1 + length;
        }
        return result;

   }
}
