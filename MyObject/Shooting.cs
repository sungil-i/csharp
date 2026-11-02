using System;

namespace HelloWorld
{
    public class Shooting
    {
        // 멤버 변수
        public int hp = 1;

        // 생성자 멤버 함수
        public Shooting(int my_hp)
        {
            this.hp = my_hp;
        }
        // 일반 멤버 함수
        public virtual void move()
        {
            Console.WriteLine("비행기가 움직입니다.");
        }
        public virtual void shoot()
        {
            Console.WriteLine("미사일을 쏩니다.");
        }
    }
}