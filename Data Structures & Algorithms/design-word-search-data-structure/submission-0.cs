public class WordDictionary {

    public class TrieNode{
        public TrieNode[] children = new TrieNode[26];
        public bool isSearchWord = false;
    }
    private readonly TrieNode root;

    public WordDictionary() {
        root = new TrieNode();
    }
    
    public void AddWord(string word) {
        TrieNode current = root;
        foreach(char c in word){
            int index = c - 'a';
            if(current.children[index] == null){
            current.children[index] = new TrieNode();
            }
            current = current.children[index];
        }
        current.isSearchWord = true;
        
    }
    
    public bool Search(string word) {
        return SearchWordHelper(root,word,0);
        
    }
    public bool SearchWordHelper(TrieNode node, string word,int index){
        if(node == null){
            return false;
        }
        if(index == word.Length){
            return node.isSearchWord;
        }
        char c = word[index];

        if(c == '.'){
            foreach(TrieNode child in node.children){
                if(child != null && SearchWordHelper(child,word,index+1)){
                    return true;
                }
            }
            return false;
        }
        else{
            int charIndex = c -'a';
            return SearchWordHelper(node.children[charIndex],word,index+1);
        }
    }
}
