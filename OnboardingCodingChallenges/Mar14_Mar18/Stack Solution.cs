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
class myStack{
    List<Int> inStack;
    Int stackMax;
    Int stackLength;
    Int poppedItem;

    myStack(){
        inStack = null;
        stackMax = null;
        stackLength = 0;
        poppedItem = null;
    }

    void push(Int value){
        inStack.add(value);
        if (value > stackMax)
        {stackMax = value;}
        stackLength++;
    }

    Int pop(){
        if (stackLength == 0)
        {throw new InvalidOperationException("There are no elements in stack");}
        poppedItem = inStack[stackLength - 1];
        inStack.removeAt(stackLength - 1);
        stackLength--;
        return poppedItem;
    }

    Int max(){
        if (stackLength == 0)
        {throw new InvalidOperationException("There are no elements in stack");}
        return stackMax;
    }

    static void Main(string[] args){
        myStack exampleStack = new myStack();
        exampleStack.push(400);
        exampleStack.push(98);
        exampleStack.push(42);
        exampleStack.push(10);
        int num = exampleStack.pop();
        exampleStack.push(24);
        console.log(num);
        console.log(exampleStack.max);
        console.log(exampleStack);
    }
}