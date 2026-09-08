using System;

namespace HelloWorld
{
    public class Pet
    {
        // 멤버 변수
        public string Name;
        // 멤버 함수
        public Pet() // 생성자 멤버함수
        {
            Console.WriteLine("객체 생성!");
        }
        public Pet(string name) // 생성자 멤버함수
        {
            this.Name = name;
            Console.WriteLine("객체 생성!");
            Console.WriteLine($"나의 이름은 {Name} 입니다.");
        }
        public void WhoAreYou()
        {
            Console.WriteLine($"나의 이름은 {Name} 입니다.");
        }
        public void Move()
        {
            Console.WriteLine($"{Name}이/가 움직입니다.");
        }
        public void Sound()
        {
            Console.WriteLine($"{Name}이/가 소리를 냅니다.");
        }
    }
}