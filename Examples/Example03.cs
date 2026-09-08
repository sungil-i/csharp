using System;

namespace HelloWorld
{
    public class Example03
    {
        public static void Run()
        {
            Console.WriteLine("\n--- Example 03 실행 ---");
            // 실습 코드를 작성하는 부분
            // Dog 객체 생성하기
            Dog mydog = new Dog();
            mydog.Name = "멍멍이";
            mydog.WhoAreYou();
            mydog.Move();
            mydog.Sound();

            Console.WriteLine("----------");

            // Frog 객체 생성하기
            Frog myfrog = new Frog("개굴");
            myfrog.Move();
            myfrog.Sound();
        }
    }
}
