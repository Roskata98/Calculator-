using System.Data;
using System.Linq.Expressions;
using System.Text.RegularExpressions;
using System.Xml.XPath;

namespace TCP_Server
{
    public class Calculator
    {

        public int Calculate(string datareceived)
        {
            //method 1 
           var xsltExpression =string.Format("number({0})",
               new Regex(@"([\+\-\*])").Replace(datareceived, " ${1} ").Replace("/", " div ").Replace("%", " mod "));
            return Convert.ToInt32((double)new XPathDocument
                (new StringReader("<r/>"))
                    .CreateNavigator()
                    .Evaluate(xsltExpression));


            //Method 2
            //Using CSharpCodeProvider  
            /*
            int result = (int)new CSharpCodeProvider().CompileAssemblyFromSource(new CompilerParameters(),
            $"class X {{ public static object F() {{ return {datareceived}; }} }}").
            CompiledAssembly.GetType("X").GetMethod("F").Invoke(null, null);
            return result;

           


            /*ExpressionEvaluator expressionEvaluator = new ExpressionEvaluator();
            int result = Convert.ToInt32(expressionEvaluator.Evaluate(datareceived));
           
            return result;*/




            // Example 1

            /*List<char> datalist = new List<char>();
            /*for (int i = 0; i< datareceived.Length;i++)
            {
                datalist.Add(datareceived[i]);
            }
            foreach(char b in datareceived)
            {
                datalist.Add(b);
            }
            foreach(char c in datalist)
            {
                result += c;
            }
            return result;




            // Example 2
            int num = 0;
            foreach (char c in datareceived)
            {
               
                if (Char.IsDigit(c))
                {
                    num = c;
                }
                if (c.Equals("+"))
                {
                    return result + num;
                }
                if (c.Equals("-"))
                {
                    return result - num;
                }
                if (c.Equals("*"))
                {
                    return result;
                }

            }*/



            // Method 3 using component 
            //var result = new DataTable().Compute(datareceived, null);
           // int finalresult = Convert.ToInt32(result);
            //return finalresult;

        }
    }
}
