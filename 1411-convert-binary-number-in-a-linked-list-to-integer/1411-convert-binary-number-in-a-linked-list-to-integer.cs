/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public int GetDecimalValue(ListNode head) {
        int val = head.val; // Since list is non-empty (constraint)
        
        while (head.next != null) {
            head = head.next;
            val = (val << 1) | head.val;
        }
        
        return val;
    }
}