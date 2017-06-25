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
    public bool IsSameTree(TreeNode p, TreeNode q) {
        if (p == null && q == null){
            return true;
        }
        else if ((p == null && q != null) || (p != null && q == null)){
            return false;
        }
        else if (p.val != q.val){
            return false;
        }
        else {
            return IsSameTree(p.right, q.right) && IsSameTree(p.left, q.left);
        }
    }
}
