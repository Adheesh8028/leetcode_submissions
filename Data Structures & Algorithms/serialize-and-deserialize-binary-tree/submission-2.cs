/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */

public class Codec {

    // Encodes a tree to a single string.
    public string Serialize(TreeNode root) {
        List<string> values = new List<string>();
        SerializeHelper(root, values);
        return string.Join(",",values);
    }

    private void SerializeHelper(TreeNode node ,List<string> values){
        if(node == null){
            values.Add("#");
            return;
        }
        values.Add(node.val.ToString());

        SerializeHelper(node.left,values);
        SerializeHelper(node.right,values);
    }

    // Decodes your encoded data to tree.
    public TreeNode Deserialize(string data) {
        string[] values = data.Split(",");
        int index =0;

        return DeserializeHelper(values, ref index);
    }

    private TreeNode DeserializeHelper(string[] values, ref int index){
        if(index >= values.Length)
        return null;
        string value = values[index++];
        if(value == "#") return null;
        TreeNode node = new TreeNode(int.Parse(value));
         
        node.left = DeserializeHelper(values, ref index);
        node.right = DeserializeHelper(values, ref index);
        return node; 
    }
}
