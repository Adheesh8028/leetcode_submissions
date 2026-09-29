public class MinStack {
    private Stack<int> stack;
    private Stack<int> minstack;
    public MinStack() {
        stack = new Stack<int>();
        minstack = new Stack<int>();
    }
    
    public void Push(int val) {
           stack.Push(val);
           if(minstack.Count == 0){
            minstack.Push(val);
           }
           else{
            minstack.Push(Math.Min(val,minstack.Peek()));
           }
    }
    
    public void Pop() {
        stack.Pop();
        minstack.Pop();
    }
    
    public int Top() {
        return stack.Peek();
    }
    
    public int GetMin() {
       return minstack.Peek();
    }
}
