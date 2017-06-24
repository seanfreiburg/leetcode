/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode MergeTwoLists(ListNode l1, ListNode l2) {
        var dummyNode = new ListNode(-1);
        var curr = dummyNode;
        while (l1 != null || l2 != null){
            if (l1 == null){
                curr.next = l2;
                l2 = null;
            } else if (l2 == null){
                curr.next = l1;
                l1 = null;
            }
            else {
                if (l1.val < l2.val){
                    curr.next = l1;
                    l1 = l1.next;
                } else {
                   curr.next = l2;
                   l2 = l2.next; 
                }
                curr = curr.next;
            }
        }
        return dummyNode.next;
    }
}
