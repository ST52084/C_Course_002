using System;
using System.Collections.Generic;

namespace Scobki_V3
{
    class Program
    {
        static void Main(string[] args)
        {
            var strList = new List<string>();
            bool rez = false;
            Dictionary<char, char> dic = new Dictionary<char, char>();
            dic.Add('(', ')');
            dic.Add('[', ']');
            dic.Add('{', '}');


            var s1 = "()";                      //True  
            var s2 = "[]()";                    //True  
            var s3 = "[[]()]";                  //True  
            var s4 = "([([])])()[]";            //True  

            var s5 = "(";                       //False 
            var s6 = "[][)";                    //False 
            var s7 = "[(])";                    //False 
            var s8 = "(()[]]";                  //False 

            var s9 = "(]";                      //False 
            var s10 = "]";                      //False 
            var s11 = "{([])}";                 //True 
            var s12 = "}][()]{";                //False 

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

            int h = 0;

            foreach (var items in strList)
            {
                h++;
                string skobi = items;
                rez = Zapros(skobi, dic);


                Console.WriteLine("s" + Convert.ToInt32(h) + " " + items + "\t\t:" + rez);
            }
        }
        static bool Zapros(string skobi, Dictionary<char, char> dic)

        {
            var stack = new Stack<char>();
            char a = ' '; char b = ' '; int i = 0;
            foreach (var item in skobi)
            {
                i++;
                try
                {
                    if (dic.ContainsKey(item))
                    {

                        stack.Push(item);
                    }

                    if (dic.ContainsValue(item))
                    {

                        b = stack.Pop();

                        a = VvVale(item, dic);

                        if (a == b & skobi.Length - i == 0)
                        {
                            return true;
                        }
                    }
                }

                catch (InvalidOperationException)
                {
                    return false;
                }
            }
            return false;
        }

        static char VvVale(char item, Dictionary<char, char> dic)

        {
            foreach (var vVale in dic)
            {
                if (vVale.Value.Equals(item))
                    return vVale.Key;
            }
            return ' ';
        }
    }
}