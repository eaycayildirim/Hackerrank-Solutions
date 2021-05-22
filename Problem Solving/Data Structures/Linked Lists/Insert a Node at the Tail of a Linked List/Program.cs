using System;
using System.Collections.Generic;
using System.IO;

namespace InsertANodeAtTheTailOfALinkedList
{
    class Solution
    {
        class SinglyLinkedListNode
        {
            public int data;
            public SinglyLinkedListNode next;

            public SinglyLinkedListNode(int nodeData)
            {
                this.data = nodeData;
                this.next = null;
            }
        }

        class SinglyLinkedList
        {
            public SinglyLinkedListNode head;

            public SinglyLinkedList()
            {
                this.head = null;
            }

        }

        static void PrintSinglyLinkedList(SinglyLinkedListNode node, string sep, TextWriter textWriter)
        {
            while (node != null)
            {
                textWriter.Write(node.data);

                node = node.next;

                if (node != null)
                {
                    textWriter.Write(sep);
                }
            }
        }

        static SinglyLinkedListNode insertNodeAtTail(SinglyLinkedListNode head, int data)
        {
            SinglyLinkedListNode newNode = new SinglyLinkedListNode(data);
            if (head == null)
            {
                head = newNode;
                return head;
            }
            else
            {
                SinglyLinkedListNode temp = head;
                while (temp.next!=null)
                {
                    temp = temp.next;
                }
                temp.next = newNode;
            }
            return head;
        }

        static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@"C:\Users\Sabreden Derviş\Masaüstü");

            SinglyLinkedList llist = new SinglyLinkedList();

            int llistCount = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < llistCount; i++)
            {
                int llistItem = Convert.ToInt32(Console.ReadLine());
                SinglyLinkedListNode llist_head = insertNodeAtTail(llist.head, llistItem);
                llist.head = llist_head;
            }

            PrintSinglyLinkedList(llist.head, "\n", textWriter);
        }
    }
}
