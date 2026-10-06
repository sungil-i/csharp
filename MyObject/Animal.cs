using System;

namespace HelloWorld
{
    public class Animal
    {
        // ----------멤버 변수----------
        public string Name;
        // ----------멤버 함수----------
        // 생성자 함수
        public Animal(string name)
        {
            this.Name = name;
            Console.WriteLine($"{Name} 인스턴스를 생성했습니다.");
        }
        // virtual 키워드 사용
        public virtual void move()
        {
            Console.WriteLine($"[{Name}] 움직인다..");
        }
        public virtual void sound()
        {
            Console.WriteLine($"[{Name}] 소리를 낸다!");
        }

    }
}