using System;
using System.Collections;



namespace ConsoleApp5
{
    internal class Program
    {


        //[반환 타입][함수 이름] ([매개변수])
        //{
        //    실행 될 내용
        //    return;
        //}


        
        static void printHello ()
        {
            Console.WriteLine("Hello");
            Console.WriteLine("Hello");
        }


        static void printIntByinput(int i)
        {
            Console.WriteLine(i);

        }

        static bool printOneAndReturn()
        {
            Console.WriteLine("123");
            return true;
        }


        string getOneAndReturn(int input)
        {
            Console.WriteLine(input);
            return "hello";
        }

       static int UnityDouble (int toDouble)
        {

            int a;
            a = toDouble *2;

            return a;
        }

       static double AddTwoNumbers (float firstNum, string secondNum)
        {
            
            Console.WriteLine(secondNum);
            return firstNum + 10;
        }

        static void Main(string[] args)
        {
            printHello(void);
        }
    }
}