using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var strList = new List<string>();
            var stack = new Stack<sbyte>();

            var s1 = "()";                      //True  
            var s2 = "[]()";                    //True  
            var s3 = "[[]()]";                  //True  
            var s4 = "([([])])()[]";            //True  

            var s5 = "(";                       //False 
            var s6 = "[][)";                    //False 
            var s7 = "[(])";                    //False 
            var s8 = "(()[]]";                  //False 


            strList.Add(s1);
            strList.Add(s2);
            strList.Add(s3);
            strList.Add(s4);
            strList.Add(s5);
            strList.Add(s6);
            strList.Add(s7);
            strList.Add(s8);


            for (int h = 0; h < strList.Count; h++)
            {
                string skobi = strList[h];
                sbyte resultat = 0;

                for (int i = 0; i < skobi.Length; i++)
                {
                    if (skobi[i] == '(')
                    {
                        stack.Push(+1);
                    }
                    if (skobi[i] == '[')
                    {
                        stack.Push(+2);
                    }
                    if (skobi[i] == ')')
                    {
                        stack.Push(-1);
                    }
                    if (skobi[i] == ']')
                    {
                        stack.Push(-2);
                    }
                }

                //проверка на недопустимость скобок
                if (skobi.Contains("(]") | skobi.Contains("[)"))
                {
                    stack.Push(+50);
                }

                while (stack.Count > 0)
                {
                    resultat = Convert.ToSByte(resultat + stack.Peek());
                    //Console.Write(":" + stack.Pop());
                    stack.Pop();
                }

                if (resultat == 0)
                {
                    Console.WriteLine("s" + Convert.ToInt32(h + 1) + " " + strList[h] + "\t\t:" + "True");
                }
                else
                {
                    Console.WriteLine("s" + Convert.ToInt32(h + 1) + " " + strList[h] + "\t\t:" + "False");
                }
            }
        }

    }
}
