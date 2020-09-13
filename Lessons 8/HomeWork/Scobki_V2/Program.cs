using System;
using System.Collections.Generic;

namespace Scobki_V2
{
    class Program
    {
        static void Main(string[] args)
        {
            var strList = new List<string>();
            var stack = new Stack<char>();
            bool rez = false;

            var s1 = "()";                      //True  
            var s2 = "[]()";                    //True  
            var s3 = "[[]()]";                  //True  
            var s4 = "([([])])()[]";            //True  

            var s5 = "(";                       //False 
            var s6 = "[][)";                    //False 
            var s7 = "[(])";                    //False 
            var s8 = "(()[]]";                  //False 

            var s9 = "]]";                      //False 
            var s10 = "]";                      //False 
            var s11 = "])([";                   //False 
            var s12 = "][()]";                  //False 

            strList.Add(s1);
            strList.Add(s2);
            strList.Add(s3);
            strList.Add(s4);
            strList.Add(s5);
            strList.Add(s6);
            strList.Add(s7);
            strList.Add(s8);

            strList.Add(s9);
            strList.Add(s10);
            strList.Add(s11);
            strList.Add(s12);

            for (int h = 0; h < strList.Count; h++)
            {
                string skobi = strList[h];
                for (int i = 0; i < skobi.Length; i++)
                {
                    rez = false;
                    if (skobi[i] == '(')
                    {
                        stack.Push('(');
                    }
                    if (skobi[i] == '[')
                    {
                        stack.Push('[');
                    }
                    try
                    {
                        if (skobi[i] == ')')
                        {
                            if (stack.Pop() == '(')
                            {
                                rez = true;
                            }
                            else
                            {
                                rez = false;
                            }
                        }
                        if (skobi[i] == ']')
                        {
                            if (stack.Pop() == '[')
                            {
                                rez = true;
                            }
                            else
                            {
                                rez = false;
                            }
                        }
                    }
                    catch (InvalidOperationException)
                    {
                        rez = false;
                        break;
                    }
                }
                Console.WriteLine("s" + Convert.ToInt32(h + 1) + " " + strList[h] + "\t\t:" + rez);
            }
        }

    }
}
