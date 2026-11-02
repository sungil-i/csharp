using System;

namespace HelloWorld
{
    public class Player : Shooting
    {
        // 생성자 멤버 함수
        public Player(int my_hp) : base(my_hp) {}
        // 일반 멤버 함수
        public override void move()
        {
            Console.WriteLine("좌우로 움직인다.");
        }
        public override void shoot()
        {
            Console.WriteLine("위쪽으로 미사일을 쏜다.");
        }
    }
}