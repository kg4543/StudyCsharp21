using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.IO;

using System.Threading;

namespace Hangman

{

    class Program

    {

        //전역변수 

        static int person = 0;

        static String answer = "";

        static string[] c = answer.Split(new char[answer.Length]);

        //d를 char 배열로 선언합니다.

        static char[] d = new char[answer.Length];

        static String Tmpanswer = "";

        static void Main(string[] args)

        {





            Console.WriteLine("행맨게임을 하러오셧군요!");

            ALLProcess();









            // Console.ReadLine();



        }

        static void ALLProcess()

        {

            //숫자설정

            InputPlayUser();

            //문제설정

            InputQnswer();



            Console.WriteLine("게임을 시작합니다.");

            //플레이어들끼리 반복되며 정답 맞추기

            UserAnswerGame();



        }

        static void UserAnswerGame()

        {

            int xx = 1;

            while (true)

            {

                Console.WriteLine("유저" + xx + " 님 한글자를 입력바랍니다.  ");

                string User1Char = Console.ReadLine();



                if (User1Char.Length != 1)

                {

                    Console.WriteLine("한글자만 입력바랍니다.");

                    Console.WriteLine("기회를 박탈당했습니다. 다음 턴을 기다리십시오.");

                }
                else

                {

                    //한글자만 잘 입력한 경우~

                    //정답과 입력 정답 비교해서 보여주깅

                    bool AnswerContainCheck;

                    AnswerContainCheck = answer.Contains(User1Char);

                    Console.WriteLine(AnswerContainCheck);



                    if (AnswerContainCheck == true)

                    {

                        //Console.WriteLine(d.Length);

                        //break;

                        for (int i = 0; i < answer.Length; i++)

                        {

                            if (answer[i] != User1Char[0])

                            {

                                continue;

                            }

                            else

                            {

                                d[i] = User1Char[0];

                            }

                        }



                    }



                    Tmpanswer = "";

                    for (int p = 0; p < answer.Length; p++)

                    {

                        Tmpanswer += d[p];

                    }

                    Console.WriteLine("단어 :  " + Tmpanswer);



                    //단어를 다 맞췃을 경우 --> 새게임을 시작할지 , 종료할지

                    Boolean TmpanswerContainCheck = Tmpanswer.Contains('■');

                    if (TmpanswerContainCheck == false)

                    {

                        Console.WriteLine("정답을 맞추셧습니다.");

                        NewGameSetup();

                        break;

                    }

                }

                //User1Char

                if (xx == person)

                {

                    //1바퀴 더 돌건지 종료할건지

                    Console.WriteLine("한바퀴를 다 돌았습니다.");

                    UserAnswerGame();

                    break;

                }

                xx++;



            }

        }

        static void NewGameSetup()

        {

            Console.WriteLine("다시 게임을 시작하시겠습니까?");

            Console.WriteLine("Y/N (Y 이외의 키는 종료됩니다.)");

            String GameSetYN = Console.ReadLine();

            if (GameSetYN == "Y")

            {

                ALLProcess();

            }

            else

            {



                return;

            }

        }

        static void InputQnswer()

        {

            Console.WriteLine("정답을 설정해주세요.");

            answer = Console.ReadLine();



            c = answer.Split(new char[answer.Length]);

            //d를 char 배열로 선언합니다.

            d = new char[answer.Length];



            for (int i = 0; i < answer.Length; i++)

            {

                d[i] = '■';

            }



        }

        static void InputPlayUser()

        {

            Console.WriteLine("게임 플레이어를 적어주세요.");

            string prsn = Console.ReadLine();

            int numChk = 0;

            bool isNum = int.TryParse(prsn, out numChk);

            if (!isNum)

            {

                Console.WriteLine("게임 플레이어를 숫자만 적어주세요.");



                InputPlayUser();

            }

            else

            {

                person = int.Parse(prsn);

                Console.WriteLine(person + "명 이서 플레이를 합니다.");

            }



        }

    }


}
