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
    public IList<int> RightSideView(TreeNode root) {
        List<int> path = new List<int>();
        RightSide(root,path, 0);
        return path;
    }
    
    public void RightSide(TreeNode root, List<int> path, int depth){
        if (root == null){
            return;
        }
        if (depth == path.Count){
            path.Add(root.val);
        }
        RightSide(root.right, path, depth + 1);
        RightSide(root.left, path, depth + 1);
    }
}
