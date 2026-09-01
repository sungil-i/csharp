using System;

namespace HelloWorld
{
    public class Example02
    {
        public static void Run()
        {
            Console.WriteLine("\n--- Example 02 실행 ---");
            // 실습 코드를 작성하는 부분
            // 첫번째 객체 생성(Skittles)
            Pet mypet = new Pet();
            mypet.Name = "Skittles";
            mypet.WhoAreYou();

            // 두번째 객체 생성(Kiwi)
            Pet kiwi = new Pet("Kiwi");
        }
    }
}
