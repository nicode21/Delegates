using System;
using System.Collections.Generic;
using System.Linq;

namespace DelegateTraining
{

    class Program
    {
        //public delegate bool CheckNums(int num/*,string name*/);

        //public delegate void ChangeString (string str,int age);

        //public delegate int StringLength(string str);

        static void Main(string[] args)
        {
            #region Predicate
            //int[] arr ={1,2,3,4,5,6,7,8};

            //Console.WriteLine(Sum(CheckGreaterThanFour, arr));

            //List<int> list = new List<int>() { 9, 14, 21, 16, 5, 6, 7, 42, 9 };

            //var result = SumOfNumbersDivideBy3And7(ChecknumbersDivideBy3And7,nums);
            //Console.WriteLine(result);

            //Console.WriteLine((list.FindAll(m => m % 3 == 0 && m % 7 == 0).Sum(m => m))); 

            //var result = nums.FindAll(m => m %2==0);
            //Console.WriteLine(result.Count);
            #endregion
            #region null
            //string name;

            //Person person = null;

            //string text = name;

            //int? a = null;    // ? OLMASA ERROR VERIR 

            //Test test = new Test();

            //Console.WriteLine(test.id);

            //int b = 5;
            #endregion

            //string name = "Nihad";

            //ShowString(StringToUpper, name, 20);

            //ChangeString func = StringToUpper;


            //func += delegate (string str, int age)
            //  {
            //      Console.WriteLine(str.ToLower() + " - Age : " + age);
            //  };

            //func += (str,age) => Console.WriteLine(str.ToLower() + " - Age : " + age);

            //func.Invoke("Anar", 35);


            //Action<string ,int> action = StringToUpper;

            //action("oRXan",66);

            //string name = "Nihad";



            //ShowString(StringToLower,name,12);


            //Action action = Test;

            //action();


            //PowerOfNumber(ClacualtePower,2,3);

            //Action<int,int> func = ClacualtePower;

            //func(2,3);


            //var result = ShowStrLength(GetStringLength, "Gultac");

            //Console.WriteLine(result);

            //Func<string,int> func = GetStringLength;

            //var res = func("Lale");

            //Console.WriteLine(res);


            ShowFactorial(GetFactorial,5);

            Func<int,int> func = GetFactorial;

            Console.WriteLine(func(5));

        }

        public static int GetFactorial(int num)
        {
            int res = 1;

            while (num!=1)
            {
                res*=num;
                num--;
            }
            return res;
        }


        public static void ShowFactorial(Func<int,int> func , int num)
        {
            Console.WriteLine(func(num));
        }


        //public static int GetStringLength(string str)
        //{
        //    return str.Length;
        //}

        //public static int ShowStrLength(Func<string,int> func,string str)
        //{
        //    return func(str);
        //}


        //public static void ClacualtePower(int num, int power)
        //{
        //    Console.WriteLine(Math.Pow(num,power));
        //}


        //public static void PowerOfNumber(Action<int,int> func,int num,int power)
        //{
        //    func(num,power);
        //}


        //public static void Test()
        //{
        //    Console.WriteLine("Test");
        //}

        //public static void StringToLower(string str,int age)
        //{
        //    Console.WriteLine(str.ToLower()+ " - Age : " + age);
        //}
        //public static void StringToUpper(string str,int age)
        //{
        //    Console.WriteLine(str.ToUpper() + " - Age : " + age);
        //}



        //public static void ShowString(Action<string ,int> func,string str,int age)
        //{
        //    func(str,age);
        //}


        



        //public static bool ChecknumbersDivideBy3And7(int num)
        //{
        //    return num % 3 == 0 && num % 7 == 0;
        //}



        //public static int SumOfNumbersDivideBy3And7(Predicate<int> predicate,List<int> list)
        //{
        //    int sum = 0;
        //    foreach (var item in list)
        //    {
        //        if (predicate(item))
        //        {
        //            sum+=item;
        //        }
        //    }
        //    return sum;
        //}


        //public static bool CheckOddNums(int number)
        //{
        //    return number % 2 != 0 ;
        //}
        //public static bool CheckEvenNums(int number)
        //{
        //    return number % 2 == 0;
        //}
        //public static bool CheckGreaterThanFour(int number/*,string name*/)
        //{
        //    //if (name is null)
        //    //{
        //    //        return false;
        //    //}
        //    return number > 4;
        //}
        ////**********************************************************************
        //public static int Sum(CheckNums predicate,int[] arr)
        //{
        //    int sum =0;
        //    foreach (var item in arr)
        //    {
        //        if (predicate(item))
        //        {
        //            sum+=item;
        //        }
        //    }
        //    return sum;
        //}

        //public static int SumEvenNums(int[] arr)
        //{
        //    int sum = 0;
        //    foreach (var item in arr)
        //    {
        //        if (item % 2 == 0)
        //        {
        //            sum += item;
        //        }
        //    }
        //    return sum;
        //}
        //public static int SumGreaterThanFour(int[] arr)
        //{
        //    int sum = 0;
        //    foreach (var item in arr)
        //    {
        //        if (item>4)
        //        {
        //            sum += item;
        //        }
        //    }
        //    return sum;
        //}


        #region null
        //public static string GetData(int? id)
        //{
        //    if (id is null)
        //    {
        //        return "";
        //    }
        //    return "";
        //}
        #endregion
    }

    #region null
    //class Test
    //{
    //    public int? id { get; set; }
    //}


    //class Person
    //{

    //}
    #endregion
}
