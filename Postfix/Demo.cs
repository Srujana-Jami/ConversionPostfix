using System;
using System.Security.Cryptography.X509Certificates;
using System.Transactions;

namespace Postfix
{
    class Program
    {
        static void Main(string[] args)
        {
            String infix;
            Console.Write("enter prifix expression ");
            infix = Console.ReadLine();

            String postfix = infixToPostfix(infix);

            Console.WriteLine("Postfix expression is : " + postfix);

        }
            public static String infixToPostfix(String infix)
            {
                String postfix = "";
                
                StackChar st = new StackChar(20);
                
                char next, symbol;

                for (int i = 0; i < infix.Length; i++)
                {
                    symbol = infix[i];

                    if (symbol == ' ' || symbol == '\t')
                        continue;

                    switch (symbol)
                    {
                        case '(':
                            st.Push(symbol);
                            break;
                        case ')':
                            while ((next = st.Pop()) != '(')
                                postfix = postfix + next;
                            break;
                        case '+':
                        case '-':
                        case '*':
                        case '/':
                        case '%':
                        case '^':
                            while (!st.IsEmpty() && Precedence(st.Peek()) >= Precedence(symbol))
                                postfix = postfix + st.Pop();
                            st.Push(symbol);
                            break;
                        default:
                            postfix = postfix + symbol;
                            break;


                    }
                }
                while (!st.IsEmpty())
                    postfix = postfix + st.Pop();

                return postfix;

            }
            public static int Precedence(char symbol)
            {

                switch (symbol)
                {
                    case '(':
                        return 0;
                    case '+':
                    case '-':
                        return 1;
                    case '*':
                    case '/':
                    case '%':
                        return 2;
                    case '^':
                        return 3;
                    default:
                        return 0;


                           

                }

            }




    }

}

    
