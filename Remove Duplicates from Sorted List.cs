https://leetcode.com/problems/remove-duplicates-from-sorted-list/

c#
______________________________________________
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
    public ListNode DeleteDuplicates(ListNode head) {
        if(head==null) return null;
        ListNode dummy = head;
        while(dummy.next!=null)
        {
            if(dummy.val==dummy.next.val) dummy.next=dummy.next.next;
            else dummy=dummy.next;
        }
        return head;
    }
}
c++:
______________________________________________________
/**
 * Definition for singly-linked list.
 * struct ListNode {
 *     int val;
 *     ListNode *next;
 *     ListNode() : val(0), next(nullptr) {}
 *     ListNode(int x) : val(x), next(nullptr) {}
 *     ListNode(int x, ListNode *next) : val(x), next(next) {}
 * };
 */
class Solution {
public:
    ListNode* deleteDuplicates(ListNode* head) {
        if(head==NULL) return NULL;
        ListNode *dummy = head;
        while(dummy->next!=NULL)
        {
            if(dummy->val==dummy->next->val) dummy->next=dummy->next->next;
            else dummy=dummy->next;
        }
        return head;
    }
};