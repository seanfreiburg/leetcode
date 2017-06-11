/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Solution {
    public bool IsBalanced(TreeNode root) {
        return getHeight(root) != -2;
    }
    
    public int getHeight(TreeNode root){
        if (root == null){
            return 1;
        }
        
        var left = getHeight(root.left);
        var right = getHeight(root.right);
        
        if (left == -2 || right == -2 || Math.Abs(left - right) > 1){
            return -2;
        }
        else {
            return 1 + Math.Max(left, right);
        }
        
    }
}
