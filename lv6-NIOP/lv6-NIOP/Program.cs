using System;
using System.IO;
using System.Collections.Generic;

namespace lv6_NIOP
{
    class Program
    {   
        static DateTime vrijeme()
        {
            DateTime vr = DateTime.Now;
            return vr;
        }
        static int mnozenje(int x,int y)
        {
            int mn = x * y;
            return mn;
            
        }
        static int mn1(int mn)
        {
            int a = max(mn);
            int b = Math.Pow(a,5);
            return b;
        }
        static int mn2(int mn)
        {
            int a = min(mn);
            int b = Math.Pow(a,2);
            for (int i = a; i<b; i++)
            {
                if (i%3==0 && i%5==0)
                {
                    return i;
                    break;
                }
            }
        }
        static int mn3(int mn)
        {
            List<string> list = new List<string>()
            {
                Valerio = mn,
                Manuela = mn + 5,
                Matija = Manuela + 5,
                Marko = Matija + 5,
                Leon = Marko + 5,
                Kovacevic = Leon + 5,
                Mijatovic = Kovacevic + 5,
                Dankovic = Mijatovic + 5,
                Dorijan = Dankovic + 5
            };
          
        }
        static int zbrajanje(int x,int y)
        {
            int zb = x + y;
            return zb;
        }
        static int oduzimanje(int x,int y)
        {
            int od = x - y;
            return od;
        }
        static int max(int x)
        {
            int max = 0;
            while(x!=0)
            {
                int z= x % 10;
                if(z>max)
                {
                    max = z;
                }
                x /= 10;
            }
            return max;
        }
        static int min(int x)
        {
            int min = 0;
            while (x != 0)
            {
                int z = x % 10;
                if (z < min)
                {
                    min = z;
                }
                x /= 10;
            }
            return min;
        }
        static void ispis()
        {
            StreamWriter sw = new StreamWriter(@"D:\\Gabrijel Kastelan 3.b\lv6-NIOP\vjezba.txt");
            sw.WriteLine("{0}", vrijeme());
            sw.Close();
        }
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Unesite 2 broja: ");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
        }
    }
}
