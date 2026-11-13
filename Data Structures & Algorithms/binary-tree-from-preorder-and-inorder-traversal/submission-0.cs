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


public class Solution
{
    private Dictionary<int, int> inorderMap;
    private int preorderIndex;

    public TreeNode BuildTree(int[] preorder, int[] inorder)
    {
        inorderMap = new Dictionary<int, int>();
        preorderIndex = 0;

        for (int i = 0; i < inorder.Length; i++)
        {
            inorderMap[inorder[i]] = i;
        }

        return ConstructTree(preorder, 0, inorder.Length - 1);
    }

    private TreeNode ConstructTree(int[] preorder, int left, int right)
    {
        if (left > right)
            return null;

        int rootValue = preorder[preorderIndex++];
        TreeNode root = new TreeNode(rootValue);

        int mid = inorderMap[rootValue];

        root.left = ConstructTree(preorder, left, mid - 1);
        root.right = ConstructTree(preorder, mid + 1, right);

        return root;
    }
}

