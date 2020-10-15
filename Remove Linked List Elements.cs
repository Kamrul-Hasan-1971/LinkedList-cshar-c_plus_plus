https://leetcode.com/problems/remove-linked-list-elements/
c#:

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
public class Solution
{
    public ListNode RemoveElements(ListNode head, int val)
    {
        while(head!=null)
        {
            if (head.val == val)
            {
                head = head.next;
            }
            else
                break;
        }
        ListNode pre = new ListNode(val + 1,head),ans = head;

        while(head!=null)
        {
            if (head.val == val)
            {
                pre.next = head.next;
            }
            else
                pre = head;
            head = head.next;
        }
        return ans;
    }
}

------------------------------------------------------------------------------------
c++:

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
class Solution
{
public:
    ListNode *removeElements(ListNode *head, int val)
    {
        while(head!=NULL)
        {
            if(head->val==val)
            {
                head=head->next;
            }
            else
                break;
        }
        ListNode *pre = new ListNode(-1);
        pre->next = head;
        ListNode *ans = pre->next;

        while (head != NULL)
        {
            if (head->val == val)
            {
                if(head->next!=NULL)
                {
                    pre->next=head->next;
                }
                else
                {
                    pre->next = NULL;
                }
            }
            else
                pre = head;
            head = head->next;
        }
        return ans;
    }
};
