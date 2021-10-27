using System;

namespace derss1
{
    class Program
    {
        /*
      // 2 eded int tipinde parametr qebul etsin ve parametrde daxil edilmis ededlerin cemini ve hasilini return etsin
        #region Task 1
        static int arguc (int a, int b)
        {
            int cem;
            cem = a + b;
            return cem;           
        }
        static int arguh(int a, int b)
        {
            int hasil;
            hasil = a * b;
            return hasil;
        }
        static void Main(string[] args)
        {

            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int cem = arguc(a, b);
            int hasil = arguh(a, b);
            Console.WriteLine("cem = "+ cem +"\n"+"hasil = "+hasil);
        }
        #endregion
        */


        /*
         // 2 eded int tipinde parametr qebul etsin(1-ci parametrde daxil edilmis eded 2 - ciden kicik olmalidi) ve 1-ci ededden 2 ci edede qeder olan butun ededlerin cemini return etsin.
        #region Task 2
        static int T2(int a, int b)
        {
            int cem = 0;
            if (a<b)
            {
                for (int i = a; i <= b; i++)
                {
                    cem += i;
                }
            }
            return cem;
        }

        static void Main(string[] args)
        {

            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int cem = T2(a, b);
            Console.WriteLine("cem = " + cem );
        }
        #endregion
        */


        /*
        #region Task 3
        //Task 3.Write a C# Sharp program to print the sum of two numbers. (print means show result on console)
        static int t3(int a, int b)
        {
            int cem;
            cem = a + b;
            return cem;
        }
        static void Main(string[] args)
        {

            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int cem = t3(a, b);
            Console.WriteLine(a+" "+"+"+" "+b+" = " + cem);
        }
        #endregion
        */




    }
}
