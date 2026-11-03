using System;

namespace HelloWorld
{
    public class Example05
    {
        public static void Run()
        {
            Console.WriteLine("\n--- Example 05 실행 ---");
            // 실습 코드를 작성하는 부분
            // 플레이어 비행기 인스턴스 만들기
            Player player = new Player(5);
            // 적 비행기 인스턴스 만들기
            Enemy enemy = new Enemy(1);
            // 게임화면이라는 가정 하에
            // 플레이어 비행기와 적 비행기의 멤버 함수를 호출합니다.
            player.move();
            player.shoot();
            enemy.move();
            enemy.shoot():
        }
    }
}
