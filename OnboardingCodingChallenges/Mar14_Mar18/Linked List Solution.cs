//Linked List Solution
/*
 Given two singly linked lists that intersect at some point, find the intersecting node.
 Assume the lists are non-cyclical.

For example, given A = 3 ➔ 7 ➔ 8 ➔ 10 and B = 99 ➔ 1 ➔ 8 ➔ 10, return the node with value 8.
In this example, assume nodes with the same value are the exact same node objects.

Do this in 0( m + n) time (where m and n are the lengths of the lists) and constant space.
*/
class Node{
    int value;
    Boolean evaluated;
    Node next;

    Node(){
        value = 0;
        next = null;
        evaluated = false;
    }

    Node(Int val, Node n){
        value = val;
        next = n;
        evaluated = false;
    }

    static void Main(string[] args){
        static Node findIntersection(Node A, Node B){
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
        }

        static void cleanUp(Node n){
            while(n.next != nul){
                n.evaluated = false;
                n = n.next;
            }
        }

        Node a4 = new Node();
        a4.value = 10;
        Node a3 = new Node(8, a4);
        Node a2 = new Node(7, a3);
        Node a1 = new Node(3, a2);

        Node b2 = new Node(1, a3);
        Node b1 = new Node(99, b2);

        Node intersectNode = findIntersection(a1, b1);
        console.log(intersectNode.value);
    }
}