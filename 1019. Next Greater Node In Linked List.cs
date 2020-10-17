https://leetcode.com/problems/next-greater-node-in-linked-list/

C#:
_____________________________________________________
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

    public int[] NextLargerNodes(ListNode head)
    {
        ListNode dummy = head;
        List<int> val = new List<int>();
        while (dummy != null)
        {
            val.Add(dummy.val);
            dummy = dummy.next;
        }
        int[] ans = new int[val.Count()];
        if (val.Count() == 0) return ans;
        SortedDictionary<int, SortedSet<int>> st = new SortedDictionary<int,SortedSet<int>>();
        for (int i = 0; i < val.Count(); i++)
        {
            while (st.Count() > 0 && st.Keys.ElementAt(0) < val[i])
            {
                int key = st.Keys.ElementAt(0);
                int id = st[key].Last();
                ans[id] = val[i];
                st[key].Remove(st[key].Last());
                int sz = st[key].Count;
                if (sz == 0) st.Remove(key);
            }
            if (st.ContainsKey(val[i])) st[val[i]].Add(i);
            else {
                st.Add(val[i], new SortedSet<int>());
                st[val[i]].Add(i);
            }
        }
        return ans;
    }
}

c++:
___________________________________________________________________
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
    vector<int> nextLargerNodes(ListNode* head) {
        ListNode *dummy = head ;
        vector<int>ans,val;
        while(dummy!=NULL)
        {
            val.push_back(dummy->val);
            ans.push_back(0);
            dummy=dummy->next;
        }
        if(val.size()==0) return ans;
        multiset<pair<int,int>>st;
        
        for(int i = 0 ; i < val.size(); i++)
        {
            while(st.size() && (*st.begin()).first<val[i])
            {
                ans[(*st.begin()).second]=val[i];
                st.erase(st.begin());
            }
            st.insert({val[i],i});
        }
        return ans;
    }
};