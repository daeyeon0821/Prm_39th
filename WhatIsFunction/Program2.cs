using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatIsFunction
{
    internal class Program2
    {
        public static void Main()
        {
            DeleteParentheses("+82)10-9063-1535");
            DeleteParentheses("+82)10-9063-1535");
            ClearLines(22);
            //Hypot(1.2, 5.6);
        }

        static void Hi() => Console.WriteLine("안녕하세요");
        static void Multiply(int a, int b) => Console.WriteLine(a * b);

        //! 콘솔 클리어하는 함수
        static void ClearLines(int lineNumber)
        {
            for (int i = 0; i < lineNumber; i++)
            {
                Console.WriteLine();
            }
        }       // ClearLines()

        //! 3개의 정수 중에서 최대값을 찾는 함수 Maximum(x, y, z)를 정의
        static int FindMaxValue(int firstValue, int secondValue, int thirdValue)
        {
            int maxValue = int.MinValue;

            // 첫번째 값과 두번째 값을 비교한다.
            if(secondValue <= firstValue)
            {
                maxValue = firstValue;
            }
            else
            {
                maxValue = secondValue;
            }

            // 위에서 정의한 maxValue와 세번째 값을 비교한다.
            if(maxValue <= thirdValue)
            {
                maxValue = thirdValue;
            }
            else { /* Do nothing */ }

            Console.WriteLine("{0}, {1}, {2} 중에서 제일 큰 값은 {3} 입니다.",
                firstValue, secondValue, thirdValue, maxValue);
            return maxValue;
        }       // FindMaxValue()

        /**
         * 화면에 "Hello"를 출력하는 SayHello() 함수를 작성.
         *  - int 타입 매개변수 받아서 그 횟수만큼 "Hello"를 반복해서 출력.
         */
        static void SayHello(int loopCount)
        {
            for(int i=0; i<loopCount; i++)
            {
                Console.WriteLine("{0}번째 {1}", i + 1, "Hello");
            }
        }       // SayHello()

        /**
         * 다른 두 변이 주어 졌을 때 직각 삼각형의 빗변을 계산하는 함수 Hypot()를 정의할 것.
         *  - 매개변수는 2개 타입은 double 형.
         *  - 리턴 타입도 double 형
         */
        static double Hypot(double firstSide, double secondSide)
        {
            double hypot = default;
            hypot = Math.Sqrt((firstSide * firstSide) + (secondSide * secondSide));

            Console.WriteLine("직각삼각형의 두 변 {0}, {1}", firstSide, secondSide);
            Console.WriteLine("빗변의 길이: {0:F4}", hypot);
            return hypot;
        }       // Hypot()

        /**
         * 주어진 숫자가 소수인지 여부를 찾는 함수 Prime()을 작성. 
         *  - 판별할 값의 범위는 2~100 사이의 값 중에서 소수는 모두 출력
         */

        static void Prime()
        {
            Console.WriteLine("2~100 사이의 값 중에서 소수 출력하는 프로그램");

            for(int index = 2; index <= 100; index++)
            {
                if(FindPrime(index))
                {
                    Console.Write("{0} ", index);
                }
            }       // loop: 2~100 의 값을 순회하는 루프
        }       // Prime()
        static bool FindPrime(int number)
        {
            bool isPrime = true;

            for(int index = number - 1; 2 <= index; index--)
            {
                if(number % index == 0)
                {
                    isPrime = false;
                    break;
                }
                else { continue; }
            }       // loop: 소수를 찾을 숫자 - 1 ~ 2까지 나눠보는 루프

            return isPrime;
        }       // FindPrime()

        /**
         * 사용자가 입력하는 전화번호에서 소괄호를 삭제한 형태로 출력하는 프로그램을 작성(함수 사용)
            - 전화번호를 입력 받는다. -> 소괄호를 삭제한 형태로 출력한다.
            - quit 입력하면 프로그램을 종료한다.
            - 프로그램 종료 전까지 전화번호를 입력 받는다.
        */
        static void DeleteParentheses(string phoneNumber)
        {
            char[] phoneNumberArray = new char[phoneNumber.Length];
            int initIndex = 0;

            Console.WriteLine("전화번호에서 소괄호를 지우는 프로그램");
            Console.WriteLine("입력받은 전화번호: {0}", phoneNumber);

            foreach (char charactor_ in phoneNumber)
            {
                phoneNumberArray[initIndex] = charactor_;
                initIndex++;
            }       // loop: 전화번호를 배열로 초기화하는 루프

            for(int index = 0; index < phoneNumberArray.Length; index++)
            {
                if (phoneNumberArray[index].Equals('(') ||
                    phoneNumberArray[index].Equals(')'))
                {
                    phoneNumberArray[index] = ' ';
                }       // if: 지울 값을 공백으로 치환
            }       // loop

            Console.WriteLine("소괄호 삭제한 전화번호: ");

            foreach (char charactor_ in phoneNumberArray)
            {
                if(charactor_.Equals(' ')) { continue; }

                Console.Write("{0}", charactor_);
            }
            Console.WriteLine();
        }       // DeleteParentheses()
    }
}
