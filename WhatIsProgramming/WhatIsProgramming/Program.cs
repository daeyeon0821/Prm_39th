using System;

namespace WhatIsProgramming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /**
             * 입출력에 대해서
             * 프로그램을 실행할 때마다 서로 다른 값을 입력받으려면 콘솔에서 입력한 값을 변수에 저장할 수 있어야 한다.
             * 키보드로 입력받고 모니터로 출력하는 일반적인 내용을 표준 입출력(Standard input/output)이라고 한다.
             * 
             * System.Console.ReadLine():   콘솔에서 한 줄을 입력받는다.
             * System.Console.Read():       콘솔에서 한 문자를 정수로 입력받는다.
             * System.Console.ReadKey():    콘솔에서 다음 문자나 사용자가 누른 기능 키를 가져온다.
             */

            //Console.Write("이름을 입력하시오: ");
            //string yourName = string.Empty;
            //yourName = Console.ReadLine();

            //Console.WriteLine("안녕하세요. {0}님.", yourName);

            /**
             * 형식 변환
             * Console.ReadLine() 메서드를 사용하여 콘솔에서 입력받은 데이터는 문자열이다. 문자열 대신 정수나 실수
             * 데이터를 입력받고 싶다면 입력된 문자열을 원하는 데이터 형식으로 변환할 수 있어야 한다.
             * 
             * 키워드: 캐스팅 연산자, 암시적(묵시적) 형변환, 명시적 형변환
             * 
             * 3가지의 형변환 하는 법
             */

            Console.Write("숫자를 입력하시오: ");
            string stringNumber = Console.ReadLine();

            int intNumber = Convert.ToInt32(stringNumber);
            int intNumber2 = int.Parse(stringNumber);
            // * 추천 스타일 - TryParse
            int intNumber3 = default;
            int.TryParse(stringNumber, out intNumber3);

            //Console.WriteLine("입력한 숫자 + 10은(는) {0}입니다.", "100" + 10);
            Console.WriteLine("입력한 숫자 + 10은(는) {0}입니다.", intNumber3 + 10);

            float powOfThree = intNumber * intNumber * intNumber;
        }       // Main()
    }       // class Program
}       // namespace WhatIsProgramming