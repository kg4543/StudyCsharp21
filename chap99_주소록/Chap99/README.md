# C# Practice (Console_주소록)

## 0. 데이터 받아오기

```
 AddressManager manager = new AddressManager();
 manager.listAddress = new List<AddressInfo>();

 DataFileManager fileManager = new DataFileManager();
 manager.listAddress = fileManager.ReadData();

class DataFileManager
    {
        string dataFileName = "address.dat";

        public List<AddressInfo> ReadData()
        {
            List<AddressInfo> listResult = new List<AddressInfo>();
            var filePath = Environment.CurrentDirectory + "\\" + dataFileName; // 데이터파일 저장 위치 
            StreamReader sr = new StreamReader(new FileStream(filePath, FileMode.Open, FileAccess.Read));
            while (sr.EndOfStream == false)
            {
                var temp = sr.ReadLine();
                //temp 잘라서 manager.listAddress 할당
                string[] splits = temp.Split("|");
                listResult.Add(new AddressInfo() { Name = splits[0], Phone = splits[1], Address = splits[2] });
            }
            sr.Close();

            return listResult;
        }
        ...
 ```
-------------------------------------

## 1. Menu

<kbd>![menu](/chap99_주소록/실행화면/메뉴.PNG "메뉴")</kbd>

```
while (true)
 {
   Console.Clear();

   manager.PrintMenu();
   int menuNum = manager.SelectMenu();
   //Console.WriteLine($"선택된 메뉴번호 : {menuNum}");
     switch (menuNum)
        {
          case 1: //주소입력
          Console.Clear();
          manager.inputAddress();
          break;
          case 2: //주소검색
          Console.Clear();
          manager.SearchAddress();
          break;
          case 3: //주소수정
          Console.Clear();
          manager.UpdateAddress();
          break;
          case 4: //주소삭제
          Console.Clear();
          manager.DeleteAddress();
          break;
          case 5: //주소 전체 출력
          Console.Clear();
          manager.PrintAddress();
          break;
          case 6: // 주소록을 다시 파일에 씀
          fileManager.WriteData(manager.listAddress);
          Environment.Exit(0); //종료
          break;
          default: //0은 여기서
          break;
         }
 }
```
-------------------------------------

## 2. Insert

<kbd>![Insert](/chap99_주소록/실행화면/주소입력.PNG "주소입력")</kbd>
-------------------------------------


## 3. Select
<kbd>![Select](/chap99_주소록/실행화면/주소검색.PNG "주소검색")</kbd>
-------------------------------------


## 4. Update
<kbd>![Update](/chap99_주소록/실행화면/주소수정.PNG "주소수정")</kbd>
-------------------------------------

## 5. Delete
<kbd>![Delete](/chap99_주소록/실행화면/주소삭제.PNG "주소삭제")</kbd>
-------------------------------------

## 6. Select *
<kbd>![Select_all](/chap99_주소록/실행화면/주소전체출력.PNG "주소전체출력")</kbd>
-------------------------------------

## 7. 데이터 저장
-------------------------------------
