public class Solution {
    public int EvalRPN(string[] tokens)
{
    Stack<int> stack = new Stack<int>();

    foreach (string token in tokens)
    {
        if (int.TryParse(token, out int num))
        {
            stack.Push(num);
            continue;
        }

        int right = stack.Pop();
        int left = stack.Pop();

        switch (token)
        {
            case "+":
                stack.Push(left + right);
                break;

            case "-":
                stack.Push(left - right);
                break;

            case "*":
                stack.Push(left * right);
                break;

            case "/":
                stack.Push(left / right);
                break;
        }
    }

    return stack.Pop();
}
}
