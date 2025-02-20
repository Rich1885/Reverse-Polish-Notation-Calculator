using System;

namespace RPN
{
    public class PolishNotationCalculator
    {
        /* Use the IStack<double> interface type to allow the flexibility of using different stack implementations 
         * (e.g., ArrayStack or LinkedListStack). */
        private IStack<double> stack;

        public PolishNotationCalculator(IStack<double> stackImplementation)
        {
            stack = stackImplementation;
        }

        public double Evaluate(string expression)
        {


            /* 1. Split the expression into individual tokens using a space as the delimiter. */
            string[] tokens = expression.Split(' ');

            /* 2. Iterate over each token:
             *      - If the token is a number, push it onto the stack.
             *      - If the token is an operator (+, -, *, /):
             *          a. Pop two numbers from the stack (b first, then a).
             *          b. Perform the operation (a + b, a - b, etc.).
             *          c. Push the result back onto the stack.
             */

            for(int i = 0; i < tokens.Length; i++)
            {
                double number;
                bool isNumber = double.TryParse(tokens[i], out number);
                if (isNumber)
                {
                    stack.Push(number);
                } else
                {
                    double b = stack.Pop();
                    double a = stack.Pop();

                    double result;

                    if (tokens[i] == "+")
                    {
                        result = a + b;
                    } else if (tokens[i] == "-")
                    {
                        result = a- b;
                    } else if (tokens[i] == "*")
                    {
                        result= a* b;
                    }
                    else if (tokens[i] == "/")
                    {
                        if (b == 0) throw new DivideByZeroException("Error: Division by zero.");
                        result = a / b;
                    }
                    else
                    {
                        throw new InvalidOperationException($"Error: Unknown operator '{tokens[i]}'");
                    }

                    stack.Push(result);

                }

            }

            /* 3. After processing all tokens, the result of the calculation will be the single number remaining on the stack.
             *    Pop and return it as the final result.
             */
            if (stack.IsEmpty()) throw new InvalidOperationException("Error: No result found.");
            return stack.Pop();
        }
    }
}
