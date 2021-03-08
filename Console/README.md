# C# - console 기본학습

C#에서 사용하는 기본 문법 학습 <br>
Console (.NET Core 및 .NET Framework) 활용

-------------------------------------
## 0. Hello World

```
using System;

namespace Chap03App
{
    class Program
    {
        static void Main(string[] args)
        {
            // 주석입니다.
            Console.WriteLine("Hello, World!");
        }
    }
}
```
<참고\>
- Console.Write(); 값 출력 
- Console.WriteLine(); 값 출력 + 줄 바꿈
- Console.Read(); 값 입력
- Console.ReadLine(); 값 입력 + 줄 바꿈 
- // : 한줄 주석
- /// : 여러줄 

-------------------------------------
## 1. 데이터 형식 및 연산

C# 데이터 형식

값 형식 (숫자 형식 , 논리 형식)

 1. 정수 형식 <br>
<kbd>![정수형식](/Console/참고자료/정수형식.PNG "정수형식")</kbd>

 2. 실수 형식
- float: '3.14f'와 같이 뒤에 f를 붙여 소수값 지정 / 4 byte
- double: float과 달리 그냥 소수값 지정 / 8 byte
- decimal: 29자리 데이터 표현 / 16 byte

 3. 논리 형식
- bool: True or False / 1 byte

<참고\>
* 변수 지정 <br>
메모리를 할당해서 할당된 공간에 값을 넣음
이때 저장된 데이터가 Heap, 할당된 메모리 위치를 가리키는 주소를 Stack이라고 한다.

* Overflow <br>
 지정 값이 변수 범위를 벗어날 경우 값이 '0'이 된다.
 
* 형식 변환 <br>
  값이 변수 형식과 맞지 않거나 범위를 벗어나 변수 형식을 바꿔주는 일
  
```
 static void Main(string[] args)
        {
            short shmaxval = short.MaxValue;
            int incastval = 0;
            incastval = shmaxval;
            Console.WriteLine($"short값 변환한 int값은 {incastval}");

            incastval += 5;  //32767+5
            short shcastval = (short)incastval;
            Console.WriteLine($"short값 변환한 int값은 {shcastval}");  //overflow -32764

            float flval = 3.141592f; // f or F 를 써야함
            incastval = (int)flval;
            Console.WriteLine($"float값 변환한 int값은 {incastval}");
            double dlval = incastval; //3
            Console.WriteLine($"int값 변환한 double값은 {dlval}");

            object obj = 20; //boxing
            int inUnboxingVal = (int)obj; // unboxing

            string strVal = "200";
            int result = int.Parse(strVal) * 3; //parse: 문자형을 숫자형으로 형 변환
            Console.WriteLine($"200 * 3 = {result}");
        }
```
[코드보기](https://github.com/kg4543/StudyCsharp21/tree/main/Console/chap03/Chap03App)

-------------------------------------
## 2. 조건 / 반복 / 점프

-------------------------------------
## 3. 메소드

-------------------------------------
## 4. 클래스와 인스턴스 + 상속

-------------------------------------
## 5. 인터페이스 와 추상 클래스

-------------------------------------
## 6. 배열과 Index

-------------------------------------
## 7. 일반화 클래스

-------------------------------------
## 8. 예외 처리

-------------------------------------
## 9. 이벤트와 대리자

-------------------------------------
## 10. 람다식 & LINQ

-------------------------------------
## 11. File 다루기

-------------------------------------
## 12. Thread

