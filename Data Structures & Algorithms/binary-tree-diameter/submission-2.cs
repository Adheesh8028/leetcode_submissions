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
    private int diameter = 0;
    public int DiameterOfBinaryTree(TreeNode root) {
        diameter = 0;
        Height(root);
        return diameter;
    }

    public int Height(TreeNode root){
        if(root == null)return 0;

        int leftHeight = Height(root.left);
        int rightHeight = Height(root.right);

        diameter = Math.Max(diameter, leftHeight+rightHeight);
        return 1 +Math.Max(leftHeight,rightHeight);

    }

}
