using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // 각 예제의 Run 메서드를 매핑한 배열 (1번~30번)
            Action[] examples = new Action[]
            {
                Example01.Run, Example02.Run, Example03.Run, Example04.Run, Example05.Run,
                Example06.Run, Example07.Run, Example08.Run, Example09.Run, Example10.Run,
                Example11.Run, Example12.Run, Example13.Run, Example14.Run, Example15.Run,
                Example16.Run, Example17.Run, Example18.Run, Example19.Run, Example20.Run,
                Example21.Run, Example22.Run, Example23.Run, Example24.Run, Example25.Run,
                Example26.Run, Example27.Run, Example28.Run, Example29.Run, Example30.Run
            };

            while (true)
            {
                Console.Clear();

                // 박스 메뉴 출력 (18자 폭에 맞춰 정렬)
                Console.WriteLine("┌────────────────┐"); // 상단 (─ 16개)
                for (int i = 1; i <= 10; i++)
                {
                    // " 1: Example 01 " -> 총 16자
                    Console.WriteLine($"│ {i,2}: Example {i:D2} │");
                }
                Console.WriteLine("│  0: Exit       │"); // "  0: Exit       " -> 총 16자
                Console.WriteLine("└────────────────┘"); // 하단 (─ 16개)
                Console.Write("\n실행할 예제 번호를 입력하세요 (0~10): ");

                string? input = Console.ReadLine();

                if (int.TryParse(input, out int choice))
                {
                    if (choice == 0)
                    {
                        Console.WriteLine("프로그램을 종료합니다.");
                        break;
                    }

                    if (choice >= 1 && choice <= 30)
                    {
                        Console.Clear();
                        // 선택한 예제 실행
                        examples[choice - 1]();
                    }
                    else
                    {
                        Console.WriteLine("\n[오류] 0에서 30 사이의 숫자를 입력해 주세요.");
                    }
                }
                else
                {
                    Console.WriteLine("\n[오류] 올바른 숫자를 입력해 주세요.");
                }

                Console.WriteLine("\n메뉴로 돌아가려면 [Enter] 키를 누르세요...");
                Console.ReadLine();
            }
        }
    }
}