﻿namespace LeetCodeEasy
{
    public class reverseLinkedList
    {
        public class ListNode {
            public int val;
            public ListNode next;
            public ListNode(int val=0, ListNode next=null) {
                this.val = val;
                this.next = next;
            } 
        }
        public ListNode ReverseList(ListNode head) {
            ListNode prev = null, current = head, next = null;
            while( current != null){
                next = current.next;
                current.next = prev;
                prev = current;
                current = next;
            }
            head = prev;
            return head;
        }
    }
}