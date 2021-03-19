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

### 1. 정수 형식 <br>
<kbd>![정수형식](/Console/참고자료/정수형식.PNG "정수형식")</kbd>

### 2. 실수 형식
- float: '3.14f'와 같이 뒤에 f를 붙여 소수값 지정 / 4 byte
- double: float과 달리 그냥 소수값 지정 / 8 byte
- decimal: 29자리 데이터 표현 / 16 byte

### 3. 논리 형식
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

### 1. 산술연산자
 - '+' , '-', '*', '/', '%' 
 - 일반적으로 더하고 빼고 곱하고 나누고 나머지 값을 계산

### 2. 증감연산자
 - '++' , '--'
 - 전위 증감연산자 : 변수 값을 변경 후 구문(연산) 실행
 - 후위 증감연산자 : 구문(연산) 실행 후 변수 값 설정

### 3. 관계연산자
 - '<' , '>', '<=' , '>=', '==', '!='
 - 같거나 크고 작음을 비교해서 참,거짓을 구분

### 4. 조건연산자 + null 조건부 연산자
- 조건식 ? 참일 때 : 거짓일 때
- 변수 ?? 반환값 //변수가 null일 시 반환값으로
- String.IsNullOrEmpty(string)로 null값 체크

### 5. 논리연산자
 - '&&' '||' '!'
 - 'AND' 'OR' 'NOT'으로 참,거짓을 구분

### 6. 비트연산자 + 시프트연산자
 - '<<' '>>' '&' '|' '^' '~'
 - 2진수 값을 한자리씩 옆으로 옮기거나 자릿수 끼리 값이 같은지를 비교
 
### 7. 할당 연산자
 - '=' '+=' '-=' ...
 - 해당 수식에 맞추어 값을 변수에 할당

[코드보기](https://github.com/kg4543/StudyCsharp21/tree/main/Console/chap04/Chap04App)

-------------------------------------
## 3. 조건(분기) / 반복 / 점프

### 1. 조건문
 - if(조건식) {True일 경우 실행} <br>
   else {False일 경우 실행} <br>
 - Switch(조건식) <br>
   case A: 값이 A일 경우 실행 break; <br>
   case B: 값이 B일 경우 실행 break; <br>
   case C: 값이 C일 경우 실행 break; <br>
   default: 어떤 조건도 맞지 않을 경우 실행 break; <br>

### 2. 반복문
  - while(조건문) { 조건문이 True일 시 반복 실행}
  - do{ 조건문이 False라도 한 번은 실행 후 참,거짓 판별}while(조건문)
  - for(초기화식; 조건식; 반복식;){ 조건문이 True일 시 반복 실행 }
  - foreach(변수명 in 배열 or 컬렉션) {배열 값들을 한번 순회하면서 값을 입력};
  - 무한 반복문 : for( ; ; ) while(true)

### 3. 점프문
  - Break : 실행 중인 반복문을 중단하고 탈출
  - Continue : 실행 중인 반복문을 중단하고 다시 반복문 처음으로
  - Goto 위치 : 사전에 위치를 정한 곳으로 이동 (코드가 꼬일 가능이 높아 사용하지 않는걸 권장) 
   
 [코드보기](https://github.com/kg4543/StudyCsharp21/tree/main/Console/chap05/Chap05App)
 
-------------------------------------
## 4. 메소드
 - 실행할 코드를 하나로 묶어서 실행 및 관리
 
 ### 1. 메소드 지정 및 호출
 ```
 class Program
    {
        static void Main(string[] args)
        {
            PrintProfile("김구겸", "010-4000-8000");
        }
        
        public static int PrintProfile(string name, string phone)
        {
            if(string.IsNullOrEmpty(name))
            {
                Console.WriteLine("출력을 실패하였습니다.");
                Console.WriteLine("이름을 정확히 입력하세요");
                return -1;
            }
            if (string.IsNullOrEmpty(phone))
            {
                Console.WriteLine("출력을 실패하였습니다.");
                Console.WriteLine("전화번호를 정확히 입력하세요");
                return -2;
            }
            //프로필 출력
            Console.WriteLine($"이름 : {name}, 폰번호 {phone}");
            return 0;
        }
 ```
 - public static int PrintProfile(string name, string phone) {} 에서 메소드를 지정
 - Main 메소드에서 PrintProfile("홍길동", "010-1111-1111"); 를 통해서 메소드 호출
 - 호출 시 메소드에서 지정한 형식 (string, string)을 그대로 따른다.
 - return 값은 메소드에서 지정한 형식(int)을 따른다. 
 - 따라서 형식을 (void)로 지정 시 return값이 없다.

 ### 2. 참조 형식
 - 특정 조건으로 변수를 초기화할 때 사용
 - 입력값을 넣을 때 참조형식으로 넣어 변수를 출력 받음

  ```
  static void Main(string[] args)
        {
            int x = 47, y = 5;

            Console.WriteLine($"Before Swap {x},{y}");

            Program.Swap(ref x,ref y); // 정렬 기반

            Console.WriteLine($"After Swap {x},{y}");
        }

        private static void Swap(ref int p1, ref int p2)
        {
            int temp = p1; // temp = 47
            p1 = p2; // p1 = 5 , p2 = 5
            p2 = temp; // p2 = 47
        }
  ```
- 지정한 메소드에서 값을 바꾸어 받고 싶을 때 활용
- 값을 호출할 때 'ref 변수' 주소 값을 전달해서 메소드에서 값을 변환시킴

```
static void Main(string[] args)
        {
            int a = 22;
            int b = 3;
            /*int val = 0;
            int rem = 0;*/
            Divide(a,b,out int val,out int rem);

            Console.WriteLine($"{a}/{b}={val}\n{a}%{b}={rem}");

            bool isSuceed = int.TryParse("1000.74", out int result); // False
            Console.WriteLine($"변환결과 {isSuceed}, result값{result}");
        }
        static void Divide(int a, int b, out int quotient, out int remainder)
        {
            quotient = a / b;
            remainder = a % b;
            return;
        }
```
- 입력값과 별개로 출력값을 받을 수 있도록 변수를 

-------------------------------------
## 5. 클래스와 인스턴스 + 상속

 ### 1. 클래스
 
- 객체를 만들기 위한 객체의 구조 및 기능을 정의 (객체지향 프로그래밍)
- 클래스 = 속성 + 기능
- 인스턴스 = 클래스에서 정의되어 만들어지는 객체

### 2. 상속 (다형성)

- 기존클래스를 확장하여 새로운 하위 클래스를 생성
- 여러클래스에서 공통인 부분을 뽑아 상위클래스로 제작
- 하위클래스에서는 상위클래스의 속성 및 기능을 사용가능
- 또한 하위클래스는 상위클래스로 Convert가능

```
class 포유류
    {
        public void 키우다()
        {
            Console.WriteLine("키우다!!");
        }
    }

    class 강아지 : 포유류
    {
        public void 멍멍()
        {
            Console.WriteLine("멍멍!");
        }
    }
    class 고양이 : 포유류
    {
        public void 야옹()
        {
            Console.WriteLine("야옹~");
        }
    }
     static void Main(string[] args)
        {
            포유류 왕 = new 포유류();
            왕.키우다();
            //왕.멍멍(); 불가능
            왕 = new 강아지();
            왕.키우다();
            강아지 구피;

            if (왕 is 강아지)
            {
                구피 = 왕 as 강아지; //41번 줄에 구피에 값이 없어 여기서 값을 지정받음
                구피.멍멍();
                Console.WriteLine("오즈");
            }
         }
```
### 다형성
- Object가 여러모양을 가질 수 있다는 뜻으로 up-casting과 down-casting을 통해 객체를 상위 or 하위클래스로 변환
- 상위 클래스 포유류에서 '왕' 객체를 생성
- '왕.멍멍()'은 불가 (상위클래스에서는 하위클래스 기능 사용불가)
- 왕을 강아지 객체로 변환가능 (상위클래스 형식 객체를 하위클래스로 생성가능) : down-casting
- 강아지객체인 '왕'이 '왕.키우다()' 사용가능 (하위클래스는 상위클래스를 물려받아 확장한 것이므로 상위클래스의 기능을 사용가능)
- 반대로 하위클래스는 상위클래스로 바꾸는게 힘듦 ? up-casting
- '강아지 구피' 를 '구피 = 왕 as 강아지'를 통해 '왕'의 속성 및 기능을 물려받아 객체를 생성
- 이 때 '왕 as 강아지'하기 전 if(왕 is 강아지) 를 통해 down-casting이 되었는지 확인

### 3. OverRiding

```
class ArmorSuite
    {
        public virtual void Initialize()
        {
            Console.WriteLine("ArmorSuite 초기화");
        }
    }

    class IronMan : ArmorSuite
    {
        public override void Initialize()
        {
            base.Initialize();
            Console.WriteLine("IronMan parts 장착");
            Console.WriteLine("IronMan 1기 완료");
        }
    }
```
- 상위클래스(ArmorSuit)에서 지정한 메소드(Initialize)를 하위클래스(IronMan)에서 다시 정의
- base.Initialize()로 상위클래스 내용을 다시 불러올 수도 있다.

### 4. OverLoading
- 하위클래스에서 상위클래스와 동일하게 메소드를 선언하나 내부 일력 형식을 달리하여 생성하는 입력 형식에 따라 클래스를 구분해서 생성

```
private static int Sum(params int [] args)
        {
            int result = 0;
            foreach (int item in args)
            {
                result += item;
            }
            return result;
        }
        #region Plus_overloading
        private static int Plus(int v1, int v2)
        {
            int result = v1 + v2;
            Console.Write("int 오버로딩: ");
            Console.WriteLine($"{result}");
            return result;
        }
        private static float Plus(float v1, float v2)
        {
            float result = v1 + v2;
            Console.Write("float 오버로딩: ");
            Console.WriteLine($"{result}");
            return result;
        }
```
- 배열을 활용하여 입력 갯수와 상관없이 만들 수도 있다. ('private static int Sum(params int [] args)')
 
-------------------------------------
## 6. 인터페이스 와 추상 클래스

- 선언만 하고 구현 내용이 없는 클래스
- 자기 스스로 new를 해서 객체를 생성할 수 없다.
- Extends(추상클래스) 와 Implememts(인터페이스)를 통해서 하위 클래스에서 객체를 생성한다.

```
interface IRunnable
    {
        void Run();
    }
    interface IFlyable
    {
        void Fly();
    }
    class DroneCar : IRunnable, IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("날아!");
        }

        public void Run()
        {
            Console.WriteLine("달려!");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("드론카!");

            DroneCar dreamCar = new DroneCar();
            dreamCar.Run();
            dreamCar.Fly();

            Console.WriteLine("자동차로 변경 (interface)");
            IRunnable car = dreamCar;
            car.Run();
            // car.Fly(); error 

            IFlyable plane = dreamCar;
            plane.Fly();
        }
    }
```

-------------------------------------
## 7. 배열과 Index

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

