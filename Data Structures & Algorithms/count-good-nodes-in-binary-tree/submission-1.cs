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

public class Solution {
    public int GoodNodes(TreeNode root) {
        return CountGoodNodes(root, root.val);
    }
    private int CountGoodNodes(TreeNode node, int maxVal){
        if(node == null)return 0;
         int count = 0;
        if(node.val >= maxVal){
            count = 1;
            maxVal = node.val;
        }

       count += CountGoodNodes(node.left, maxVal);
       count += CountGoodNodes(node.right, maxVal);

       return count;
    }
}
