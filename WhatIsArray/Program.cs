// System 이라는 어셈블리에서 이것 저것 여러 기능을 가져와서 사용할 거야.
using System;

// 내 프로그램 이름이다. 내가 정했다.
namespace WhatIsArray
{
    // 클래스 라는 것인데, C#에서는 모든 요소들이 클래스 안에 있어야 함.
    internal class Program
    {
        // 무조건 1개는 있어야 함. -> C# 콘솔(검은 창)을 사용할 때
        static void Main(string[] args)
        {
            //// 프로그램은 여기서부터 읽기 시작한다.
            //Console.WriteLine("Hello, World!");

            //// 3의 배수를 제외한 수
            //int sumOfNumber = 0;
            ////int variable_ = 100;

            //for( int variable_ = 1; variable_ <= 100; variable_++)
            //{
            //    bool isRealMultipleOfThree = (variable_ % 3 == 0);
            //    Console.WriteLine("{0} -> isRealMultipleOfThree: {1}",
            //        variable_, isRealMultipleOfThree);

            //    // 1~100 숫자 중에서 3의 배수를 제외한 수의 합 구하기
            //    if (isRealMultipleOfThree == false)
            //    {
            //        // 3의 배수가 아닌건 다 여기로 오겠네?
            //        // 여기서 값을 계속 더해주면 되겠네?
            //        sumOfNumber += variable_;
            //        Console.WriteLine("잘 더해지고 있나? : {0}", sumOfNumber);
            //    }
            //    else
            //    {
            //        // 여기로 오겠네?
            //        // 그러면 여기서 코딩해야지
            //    }

            //    Console.WriteLine();
            //}       // loop: 100번 도는 루프
            //// 루프가 끝나면 여기로 오니까 다 끝날 때까지는 더해서 마지막 값을 눈으로
            //// 보고 싶으니까
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine("================================");
            //Console.WriteLine("sumOfNumber: {0}", sumOfNumber);
            //Console.WriteLine("================================");


            //string personalGender = "여자";
            //if (personalGender.Equals("남자"))       // 조건문 A
            //{
            //    // 조건문 A가 참(True)이면 여기로 옴.
            //    // 조건문 A가 여기서부터 읽기 시작한다.
            //    Console.WriteLine("아 남자구나 ok");
            //    // 조건문 A가 여기서 끝난다.
            //}
            //else if(personalGender == "여자")       // 조건문 B
            //{
            //    // 조건문 B가 참(True)이면 여기로 옴.
            //    // 조건문 B가 여기서부터 읽기 시작한다.
            //    Console.WriteLine("아 여자구나 ok");
            //    // 조건문 B가 여기서 끝난다.
            //}
            //else
            //{
            //    // 저 조건문이 거짓(False)이면 여기로 옴.
            //    // 조건문은 여기서부터 읽기 시작한다.
            //    Console.WriteLine("아 남자도 여자도 아닌가 보구나");
            //    // 조건문은 여기서 끝난다.
            //}

            //// 조건문을 실행했으면 이제 다시 여기서부터 프로그램 시작한다.

            //for(int index = 1; index <= 50; index++)
            //{
            //    Console.WriteLine();
            //}
            //Console.WriteLine("정말로 콘솔이 정리가 되었나?");

            //// 프로그램 사용자로부터 양의 정수를 하나 입력 받아서,
            //// 그 수만큼 "Hello world!"를 출력하는 프로그램 작성.
            //int someNumber = 100;
            //bool isPositiveInteger = (0 < someNumber);

            ///**
            // * 프로그램 사용자로부터 계속해서 정수를 입력 받는다. 
            // * 그리고 그 값을 계속해서 더해 나간다. 이러한 작업은 
            // * 프로그램 사용자가 0을 입력할 때까지 계속되어야 하며, 
            // * 0이 입력되면 입력된 모든 정수의 합을 출력하고 프로그램 종료.
            // */
            //bool isNumberZero = (someNumber == 0);

            //// 프로그램 사용자로부터 입력 받은 숫자에 해당하는 구구단을 출력하되,
            //// 역순으로 출력하는 프로그램을 작성.
            //int userInputNumber = 3;
            //for(int index = 9; 1 <= index; index--)
            //{
            //    Console.WriteLine("{0} x {1} = {2}",
            //        userInputNumber, index, userInputNumber * index);
            //}       // loop: 9번을 도는 루프

            ///**
            // * 프로그램 사용자로부터 입력 받은 정수의 평균을 출력하는 프로그램을 작성하되, 
            // * 다음 두 가지의 조건을 만족할 것.
            // * - 먼저 몇 개의 정수를 입력할 것인지 프로그램 사용자에게 묻는다. 
            // * 그리고 그 수만큼 정수를 입력 받는다.
            // * - 평균 값은 소수점 이하까지 계산해서 출력한다.
            // */

            ///**
            // * LAB 1	비밀 코드 맞추기
            // * 컴퓨터가 숨기고 있는 비밀 코드를 추측하는 게임을 작성
            // * 비밀 코드는 a~z 사이의 문자
            // * 컴퓨터는 사용자의 추측을 읽고서 앞에 있는지, 뒤에 있는지를 알려준다. 
            // * (즉, 사용자에게 힌트를 준다.)
            // */
            //char scretCode = 'y';
            //char userInputAlphabet = 'c';
            //bool isSmallAlphabet = 
            //    ('a'<= userInputAlphabet && userInputAlphabet <= 'z');

            //bool isAlphabetFore = (userInputAlphabet <= scretCode);
            //bool isAlphabetBack = (scretCode <= userInputAlphabet);

            //if (isSmallAlphabet) { /* Do nothing */ }
            //else
            //{
            //    Console.WriteLine("{0} {1}",
            //        "[System] 당신의 입력은 처리할 수 없습니다.",
            //        "알파벳 소문자만을 입력해주세요.");
            //}

            //if(isAlphabetFore)
            //{
            //    Console.WriteLine("당신의 알파벳은 시크릿 코드보다 앞에 있습니다.");
            //}
            //else { /* Do nothning */ }

            //if(isAlphabetBack)
            //{
            //    Console.WriteLine("당신의 알파벳은 시크릿 코드보다 뒤에 있습니다.");
            //}
            //else { /* Do nothing */ }

            //// * 1~100 숫자 중에서 3의 배수이면서 4의 배수인 정수 합 구하기
            //int sumNumber = 0;
            //int someNumber = 100;
            //bool isMultipleOfThree = (someNumber % 3 == 0);
            //bool isMultipleOfFour = (someNumber % 4 == 0);

            //bool isSatisfyCondition = isMultipleOfThree && isMultipleOfFour;

            //if(isSatisfyCondition)
            //{
            //    sumNumber += someNumber;
            //}       // if: 3의 배수이면서 4의 배수인 값

            //// 별을 100번 찍는 법
            //Console.WriteLine("{0} {1} {2} {3} {4}",
            //    "**********", "**********", "**********", "**********", "**********");
            //Console.WriteLine("{0} {1} {2} {3} {4}",
            //    "**********", "**********", "**********", "**********", "**********");

            //for(int index = 1; index <= 100; index++)
            //{
            //    Console.Write("{0} ", "*");
            //}

            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();
            //for (int index = 1; index <= 10; index++)
            //{
            //    for(int index2 = 1; index2 <= 10; index2++)
            //    {
            //        Console.Write("{0} ", "*");
            //    }       // loop: 이건 밖의 루프가 1번 도는 동안 10번을 도는 루프
            //    Console.WriteLine();
            //}       // loop: 이건 10 번을 도는 루프



            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();
            //int hundredCount = 0;
            //for (int index = 1; index <= 10; index++)
            //{
            //    for (int index2 = 1; index2 <= 10; index2++)
            //    {
            //        for(int index3 = 1; index3 <= 10; index3++)
            //        {
            //            hundredCount++;
            //            if (100 < hundredCount) { break; }
            //            else { /* Do nothing */ }

            //            // 여기가 별을 찍는 지점
            //            Console.Write("{0} ", "*");

            //            // 여기서 10번마다 한 줄을 띄어 줄거임
            //            if(hundredCount % 10 == 0)
            //            {
            //                Console.WriteLine();
            //            }       // if: 별을 10번 찍을 때마다 한 줄 띄어주는 중
            //        }       // loop: 이건 1번 루프가 10번 도는 동안 2번 루프가 10번 돌고
            //        // 그 동안 다시 10번을 도는 루프
            //    }       // loop: 이건 밖의 루프가 1번 도는 동안 10번을 도는 루프
            //}       // loop: 이건 10 번을 도는 루프
            //// 프로그램은 여기서 끝난다.

            /**
             * 컬렉션
             * 이름 하나로 데이터 여러 개를 담을 수 있는 자료 구조를 컬렉션(Collection) 또는
             * 컨테이너(Container) 라고 한다. C#에서 다루는 컬렉션은 배열(Array), 리스트(List), 
             * 사전(Dictinary) 등이 있다.
             * 
             * 배열
             * 배열(Array)은 같은 종류의 데이터들이 순차적으로 메모리에 저장되는 자료 구조이다. 각각의 데이터들은
             * 인덱스(번호)를 사용하여 독립적으로 접근된다. 배열을 사용하면 편리하게 데이터를 모아서 관리할 수 있다.
             * 
             * 배열의 특징들
             * 1. 배열 하나에는 데이터 형식 한 종류만 보관할 수 있다.
             * 2. 배열은 메모리의 연속된 공간을 미리 할당하고, 이를 대괄호([])와 0부터 시작하는 정수형 인덱스를
             *      사용하여 접근할 수 있다.
             * 3. 배열을 선언할 때는 new 키워드로 배열을 생성한 후 사용할 수 있다.
             * 4. 배열에서 값 하나는 요소(Element) 또는 항목(Item)으로 표현한다.
             * 5. 필요한 데이터 개수를 정확히 정한다면 메모리를 적게 사용하여 프로그램 크기가 작아지고 성능이
             *      향상된다.
             * 
             * 배열에는 세 가지 종류가 있다. 
             * 1차원 배열: 배열의 첨자를 하나만 사용하는 배열
             * 다차원 배열: 첨자 2개 이상을 사용하는 배열 (2차원, 3차원, ..., n차원 배열)
             * 가변(Jagged) 배열: '배열의 배열'이라고도 하며, 이름 하나로 다양한 차원의 배열을 표현할 때 사용한다.
             */

            //// 배열의 선언과 초기화
            //int[] numbers = new int[5] { 1, 2, 3, 4, 5 };

            //int number1 = 1;
            //int number2 = 2;
            //int number3 = 3;
            //int number4 = 4;
            //int number5 = 5;

            //Console.WriteLine(numbers);


            //for(int index = 0; index < numbers.Length; index++)
            //{
            //    Console.Write("{0} ", numbers[index]);
            //}

            //foreach(int element in numbers)
            //{
            //    Console.Write("{0} ", element);
            //}

            //int number = 1_0822;
            //Console.WriteLine("64로 Mod 연산: {0}", number % 64);

            /**
             * 다차원 배열
             * 2차원 배열, 3차원 배열처럼 차원이 2개 이상인 배열을 다차원 배열이라고 한다.
             * C#에서 배열을 선언할 때는 콤마를 기준으로 차원을 구분한다.
             */

            //int[] oneArray = new int[2] { 1, 2 };
            //int[,] twoArray = new int[3, 2] { { 1, 2 }, { 3, 4 }, { 5, 6 } };
            //int[,,] threeArray = new int[2, 2, 2] 
            //{ 
            //    { { 1, 2 }, { 3, 4 } }, 
            //    { { 1, 2 }, { 3, 4 } } 
            //};

            //// 3행 3열짜리 배열에서 행과 열이 같으면 1, 다르면 0을 출력
            //twoArray = new int[3, 3];

            //for(int y = 0; y < 3; y++)
            //{
            //    for(int x = 0; x < 3; x++)
            //    {
            //        if(x == y) { twoArray[y, x] = 1; }
            //        else { twoArray[y, x] = 0; }
            //    }
            //}       // loop: 값을 대입하는 루프

            //for (int y = 0; y <= twoArray.GetUpperBound(0); y++)
            //{
            //    for (int x = 0; x <= twoArray.GetUpperBound(1); x++)
            //    {
            //        Console.Write("{0} ", twoArray[y, x]);
            //    }
            //    Console.WriteLine();
            //}       // loop: 값을 출력하는 루프

            ///**
            // * 가변 배열
            // * 차원이 2개 이상인 배열은 다차원 배열이고, 배열 길이가 가변 길이인 배열은 가변 배열이라고 한다.
            // */

            //int[][] zagArray = new int[2][];
            //zagArray[0] = new int[2] { 1, 2 };
            //zagArray[1] = new int[3] { 3, 4, 5 };

            //for(int y = 0; y < 2; y++)
            //{
            //    for(int x = 0; x < zagArray[y].Length; x++)
            //    {
            //        Console.Write("{0} ", zagArray[y][x]);
            //    }
            //    Console.WriteLine();
            //}

            int[] intArray;                 // int 형 데이터 타입의 intArray 라는 배열을 선언
            intArray = new int[3];          // int 형 데이터 타입의 변수를 3개 메모리에 할당

            intArray[0] = 1;                // intArray 0번째 인덱스에 1이라는 정수값을 대입
            intArray[1] = 2;                // intArray 1번째 인덱스에 2이라는 정수값을 대입
            intArray[2] = 3;                // intArray 2번째 인덱스에 3이라는 정수값을 대입

            // 배열 직접 출력해본다.
            for (int index = 0; index < 3; index++)
            {
                Console.WriteLine("{0} 번째 인덱스의 값 -> {1}", index, intArray[index]);
            }       // loop: 3번 도는 루프
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            // intArray 배열에서 int 형 데이터 타입의 값을 하나씩 뽑아서 index에 저장 할거임.
            foreach(int index in intArray)
            {
                Console.WriteLine("intArray 배열에서 뽑아온 값 -> {0}", index);
            }       // loop: intArray 배열의 길이만큼 도는 루프

            
        }
    }
}