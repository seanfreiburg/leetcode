/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */
public class Solution {
    public bool HasCycle(ListNode head) {
        if (head == null){
            return false;
        }
        var slow = head;
        var fast = head.next;
        while (slow != null && fast != null){
            if (slow.val == fast.val){
                return true;
            }
            if (fast.next == null){
                return false;
            }
            slow = slow.next;
            fast = fast.next.next;
        }
        return false;
    }
}
