using System;

namespace WhatIsOperator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /**
             * 5. 우리나라에서 많이 사용되는 면적의 단위인 평을 평방미터로 환산하는 프로그램 작성.
                여기서 1평은 3.3058 m^2
	                ex)
		                평: 25.0
		                평방미터: ????
            */

            // { 사용자의 입력을 받는 입력부 / dy.Lee / 2022.12.19
            const float ONE_PYUNG = 3.3058F;
            float userInput = 0.0F;

            // 여기서 입력을 받았음.
            Console.Write("평: ");
            float.TryParse(Console.ReadLine(), out userInput);
            // } 사용자의 입력을 받는 입력부 / dy.Lee / 2022.12.19

            // 결과를 출력할 출력부
            Console.Write("평방미터: {0}", userInput * ONE_PYUNG);
        }
    }
}