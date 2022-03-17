//Linked List Solution
/*
 Given two singly linked lists that intersect at some point, find the intersecting node.
 Assume the lists are non-cyclical.

For example, given A = 3 ➔ 7 ➔ 8 ➔ 10 and B = 99 ➔ 1 ➔ 8 ➔ 10, return the node with value 8.
In this example, assume nodes with the same value are the exact same node objects.

Do this in 0( m + n) time (where m and n are the lengths of the lists) and constant space.
*/
using System;
					
public class myNode
{
	int value;
    Boolean evaluated;
    myNode next;

    myNode(){
        value = 0;
        next = null;
        evaluated = false;
    }

    myNode(int val, myNode n){
        value = val;
        next = n;
        evaluated = false;
    }
	
	static myNode findIntersection(myNode A, myNode B){
            while(A.next != null){
                A.evaluated = true;
                A = A.next;
            }
            while(B.next != null){
                if (B.evaluated == true)
                {return B;}
                B.evaluated = true;
                B = B.next;
            }
			myNode badNode = new myNode();
			return badNode;
        }

        static void cleanUp(myNode n){
            while(n.next != null){
                n.evaluated = false;
                n = n.next;
            }
        }
	
	public static void Main(){

        myNode a4 = new myNode();
        a4.value = 10;
        myNode a3 = new myNode(8, a4);
        myNode a2 = new myNode(7, a3);
        myNode a1 = new myNode(3, a2);

        myNode b2 = new myNode(1, a3);
        myNode b1 = new myNode(99, b2);

        myNode intersectNode = myNode.findIntersection(a1, b1);
        Console.WriteLine(intersectNode.value);
        myNode.cleanUp(a1);
        myNode.cleanUp(b1);
	}
}