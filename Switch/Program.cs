using System;

namespace Switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /**
             * 선택문인 switch 문은 값에 따라 다양한 제어를 처리할 수 있다. 조건을 처리할 내용이 많은 경우 유용하다.
             * switch, case, default 키워드를 사용하여 조건을 처리한다.
             */

            //Console.Write("정수 1, 2, 3 중에 하나를 입력하시오: ");
            //int switchNumber = 0;
            //int.TryParse(Console.ReadLine(), out switchNumber);

            //switch(switchNumber)
            //{
            //    case 1:
            //        Console.WriteLine("1을(를) 입력했습니다.");
            //        break;
            //    case 2:
            //        Console.WriteLine("2을(를) 입력했습니다.");
            //        break;
            //    case 3:
            //        Console.WriteLine("3을(를) 입력했습니다.");
            //        break;
            //    default:
            //        Console.WriteLine("처리하지 않은 예외 입력입니다.");
            //        break;
            //}       // switch

            //switch (switchNumber)
            //{
            //    case 1:
            //        Console.WriteLine("1을(를) 입력했습니다.");
            //        goto case 3;
            //    case 2:
            //    case 3:
            //        Console.WriteLine("3을(를) 입력했습니다.");
            //        break;
            //    default:
            //        Console.WriteLine("처리하지 않은 예외 입력입니다.");
            //        break;
            //}       // switch

            /**
             * 02.5 중간점검
             * 1. case 절에서 break 문을 생략하면 어떻게 되는가?
             */

            //Console.WriteLine("가장 좋아하는 프로그래밍 언어는?");
            //Console.Write("1. C \t");
            //Console.Write("2. C++ \t");
            //Console.Write("3. C# \t");
            //Console.Write("4. Java \t");

            //int choice = Convert.ToInt32(Console.ReadLine());

            //switch(choice)
            //{
            //    case 1:
            //        Console.WriteLine("C 선택");
            //        break;
            //    case 2:
            //        Console.WriteLine("C++ 선택");
            //        break;
            //    case 3:
            //        Console.WriteLine("C# 선택");
            //        break;
            //    case 4:
            //        Console.WriteLine("Java 선택");
            //        break;
            //    default:
            //        Console.WriteLine("[System] 처리하지 않은 예외 입력입니다.");
            //        break;
            //}       // switch

            //Console.WriteLine("오늘의 날씨는 어떤가요? (맑음, 흐림, 비, 눈, ...)");
            //string weather = Console.ReadLine();

            //switch(weather)
            //{
            //    case "맑음":
            //        Console.WriteLine("오늘 날씨는 맑군요.");
            //        break;
            //    case "흐림":
            //        Console.WriteLine("오늘 날씨는 흐리군요.");
            //        break;
            //    case "비":
            //        Console.WriteLine("오늘 날씨는 비가 오는군요.");
            //        break;
            //    default:
            //        Console.WriteLine("혹시 눈이 내리나요?");
            //        break;
            //}       // switch

            // while 문은 조건식이 참일 동안 문장을 반복 실행한다.

            //// while 문은 반복문인데 5번 실행할 예정
            //int loopCounter = 0;
            //while(loopCounter < 5)
            //{
            //    Console.WriteLine("{0} 반복문이 정말로 5번만 실행되나?", loopCounter + 1);
            //    loopCounter++;
            //}       // loop: 5번만 도는 루프

            //// 10 ~ 1 카운트 후 발사 출력하는 프로그램 작성
            //loopCounter = 10;
            //while (loopCounter > 0)
            //{
            //    Console.Write("{0} ", loopCounter);
            //    loopCounter -= 1;
            //}       // loop: 
            //Console.WriteLine("발사");

            //// 예제 #1 - 구구단 출력하는 프로그램 작성. User input 받아서 해당 단을 출력
            //int userGugudan = 0;
            //Console.Write("구구단 중에서 출력하고 싶은 단 입력: ");
            //int.TryParse(Console.ReadLine(), out userGugudan);

            //const int GUGU_LOOP_COUNT = 9;
            //int guguLoopIdx = 1;
            //while(guguLoopIdx <= GUGU_LOOP_COUNT)
            //{
            //    Console.WriteLine("{0}*{1}={2}", userGugudan, guguLoopIdx, userGugudan * guguLoopIdx);
            //    guguLoopIdx++;
            //}       // loop: 9번 도는 루프

            //const float FLOAT_VALUE = 0.1f;
            //float sumOfFloatValue = 0.0f;
            //int loopCount = 10;

            //while(0 < loopCount)
            //{
            //    sumOfFloatValue += FLOAT_VALUE;
            //    loopCount--;
            //}       // loop: 10번 돈다
            //Console.WriteLine("무슨 값이 나오나? {0}", sumOfFloatValue);

            /**
             * for 문은 일정한 횟수만큼 반복할 때 유용하다.
             * 초기식을 실행한 후에 조건식이 참인 동안, 문장을 반복한다. 한번 반복이 끝날 때마다 증감식이
             * 실행된다.
             */

            //// 1~10 까지 정수의 합
            //int sumNumber = 0;      
            ////                       5번          7번
            ////      1번              2번          4번
            //// for(int index = 1; index <= 10; index++)
            //for(int index = 1; index <= 10; index++)
            //{
            //    // 3번, 6번
            //    sumNumber += index;
            //}
            //Console.WriteLine($"1부터 10까지의 정수의 합 = {sumNumber}");
            //Console.WriteLine("1부터 10까지의 정수의 합 = {0}", sumNumber);



            //// 1~100 숫자 중에서 3의 배수를 제외한 수의 합 구하기
            //int sumNumber = 0;
            //for(int index = 1; index <= 100; index++)
            //{
            //    if (index % 3 == 0) { /* Do nothing */ }
            //    else
            //    {
            //        sumNumber += index;
            //    }
            //}       // loop: 100번 도는 루프

            //Console.WriteLine(sumNumber);

            /**
             * break 문
             * break 문은 반복 루프를 벗어나기 위해서 사용한다. break 문이 실행되면 반복 루프는 즉시 중단되고
             * 반복 루프 다음에 있는 문장이 실행된다.
             * 
             * continue 문
             * continue 문은 현재 수행하고 있는 반복 과정의 나머지를 건너뛰고 다음 반복 과정을 강제적으로
             * 시작하게 만든다. 반복 루프에서 continue 문은 만나게 되면 continue 문 다음에 있는 후속 코드들은
             * 실행되지 않고 건너뛰게 된다.
             */

            //// 1~100 숫자 중에서 3의 배수를 제외한 수의 합 구하기
            //int sumNumber = 0;
            //for (int index = 1; index <= 100; index++)
            //{
            //    if (index % 3 == 0) { continue; }
            //    else
            //    {
            //        sumNumber += index;
            //    }
            //}       // loop: 100번 도는 루프

            //Console.WriteLine(sumNumber);

            //for (int index = 1; index <= 10; index++)
            //{
            //    if (index == 4) { break; }
            //    Console.WriteLine("현재 인덱스: {0}", index);
            //}       // loop: 10번을 도는 루프

            /**
             * foreach 문은 배열(Array)이나 컬렉션(Collection) 같은 값을 여러 개 담고 있는 데이터 구조에서
             * 각각의 데이터가 들어 있는 만큼 반복하는 반복문이다. 데이터 개수나 반복 조건을 처리할 필요가 없다.
             */

            // string 에서 글자를 하나씩 출력
            string stringText = "Hello World!";

            int loopCount = 0;
            foreach(char oneCharactor in stringText)
            {
                Console.Write("{0} ", oneCharactor);
                loopCount++;
            }       // loop: stringText의 길이만큼 도는 루프
            
            Console.WriteLine();
            Console.WriteLine("Loop count: {0}, stringText's length: {1}", 
                loopCount, stringText.Length);
        }       // Main()
    }
}