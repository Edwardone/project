using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace qwe
{    
    class otchet
    {
        public char[] mas = new char[256];
        public int[] met = new int[256];
    }
    class rez
    {
        public char[] mas = new char[256];
        public int[] met = new int[256];
    }
    class Program
    {
        public static void swap(ref int a,ref int b)
        {
            int tmp = a;
            a = b;
            b = tmp;
        }
        public static void swap(ref char a, ref char b)
        {
            char tmp = a;
            a = b;
            b = tmp;
        }
        static void Main(string[] args)
        {
            int l = 0;
            rez otvet = new rez();
            int count = 0;
            int metka;
            char temp;
            string h = Console.ReadLine();
            string s = h.ToLower();
            otchet obj = new otchet();
            for (int i = 0; i < s.Length; i++)
            {
                metka = 0;
                for(int k = 0;k < i;k++)
                {
                    if(obj.mas[k]==s[i])
                    if (obj.met[k] == 1)
                        metka = 1;
                }
                if (metka > 0)
                    continue;
                obj.mas[i] = s[i];
                obj.met[i] = 1;
                count = 0;
                temp = s[i];
                for(int j = i;j < s.Length;j++)
                {
                    if (temp == s[j])
                        count++;
                }
                otvet.mas[l] = temp;
                otvet.met[l] = count;
                l++;
            }
            for(int i = 0;i<s.Length;i++)
            {
                for(int j = 0;j < (s.Length-1);j++)
                {
                    if (otvet.met[j] < otvet.met[j + 1])
                    {
                        swap(ref otvet.met[j],ref otvet.met[j + 1]);
                        swap(ref otvet.mas[j], ref otvet.mas[j + 1]);
                    }
                }
            }
            for(int i = 0;i < l;i++)
            {
                Console.Write("Символ \"{0}\" = {1}", otvet.mas[i], otvet.met[i]);
                Console.WriteLine();
            }
        }
    }
}
