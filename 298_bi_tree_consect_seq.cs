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
    public int LongestConsecutive(TreeNode root) {
        return dfs(root, null, 0);
    }
    
    public int dfs(TreeNode p, TreeNode parent, int length){
        if (p == null){
            return length;
        }
        
        if (parent != null && parent.val + 1 == p.val ){
            length += 1;
        }
        else {
            length = 1;
        }
        
        return Math.Max(
            length,
            Math.Max(
                dfs(p.left, p, length),
                dfs(p.right, p, length)
            )
        );
    }
}
