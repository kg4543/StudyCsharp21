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
## 1. 데이터 형식 및 지정

값 형식 (숫자 형식 , 논리 형식)

 1. 정수 형식 <br>
<kbd>![정수형식](/Console/참고자료/정수형식.PNG "정수형식")</kbd>

 2. 실수 형식
- float: '3.14f'와 같이 뒤에 f를 붙여 소수값 지정 / 4 byte
- double: float과 달리 그냥 소수값 지정 / 8 byte
- decimal: 29자리 데이터 표현 / 16 byte

 3. 논리 형식
- bool: True or False / 1 byte

 \+ const 상수값 지정
- 'const int x = 10'과 같이 변수 앞에 붙여 이후 변수값이 더 이상 바뀌지 않도록 고정 시킴

 \+ 형식 변환
- 값이 변수 형식과 맞지 않거나 범위를 벗어나 변수 형식을 바꿔주는 일

```
 static void Main(string[] args)
        {
            incastval += 5;  //32767+5
            short shcastval = (short)incastval;
            Console.WriteLine($"short값 변환한 int값은 {shcastval}");  //overflow -32764

            float flval = 3.141592f; // f or F 를 써야함
            incastval = (int)flval;
            Console.WriteLine($"float값 변환한 int값은 {incastval}");
            double dlval = incastval; //3
            Console.WriteLine($"int값 변환한 double값은 {dlval}");

            string strVal = "200";
            int result = int.Parse(strVal) * 3; //parse: 문자형을 숫자형으로 형 변환
            Console.WriteLine($"200 * 3 = {result}");
        }
```

<참고\>
* 변수 지정 <br>
메모리를 할당해서 할당된 공간에 값을 넣음
이때 저장된 데이터가 Heap, 할당된 메모리 위치를 가리키는 주소를 Stack이라고 한다.

* Overflow <br>
 지정 값이 변수 범위를 벗어날 경우 값이 '0'이 된다.

[코드보기](https://github.com/kg4543/StudyCsharp21/tree/main/Console/chap03/Chap03App)

-------------------------------------
## 2. 연산자

1. 산술연산자
 - '+' , '-', '*', '/', '%' 
 - 일반적으로 더하고 빼고 곱하고 나누고 나머지 값을 계산

2. 증감연산자
 - '++' , '--'
 - 전위 증감연산자 : 변수 값을 변경 후 구문(연산) 실행
 - 후위 증감연산자 : 구문(연산) 실행 후 변수 값 설정

3. 관계연산자
 - '<' , '>', '<=' , '>=', '==', '!='
 - 같거나 크고 작음을 비교해서 참,거짓을 구분

4. 조건연산자 + null 조건부 연산자
- 조건식 ? 참일 때 : 거짓일 때
- 변수 ?? 반환값 //변수가 null일 시 반환값으로
- String.IsNullOrEmpty(string)로 null값 체크

5. 논리연산자
 - '&&' '||' '!'
 - 'AND' 'OR' 'NOT'으로 참,거짓을 구분

6. 비트연산자 + 시프트연산자
 - '<<' '>>' '&' '|' '^' '~'
 - 2진수 값을 한자리씩 옆으로 옮기거나 자릿수 끼리 값이 같은지를 비교
 
7. 할당 연산자
 - '=' '+=' '-=' ...
 - 해당 수식에 맞추어 값을 변수에 할당

[코드보기](https://github.com/kg4543/StudyCsharp21/tree/main/Console/chap04/Chap04App)

-------------------------------------
## 3. 조건(분기) / 반복 / 점프

1. 조건문
 - if(조건식)
  {
    참일 경우 실행
  }
  else
  {
    참이 아닐 경우 실행
  }
 - Switch(조건식)
   case A: 값이 A일 경우 실행 break;
   case B: 값이 B일 경우 실행 break;
   case C: 값이 C일 경우 실행 break;
   default: 어떤 조건도 맞지 않을 경우 실행 break;

2. 반복문

3. 점프문
-------------------------------------
## 메소드

-------------------------------------
## 클래스와 인스턴스 + 상속

-------------------------------------
## 인터페이스 와 추상 클래스

-------------------------------------
## 배열과 Index

-------------------------------------
## 일반화 클래스

-------------------------------------
## 예외 처리

-------------------------------------
## 이벤트와 대리자

-------------------------------------
## 람다식 & LINQ

-------------------------------------
## File 다루기

-------------------------------------
## Thread

-------------------------------------
## Practice (주소록)

[코드보기](/Console/chap99_주소록/Chap99/Chap99)
