using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.Text;

namespace Sameer.DS.CustomLib.LinkedList
{
    public class LinkedList
    {
        private class Node
        {
            public int Data { get; set; }
            public Node Next { get; set; }
            public Node(int value)
            {
                this.Data = value;
            }
        }

        private Node First { get; set; }
        private Node Last { get; set; }

        //Add First
        public void AddFirst(int data)
        {
            var node = new Node(data);
            if (First == null)
                First = Last = node;
            else
            {
                node.Next = First;
                First = node;
            }
        }
        //Add Last
        public void AddLast(int data)
        {
            //Create new node
            var node = new Node(data);
            if (First == null)
                First = Last = node;
            else
            {
                Last.Next = node;
                Last = node;
            }

        }
        //Delete First
        public void DeleteFirst()
        {
            var currNode = First.Next;
            First = currNode;
        }
        //Delete Last
        public void DeleteLast()
        {
            if (First != null)
            {
                if (First.Equals(Last))
                {
                    First = Last = null;
                    return;
                }
                else
                {
                    var prevNode = GetPreviousNode(First);
                    prevNode.Next = null;
                    Last = prevNode;
                }
            }
            else
            {
                throw new Exception("Empty Linked List");
            }
        }

        private Node GetPreviousNode(Node node)
        {
            var currNode = node;
            Node prevNode = currNode;
            while(currNode.Next!=null)
            {
                prevNode = currNode;
                currNode = currNode.Next;
            }
            return prevNode;
        }

        //Contains
        public bool Contains(int value)
        {
            var currNode = First;
            while(currNode.Next==null)
            {
                if (currNode.Data == value) return true;
                else currNode = currNode.Next;
            }
            return false;
        }
        //indexOf
        public int indexOf(int data)
        {
            var index = 0;
            var currNode = First;
            while(currNode.Next == null)
            {
                if (currNode.Data == data) return index;
                else
                {
                    currNode = currNode.Next;
                    index++;
                }
            }
            return -1;
        }

        public void Reverse()
        {
            var curr = First;
            Node preNode = null;
            Node prev = null;
            Node next = null;
            while(curr.Next!=null)
            {
                prev = preNode; // prev node set to null, then to 1 then to 2
                next = curr.Next; // next pointer to change
                curr.Next = prev; // change pointer of current node
                preNode = curr;// preNode will be the currnode
                curr = next; // next to iterate will be node 2, then 3 then 4 and so no
                if (prev == null) Last = preNode; // when pointer changed of firstnode assign to last
                if(curr.Next == null) // when it is the last node
                {
                    curr.Next = preNode; // change pointer of last node to prev node;
                    break;
                }
            }
            First = curr;
        }

        private Node GetPrevious(Node node)
        {
            if (node.Equals(First)) return null;
            else return node;
        }
    }

    
}
