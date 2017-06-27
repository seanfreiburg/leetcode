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
    
    public TreeNode BuildTree(int[] preorder, int[] inorder) {
        return RecursiveBuildTree(preorder, inorder, 0, inorder.Length -1, 0);
    }
    
    public TreeNode RecursiveBuildTree(
        int[] preorder,
        int[] inorder,
        int inorderStartIndex,
        int inorderEndIndex,
        int preStart) {
        
        if (preStart > preorder.Length -1 || inorderStartIndex > inorderEndIndex){
            return null;
        }
        int rootVal = preorder[preStart];
        TreeNode root = new TreeNode(rootVal);
        
        int inorderIndex = 0;
        for (int i = inorderStartIndex; i <= inorderEndIndex; i++){
            if (rootVal == inorder[i]){
                inorderIndex = i;
            }
        }

        root.left = RecursiveBuildTree(preorder, inorder, inorderStartIndex, inorderIndex -1, preStart + 1);
        root.right = RecursiveBuildTree(preorder, inorder, inorderIndex + 1, inorderEndIndex, preStart + inorderIndex - inorderStartIndex + 1);
        return root;
    }
}
