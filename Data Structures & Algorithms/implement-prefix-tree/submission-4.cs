public class PrefixTree {

    public class TrieNode {
    public Dictionary<char,TrieNode> children = new();
    public bool isEnd = false;
    }
    public readonly TrieNode  root;

    public  PrefixTree(){
        root = new TrieNode();
    }
    
    public void Insert(string word) {
        TrieNode current = root;
        foreach(char c in word){
            if(!current.children.ContainsKey(c)){
                current.children[c] = new TrieNode();
            }
            current = current.children[c];
        }
        current.isEnd = true;
    }
    
    public bool Search(string word) {
        TrieNode current = root;
        foreach(char c in word){
            if(!current.children.ContainsKey(c)){
                return false;
            }
            current = current.children[c];
        }
        return current.isEnd;
    }
    
    public bool StartsWith(string prefix) {
        TrieNode current = root;
        foreach(char c in prefix){
         if(!current.children.ContainsKey(c)){
            return false;
         }
         current = current.children[c];
        }
        return true;
    }
}
