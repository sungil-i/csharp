using System;

namespace HelloWorld
{
    public class Example04
    {
        public static void Run()
        {
            Console.WriteLine("\n--- Example 04 실행 ---");
            // 객체지향 상속 소스코드 작성
            // Cat 인스턴스 생성하기
            Cat mycat = new Cat("헬로키티");
            mycat.move();
            mycat.sound();
            // Bird 인스턴스 생성하기
            Bird mybird = new Bird("앵그리버드");
            mybird.move();
            mybird.sound();
        }
    }
}
