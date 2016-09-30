using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace Task5_2_LINQ
{
    static class Fibonacci
    {
        //public List<double> List { get; private set; } = new List<double>();

        public static BigInteger GetFibonacci(int n)
        {
            BigInteger a = 0;
            BigInteger b = 1;
            // In N steps compute Fibonacci sequence iteratively.
            for (int i = 0; i < n; i++)
            {
                BigInteger temp = a;
                a =  b;
                b = temp + b;
            }
            return a;
        }

        //public static void PrintSequence()
        //{
        //    for (int i = 0; i < 200; i++)
        //    {
        //        Console.WriteLine(GetFibonacci(i));
        //    }
        //}

        public static List<BigInteger> AddToList()
        {
            List<BigInteger> list = new List<BigInteger>();
            for (int i = 0; i < 200; i++)
            {
                list.Add(GetFibonacci(i));
            }
            return list;
        }

        public static bool IsPrime(this BigInteger candidate)
        {
            // 
            if ((candidate & 1) == 0)
            {
                if (candidate == 2)
                {
                    return true;
                }
                return false;
            }
            // 
            for (int i = 3; (i * i) <= candidate; i += 2)
            {
                if ((candidate % i) == 0)
                {
                    return false;
                }
            }
            return candidate != 1;
        }

        public static bool IsDivide(this BigInteger candidate)
        {
            BigInteger sum = 0;
            BigInteger n = candidate;
            while (n != 0)
            {
                sum += n % 10;
                n /= 10;
            }
            if (sum != 0)
            {
                if (candidate % sum == 0)
                {
                    return true;
                }
            }
            return false;
        }

        public static BigInteger SumOfSquare(this BigInteger n)
        {
            BigInteger sum = 0;
            while (n != 0)
            {
                sum += (n % 10)*(n % 10);
                n /= 10;
            }
            return sum;
        }

        //public static int CountNumberOfZero(this int num)
        //{
        //    int counter = 0;
        //    for (int i = 0; i < num.ToString().Length; i++)
        //    {
        //        if (num%10 == 0)
        //        {
        //            counter++;
        //        }
        //        num /= 10;
        //    }
        //    return counter;
        //}

        public static void Start()
        {
            int counterPrime = 0;
            int cointerDiv = 0;
            
            var list = AddToList();
            foreach (var l in list)
            {
                Console.WriteLine(l);
            }
            //foreach (var l in list)
            //{
                
            //    if (l.IsPrime())
            //    {
            //        counterPrime++;
            //    }

            //    if (l.IsDivide())
            //    {
            //        cointerDiv++;
            //    }
            //}

            var divOnFive = list
                .Where(x => x%5 == 0);
            int counterDivOnFive = divOnFive.ToList().Count();

            var sqrt = list
                .Where(x => x.ToString().Contains('2')).ToList();

            //Console.WriteLine($"Theare are {counterPrime} prime numbers, {cointerDiv} numbers divide into their sum of digits, {counterDivOnFive} numbers divide on 5");

            Console.WriteLine($"{ counterDivOnFive} numbers divide on 5");

            foreach (var sq in sqrt)
            {
                double value = (double) sq;
                Console.WriteLine($"Contains '2': {sq},sqrt: {Math.Round(Math.Sqrt(value))}");
            }
            Console.WriteLine($"All: {sqrt.Count()}");

            var sort = list
                .OrderByDescending(x => x.ToString().Remove(0, 1)).ToList();
            foreach (var s in sort)
            {
                Console.WriteLine(s);
            }

            var max = list
                //.Where(x => x.SumOfSquare())
                .Select(x => x.SumOfSquare()).Max();

            Console.WriteLine($"Max: {max}");

            //var averageZero = list
            //    .Select(x => Convert.ToInt32(x.ToString().Contains('0'))
            //        .CountNumberOfZero());
               // .Average();
            //Console.WriteLine($"Average: {averageZero}");
            //foreach (var avZero in averageZero)
            //{
            //    Console.WriteLine(avZero);
            //}
        }

    }
}
