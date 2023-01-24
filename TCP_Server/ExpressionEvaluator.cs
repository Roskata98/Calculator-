using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace TCP_Server
{
    public class ExpressionEvaluator
    {   
        private int result = 0;
        public int Evaluate(string expression)
        {
            int result = 0;
            //this.CalculateSkoba(expression,0);   
            return this.CalculateSimpleExpression(expression);
            
        }



        public int CalculateDifficultExpression(string expression)
        {
            // Create operand and operator stacks
            var operandStack = new Stack<double>();
            var operatorStack = new Stack<char>();
            // Create a list of tokens (numbers and operators)
            // var tokens = Tokenize(expression);
            var tokens = expression.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            // Process the tokens
            //foreach(char token in expression)
            foreach (var token in tokens)
                            // for(int i=0; i<expression.Length; i++)
            {
                //var token = expression[i];
                if (IsNumber(token))
                {
                    // If the token is a number, push it onto the operand stack
                    operandStack.Push(double.Parse(token));
                }
                else if (IsOperator(token))
                {
                    // If the token is an operator, push it onto the operator stack
                    // after removing any operators with higher or equal precedence
                    while (operatorStack.Count > 0 /*&& HasHigherOrEqualPrecedence(operatorStack.Peek(), token[0])*/)
                    {
                        result = Convert.ToInt32(this.PerformOperation(operatorStack.Pop(), operandStack.Pop(), operandStack.Pop()));
                    }
                    operatorStack.Push(token[0]);
                }
            }
            return result;
            // When the input expression has been completely processed,
            // append any remaining operators to the result list
            /* while (operatorStack.Count > 0)
             {
                 operandStack.Push(PerformOperation(operatorStack.Pop(), operandStack.Pop(), operandStack.Pop()));
             }*/

            // The final result should be the only value on the operand stack
            //return operandStack.Peek();

        }










        //General methods for checking if char is number or operator and performing operations

        private static bool IsNumber(string token)
        {
            // Return true if the token is a number, false otherwise
            double result;
            return double.TryParse(token, out result);
        }

        private static bool IsOperator(string token)
        {
            // return true if the token is an operator, false otherwise
            if (token == "+" || token == "-" || token == "*" || token == "/")
            {
                return true;
            }
            else { return false; }
        }

        private static bool HasHigherOrEqualPrecedence(char op1, char op2)
        {
            // Return true if operator 1 has higher or equal precedence to operator 2, false otherwise
            if (op1 == '*' || op1 == '/')
            {
                return true;
            }
            return op1 == '+' || op1 == '-' && op2 == '+' || op2 == '-';
        }

        private double PerformOperation(char operation, double operand2, double operand1)
        {
            // Perform the specified operation on the operands
            switch (operation)
            {
                case '+':
                    return operand1 + operand2;
                case '-':
                    return operand1 - operand2;
                case '*':
                    return operand1 * operand2;
                case '/':
                    return operand1 / operand2;
                default:
                    throw new ArgumentException("Invalid operator");
            }
        }






        /// <summary>
        /// Used to take the expression inside the parentheses, calculate it
        /// Still in development mode It should replace the innerexpression with the final resul 
        private static Stack<double> numbers = new Stack<double>();
        private static Stack<string> operators = new Stack<string>();
        private int counter = 0;
        void CalculateSkoba(string expression,int count)
        {  
            var firstOpen = expression.IndexOf('(');
            var secondOpen = expression.IndexOf(')');
            if (firstOpen != -1 && secondOpen != -1)
            {
                string innerExpression = expression.Substring(firstOpen + 1, secondOpen - firstOpen -count);
                CalculateSkoba(innerExpression,++count);
                //innerExpression.ToString();
                innerExpression = expression.Replace(Convert.ToChar(innerExpression), Convert.ToChar(result));

                //innerExpression.Remove(0, counter-1);
                //innerExpression.Insert(0, Convert.ToString(result));
                //innerExpression= innerExpression.ToString();
            }
            else
            {
                var a = expression.Split(' ').ToList();
                foreach (var b in a)
                {
                    counter++;
                    var isNumber = double.TryParse(b, out double number);
                    if (isNumber)
                    {
                        numbers.Push((double)number);
                    }
                    else
                    {
                        if (IsOperator(b))
                        {
                            operators.Push(b);
                        }
                        
                    }
                }
                int num2 =Convert.ToInt32(numbers.Pop());
                int num1 =Convert.ToInt32(numbers.Pop());
                string temp_op = Convert.ToString(operators.Pop());
                char op2 = Convert.ToChar(temp_op);
                double temp_result = PerformOperation(op2, num2, num1);
                result = Convert.ToInt32(temp_result);
            }
        }


        /// </summary>





        /// <summary>
        /// Used to calculate expression with 2 numbers and operator
        /// It can calucalate equations such as 1+1 or 1 + 1
        /// have issues when it has user error such as 1 +1. In simple words, the numbers and operators should have the same whitespace pattern 
        public int CalculateSimpleExpression(string expression)
        {
            bool whitespace;
            whitespace = expression.Any(Char.IsWhiteSpace);
            if (!whitespace)
            {
                var newValue = Regex.Replace(expression, "([0-9])([+^/^*^-])", "$1 $2 ");
                expression = newValue;
            }
            var a = expression.Split(' ').ToList();
            foreach (var b in a)
            {
                var isNumber = double.TryParse(b, out double number);
                if (isNumber)
                {
                    numbers.Push((double)number);
                }
                else
                {
                    if (IsOperator(b))
                    {
                        
                        operators.Push(b);
                    }
                }
            }
            int num2 = Convert.ToInt32(numbers.Pop());
            int num1 = Convert.ToInt32(numbers.Pop());
            string temp_op = Convert.ToString(operators.Pop());
            char op2 = Convert.ToChar(temp_op);
            double temp_result = PerformOperation(op2, num2, num1);
            result= result + Convert.ToInt32(temp_result);
            return result;
            }
        }
         /// </summary>

}
