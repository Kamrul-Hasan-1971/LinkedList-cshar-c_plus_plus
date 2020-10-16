https://leetcode.com/problems/middle-of-the-linked-list/

c++:
________________________________________________
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
    ListNode* middleNode(ListNode* head) {
        if(head==NULL) return head;
        ListNode *dummy = head;
        int cnt = 0 ;
        while(dummy!=NULL)
        {
            cnt++;
            dummy=dummy->next;
        }
        dummy = head;
        cnt/=2;
        while(cnt--) dummy=dummy->next;
        return dummy;
    }
};