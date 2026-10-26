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
    private int maxSum;
    public int MaxPathSum(TreeNode root) {
     maxSum = int.MinValue;
     MaxGain(root);
     return maxSum;
    }

    private int MaxGain(TreeNode node){
        if(node == null)return 0;

        int left = Math.Max(0,MaxGain(node.left));
        int right = Math.Max(0, MaxGain(node.right));

        int currentSum = left + right + node.val;

        maxSum = Math.Max(maxSum,currentSum);
        return node.val + Math.Max(left,right);
    }
}
