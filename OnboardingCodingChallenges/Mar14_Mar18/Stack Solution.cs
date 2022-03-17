//Stack Solution
/*
Implement a stack that has the following methods:
• push ( v a 1 ) : push v a 1 onto the stack

• pop: pop off and return the topmost element of the stack.
If there are no elements in the stack, throw an error.

• max: return the maximum value in the stack currently.
If there are no elements in the stack, throw an error.

Each method should run in constant time.
*/
using System;
using System.Collections.Generic;
					
public class myStack
{
	List<int> inStack = new List<int>();
    List<int> stackMax = new List<int>();
    int stackLength;
    int poppedItem;
    int maxLength;

    myStack(){
        inStack = new List<int>();
        stackLength = 0;
    }

    void push(int value){
        inStack.Add(value);
        if (maxLength == 0){
            stackMax.Add(value);
            maxLength++;
        }
        else {
            if (value >= stackMax[maxLength - 1]){
                stackMax.Add(value);
                maxLength++;
            }
        }
        stackLength++;
    }

    int pop(){
        if (stackLength == 0)
        {throw new InvalidOperationException("There are no elements in stack");}
        poppedItem = inStack[stackLength - 1];
        inStack.RemoveAt(stackLength - 1);
        stackLength--;
        if (poppedItem == stackMax[maxLength - 1]){
            stackMax.RemoveAt(maxLength - 1);
            maxLength--;
        }
        
        return poppedItem;
    }
    
    int max(){
        if (stackLength == 0)
        {throw new InvalidOperationException("There are no elements in stack");}
        return stackMax[maxLength - 1];
    }
	
	public static void Main()
	{
		myStack exampleStack = new myStack();
        exampleStack.push(400);
        exampleStack.push(98);
        exampleStack.push(42);
        exampleStack.push(10);
        int num = exampleStack.pop();
        exampleStack.push(24);
		int maxVal = exampleStack.max();
        Console.WriteLine(num);
        Console.WriteLine(maxVal);
		for(int i = 0; i < exampleStack.stackLength; i++){
			Console.WriteLine(exampleStack.inStack[i]);
		}
	}
}