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
    public int KthSmallest(TreeNode root, int k) {
        List<int> vals = new List<int>();
        inOrderFill(root, vals);
        return vals[k-1];
    }
    
    private void inOrderFill(TreeNode root, List<int> vals){
        if (root == null){
            return;
        }
        
        inOrderFill(root.left, vals);
        vals.Add(root.val);
        inOrderFill(root.right, vals);
    }
}
