using System;

namespace HelloWorld
{
    public class Cat : Animal
    {
        // 생성자 함수
        public Cat(string name) : base(name) {}
        // 부모 클래스의 move() 함수 수정하기(재정의)
        public override void move()
        {
            Console.WriteLine($"[{Name}] 네발로 걸어간다..");
        }
        // 부모 클래스의 sound() 함수 수정하기(재정의)
        public override void sound()
        {
            Console.WriteLine($"[{Name}] 야옹!!");
        } 
    }
}