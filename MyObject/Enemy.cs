using System;

namespace HelloWorld
{
    public class Enemy : Shooting
    {
        // 생성자 멤버 함수
        public Enemy(int my_hp): base(my_hp) {}
        // 일반 멤버 함수
        public override void move()
        {
            Console.WriteLine("[자식 Enemy 클래스] 좌우로 움직이면서 아래로 내려온다.");
        }
        public override void shoot()
        {
            Console.WriteLine("[자식 Enemy 클래스] 아래쪽으로 미사일을 쏜다.");
        }
    }
}