/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        var carry = 0;
        var newList = new ListNode(0);
        var curr = newList;
        
        while (l1 != null || l2 != null){
            var val1 = l1 != null ? l1.val : 0;
            var val2 = l2 != null ? l2.val : 0;
            var curr_sum = carry + val1 + val2;
            if (curr_sum > 9){
                carry = 1;
                curr.next = new ListNode(curr_sum - 10);
            }
            else {
                carry = 0;
                curr.next = new ListNode(curr_sum);
            }
            l1 = l1 != null ? l1.next: l1;
            l2 = l2 != null ? l2.next: l2;
            curr = curr.next;
        }
        
        if (carry > 0){
            curr.next = new ListNode(carry);
        }

        return newList.next;
    }
}
