c#
______________________________________________________________
recursive:

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
    int i = 0 , res = 0 ;
    public int GetDecimalValue(ListNode head) {
        if(head==null) return 0;
        return GetDecimalValue(head.next)+(head.val*(int)Math.Pow(2,i++));
    }
}
iterative:
_________________________________________________________
public class Solution {
    int i = 0 , res = 0 ;
    public int GetDecimalValue(ListNode head) {
        ListNode dummy = head ;
        int res = 0 ;
        while(dummy!=null)
        {
            res<<=1;
            res|=dummy.val;
            dummy=dummy.next;
        }
        return res;
    }
}

c++:
________________________________________________________________
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
    int getDecimalValue(ListNode* head) {
        int num = 0;
        ListNode* curr_node = head;
        while( curr_node != nullptr ) {
            num <<= 1;
            num += curr_node->val;
            curr_node = curr_node->next;
        }
        return num;
    }
};