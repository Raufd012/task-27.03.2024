//namespace Yeni_Task
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Hello, World!");
//        }
//    }
//}



//task 1


//using System;

//class Program
//{
//    static void Main()
//    {

//        int[] numbers = { 3, -2, 4, -7, -1, 33, 11, 43, };


//        ConvertNegativesToPositive(numbers);


//        Console.WriteLine();
//        foreach (var number in numbers)
//        {
//            Console.Write(number + " ");
//        }
//    }

//    static void ConvertNegativesToPositive(int[] array)
//    {
//        for (int i = 0; i < array.Length; i++)
//        {
//            if (array[i] < 0)
//            {
//                array[i] = -array[i]; 
//            }
//        }
//    }
//}



//Task 2




//using System.ComponentModel.Design;
//using System.Runtime.CompilerServices;

//namespace Yeni_Task
//{
//    internal class Program
//    {
//        static void Main()
//        {
//            string word = "Salam aleykum";
//            Num(ref word);
//        }
//        public static void Num(ref string word)
//        {
//            int count = 0;
//            for (int i = 0; i < word.Length; i++)
//            {
//                if (word[i] == 'a')
//                {
//                    count++;
//                    {
//                        if (count > 0)
//                        {
//                            Console.WriteLine("true");
//                        }

//                    }
//                }
//            }
//        }
//    }
//    }




//task 3




//namespace Yeni_Task
//{
//    internal class Program
//    {
//        static void Main()
//        {
//            int[] mode = { 1, 3, -5, 7, -9, 23, -43, 88 };
//            Number(ref mode);
//        }
//        public static void  Number(ref int[] mode)
//        {
//            int modified = mode[0];

//            for (int i = 0; i < mode.Length; i++)
//            {
//                if (mode[i] < modified)
//                {
//                    modified = mode[i];
//                }
//            }
//            Console.WriteLine(modified);
//        }
//    }
//}




//task 4





//namespace Yeni_Task
//{
//    internal class Program
//    {
//        static void Main()
//        {
//            int Number = 246;
//            NumLength(ref Number);
//        }
//        public static void NumLength(ref int num)
//        {
//            int count = 0;
//            if (num == 0)
//            {
//                count = 1;
//            }
//            while (num != 0)
//            {
//                count++;
//                num = num / 10;
//            }
//            Console.WriteLine("Modified Num: " + count);
//        }
//    }
//}



//task 6

//namespace Yeni_Task
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            int mode = { 1, 2, 3, 4, 5 };
//            min(ref mode);
//            {
//                public static void min(ref int mode)
//                {
//                    int sum = 0;
//                    int num = 0;
//                    int min = 0;
//                    for (int i = 0; i < num.Length; i++)
//                    {
//                        num++;
//                        sum += num;
//                        min = sum / num;
//                        {
//                            Console.WriteLine(min);
//                        }
//                    }
//                }
//            }
//        }
//    }
//}






//task 5






namespace Yeni_Task
{
    internal class Program
    {
        static void Main()
        {
            string text = "Salam Aleykum";
            VowelLetter(ref text);
        }
        public static void VowelLetter(ref string Symbol)
        {
            int count = 0;
            for (int i = 0; i < Symbol.Length; i++)
            {
                if (Symbol[i] == 'a' ||
                    Symbol[i] == 'b' ||
                    Symbol[i] == 'c' ||
                    Symbol[i] == 'd' ||
                    Symbol[i] == 'e' ||
                    Symbol[i] == 'F' ||
                    Symbol[i] == 'D' ||
                    Symbol[i] == 'G' ||
                    Symbol[i] == 'R' ||
                    Symbol[i] == 'P')
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
