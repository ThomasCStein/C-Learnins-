using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linked_List
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 3, 5, 7, 9 };
            ////arr.add doesnt work because arrays are immutable...right?
            //Node n1;//Just a pointer
            //Node n2 = new Node(17);//this is an instance because of the word "new". Object and instance are the same.
            ////n2 is an instance of class Node. Memory allocated somewhere.
            //Console.WriteLine(n1); doesnt work because its a pointer to null.
            //Console.WriteLine(n2); works becaust it has an actual value.
            Node someNode = new Node(7);
            Node anotherNode = new Node(11);
            anotherNode.Next = someNode;

            SinglyLinkedList myList=new SinglyLinkedList();   //creates head pointing to nothing(at first), and stored in the heap.
            //SinglyLinkedList myList = null;
            myList.Print();
                       
            myList.Append(10);//idx[0]
            myList.Append(20);
            myList.Append(30);
            myList.Append(40);

            myList.Insert(35,3);
            //myList.Delete(6);
            //myList.DeleteFirst();
            myList.Print();

            //try
            //{
            //    myList.DeleteFirst();
            //    myList.Print();
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            

        }
        class Node
        {
            //to store
            public int Value { get; set; }
            public Node Next { get; set; }
            public Node(int someVal)
            {
                Value = someVal;
                //Next = null;  Default value.
            }

            
        }
        class SinglyLinkedList
        {
                //data
            Node head;

                //behavior
                //Addfirst
            public void AddFirst(int someValue)
            {
                  //create a new nodee
                Node newNode = new Node(someValue);
                  //Link the new node in.
                newNode.Next = head;
                  //move the head to the left.
                head = newNode;
            }
                //AddLast / Append
            public void Append(int someValue)
            {
                AddLast(someValue);
            }
            public void AddLast(int someValue)
            {
                if (head == null)   //edge case
                {
                    AddFirst(someValue);
                    return;
                }
                    //Create a new node
                Node newNode = new Node(someValue);
                    //Start from the beginning
                Node finger = head; //Traverse the list to get to the last node that IS NOT NULL.
                while (finger.Next != null) //Peeks ahead to the last NOT NULL node. does not go into it. 
                {
                    finger = finger.Next;
                }
                //When weve gotten here the finger points to the last node that IS NOT NULL.
                //Link last node to new node
                finger.Next = newNode;
            }
            //DeleteFirst
            public void DeleteFirst()
            {
                if (head ==null)//edge case
                {
                    throw new Exception("You can't DeleteFirst from an empty list!");
                }
                else
                {
                    head = head.Next;
                }

                
            }
            //DeleteLast
            public void DeleteLast(int SomeValue)
            {
                if (head == null)//edge case if list is empty
                {
                    throw new Exception("You cant DeleteLast of an empty list!");
                }
                else if (head.Next == null)//edge case if only one item in list.
                {

                }
                else
                {
                    Node finger = head;
                    finger = finger.Next;
                    while (finger.Next.Next != null)// peeking two ahead, so it can stop before the one we want to delete.
                    {
                        finger = finger.Next;//Moving right in the list, looking for the last.
                    }
                    //have arrived at the one before the last NOT NULL in the list.
                    finger.Next = null;
                }
                
            }
            //Insert
            public void Insert(int somevalue, int index)
            {
                if ((index==0)&& (head==null))
                {
                    AddFirst(somevalue);
                    return;
                }
                //create new nodee
                Node newNode = new Node(somevalue);

                //need to find the node at position indes-1
                Node finger = head;
                for (int pos=0; /*finger.Next != null &&*/ pos <index-1; pos++)
                {
                    if (finger==null)
                    {
                        Console.WriteLine("Error");
                        return;
                    }
                    finger = finger.Next;
                }
               //link new node to node after where we want it
                newNode.Next = finger.Next;
                finger.Next = newNode;
            }
            //Delete
            public void Delete(int idx)
            {
                if (idx < 0)
                {
                    return;
                }
                if (idx == 0)
                {
                    DeleteFirst();
                }
                else
                {
                    Node finger = head;
                    for (int pos = 0; pos < idx; pos++)
                    {
                        if (finger == null)
                        {
                            Console.WriteLine("Error");
                            return;
                        }
                    }
                    //link out
                    //if(finger.Next!=null)
                    if(finger.Next != null)
                    {
                        finger.Next = finger.Next.Next;
                        return;
                    }
                    else
                    {

                    }
                }
            }
            //Print / Traverse
            
            public void Print()
            {
                if (head == null)//means the list is empty
                {
                    Console.WriteLine("The list is empty.");
                }
                else
                {
                    Node finger = head;
                    while (finger != null)
                    {
                        Console.Write(finger.Value+ " ");
                        finger = finger.Next;//move finger to the right
                    }
                }
            }
            //ctor...used to initialize 
            public SinglyLinkedList()
            {
                //head=null;//just showing what the default values are.
            }
        }
    }
}
