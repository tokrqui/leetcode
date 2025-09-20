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
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        return AddTwoNumbersInternal(l1, l2, 0);
    }

    public ListNode AddTwoNumbersInternal(ListNode l1, ListNode l2, int add) {
        var sum = (l1?.val ?? 0) + (l2?.val ?? 0) + add;
        var val = sum < 10 ? sum : sum - 10;
        var nextAdd = sum < 10 ? 0 : 1;

        if(l1?.next == null && l2?.next == null){
            if(nextAdd == 0){
                return new ListNode(val);    
            }else{
                return new ListNode(val, new ListNode(nextAdd));    
            }
        }else{
            return new ListNode(val, AddTwoNumbersInternal(l1?.next, l2?.next, nextAdd));
        }
    }

}
