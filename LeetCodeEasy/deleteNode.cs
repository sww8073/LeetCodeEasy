﻿namespace LeetCodeEasy
{
    public class deleteNode
    {
        
        public class ListNode {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
        }
        public class Solution {
            public void DeleteNode(ListNode node) {
                node.val = node.next.val;
                node.next = node.next.next;
            }
        }
    }
}