using System;

namespace UsingEventApp
{
    delegate void EventHandler(string message); // 메시지 받아서 처리하는 대리자 선언

    class CustomNotifier
    { //이벤트 선언 사용하는 객체
        public event EventHandler SomethingHappened; // 대리자의 인스턴스 이벤트



        public void DoSomething(int number)
        {
            int temp = number % 10;  // 일의 자리 구하기
            if( temp != 0 && temp % 3 == 0) // 3,6,9
            {
                SomethingHappened($"{number} : 짝!"); // 이벤트를 사용 (로직이 없음)
            }
            else
            {
                SomethingHappened($"{number}"); // 이벤트를 사용

            }
        }
    }
    class Program
    {
        public static void MyHandler(string message) // 이벤트가 발생했을 때 실행되는 메서드 (이벤트 핸들러)
        {
            Console.WriteLine(message);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("시작");
            CustomNotifier notifier = new CustomNotifier();
            notifier.SomethingHappened += new EventHandler(MyHandler); // 이벤트를 내가 만든 로직이 있는 메서드와 연결

            for (int i = 1; i < 100; i++)
            {
                notifier.DoSomething(i);
            }
        }
    }
}
