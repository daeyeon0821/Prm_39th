using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatIsOperator
{
    internal class Program2
    {
        static void Main(string[] args)
        {
            /**
             * 제어문 소개
             * 프로그램을 이루는 3가지의 중요한 제어 구조에는 순차 구조(순차문), 선택 구조(조건문),
             * 반복 구조(반복문)가 있다.
             * 
             * 순차문
             * 프로그램은 기본적으로 Main() 메서드 시작 지점부터 끝 지점까지 코드가 나열되면 순서대로
             * 실행 후 종료한다.
             * 
             * 제어문
             * 프로그램 실행 순서를 제어하거나 프로그램 내용을 반복하는 작업 등을 처리할 때 사용하는 구문으로
             * 조건문과 반복문으로 구분한다.
             * 
             * 조건문(선택문)
             * 조건의 참 또는 거짓에 따라 서로 다른 명령문을 실행할 수 있는 구조이다. 분기문 또는 비교 판단문이라고
             * 하기도 한다.
             * 
             * 반복문
             * 특정 명령문을 지정된 수만큼 반복해서 실행할 때나 조건식이 참일 동안 반복시킬 때 사용한다.
             */

            /**
             * if / else 문
             * 프로그램 흐름을 여러 가지 갈래로 가지치기(Branching)할 수 있는데, 이때 if 문을 사용한다.
             * if 문은 조건을 비교해서 판단하는 구문으로 if, else if, else 세가지 키워드가 있다.
             */

            //// 02.3 예제 #1
            //// 두개의 정수 중에서 더 큰 수를 찾는 프로그램

            //int numberX, numberY;
            //Console.Write("x 값을 입력하시오: ");
            //int.TryParse(Console.ReadLine(), out numberX);
            //Console.Write("y 값을 입력하시오: ");
            //int.TryParse(Console.ReadLine(), out numberY);

            //if(numberY < numberX)
            //{
            //    Console.WriteLine("x가 y보다 큽니다.");
            //}
            //else
            //{
            //    Console.WriteLine("y가 x보다 큽니다.");
            //}

            /**
             * 02.4 중간점검 1
             * 컵의 사이즈를 받아서 100ml 미만은 small, 100ml 이상 200ml 미만은 medium, 200ml 이상은
             * large라고 출력하는 if-else 문을 작성
             */


            /**
                * LAB 1	비밀 코드 맞추기
               컴퓨터가 숨기고 있는 비밀 코드를 추측하는 게임을 작성
               비밀 코드는 a~z 사이의 문자
               컴퓨터는 사용자의 추측을 읽고서 앞에 있는지, 뒤에 있는지를 알려준다. (즉, 사용자에게 힌트를 준다.)
               ex)
               컴퓨터의 비밀코드: h (미리 초기화해서 변수에 가지고 있음.)
               
               비밀코드를 맞춰보세요: c  (-> User input)
               c 뒤에 있음.
               --- 프로그램이 종료됨. ---
               비밀코드를 맞춰보세요: h  (-> User input)
               정답입니다.
             */
            const char SECRET_CODE = 'h';

            bool charBiggerTest = false;
            if('a' < SECRET_CODE)
            {
                Console.WriteLine("h는 a보다 큽니다.");
            }
            else
            {
                Console.WriteLine("h는 a보다 작습니다.");
            }

            const char SECRET_CODE2 = '%';

            bool isSmallAlphabet = false;
            bool isBigAlphabet = false;
            bool isAlphabet = false;

            isSmallAlphabet = ('a' <= SECRET_CODE2 && SECRET_CODE2 <= 'z');
            isBigAlphabet = ('A' <= SECRET_CODE2 && SECRET_CODE2 <= 'Z');

            isAlphabet = isSmallAlphabet || isBigAlphabet;

            if(isAlphabet)
            {
                Console.WriteLine("{0}은 알파벳이 맞습니다.", SECRET_CODE2);
            }
            else
            {
                Console.WriteLine("{0}은 알파벳이 아닙니다.", SECRET_CODE2);
            }
        }       // Main()
}
}
