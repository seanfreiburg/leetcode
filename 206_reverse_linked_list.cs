/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode ReverseList(ListNode head) {
        ListNode curr = head;
        ListNode reversedHead = null;
        while (curr != null){
            var next = curr.next;
            curr.next = reversedHead;
            reversedHead = curr;
            curr = next;
        }
        return reversedHead;
    }
}
