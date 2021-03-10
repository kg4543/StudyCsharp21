# C# Practice (Console_주소록)

* 사용자 정보를 입력,검색,수정,삭제할 수 있는 기능 구현
* 종료 시 입력되있는 정보를 문서파일을 생성시켜 저장
* 시작 시 정보가 저장되어 있는 문서파일을 열어 데이터를  

## 0. 데이터 받아오기

```
class MAinApp
    {
        static void Main(string[] args)
        {
                AddressManager manager = new AddressManager();
                manager.listAddress = new List<AddressInfo>();

                DataFileManager fileManager = new DataFileManager();
                manager.listAddress = fileManager.ReadData();
        }
     }
     
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
```
public void inputAddress()
        {
            Console.WriteLine("주소입력");
            Console.WriteLine("----------------------------------------");
            Console.Write("이름 입력 : ");
            string name = Console.ReadLine();
            Console.Write("전화입력 : ");
            string phone = Console.ReadLine();
            Console.Write("주소입력 : ");
            string address = Console.ReadLine();

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(phone))
            {
                Console.WriteLine("빈값은 입력할 수 없습니다.");
                Console.ReadLine();
            }
            else
            {
                listAddress.Add(new AddressInfo() { Name = name, Phone = phone, Address = address });
            }
        }
```
-------------------------------------


## 3. Select
<kbd>![Select](/chap99_주소록/실행화면/주소검색.PNG "주소검색")</kbd>
```
public void SearchAddress()
        {
            Console.WriteLine("주소검색");
            Console.WriteLine("----------------------------------------");
            Console.Write("이름 입력 : ");
            string name = Console.ReadLine();
            int idx = 0;
            bool isFind = false; // 검색된 이름이 있는지?
            foreach (var item in listAddress)
            {
                if (item.Name == name)
                {
                    isFind = true; //찾음
                    Console.WriteLine();
                    Console.WriteLine($"[{idx}]-------------------------------------");
                    Console.WriteLine($"이름 : {item.Name}");
                    Console.WriteLine($"전화 : {item.Phone}");
                    Console.WriteLine($"주소 : {item.Address}");
                    Console.WriteLine("----------------------------------------");
                    break; //foreach를 빠져나감
                }
                idx++;
            }
            if (isFind == false)
            {
                Console.WriteLine("검색결과가 없습니다.");
            }
            Console.ReadLine(); //화면멈춤
        }
```
-------------------------------------


## 4. Update
<kbd>![Update](/chap99_주소록/실행화면/주소수정.PNG "주소수정")</kbd>
```
public void UpdateAddress()
        {
            Console.WriteLine("주소수정");
            Console.WriteLine("----------------------------------------");
            Console.Write("이름 입력 : ");
            string name = Console.ReadLine();
            int idx = 0;
            bool isFind = false; // 검색된 이름이 있는지?
            foreach (var item in listAddress)
            {
                if (item.Name == name)
                {
                    isFind = true; //찾음
                    Console.WriteLine("");
                    Console.WriteLine($"[{idx}]-------------------------------------");
                    Console.WriteLine($"이름 : {item.Name}");
                    Console.WriteLine($"전화 : {item.Phone}");
                    Console.WriteLine($"주소 : {item.Address}");
                    Console.WriteLine("----------------------------------------");


                    Console.Write("이름 재입력 : ");
                    string uName = Console.ReadLine();
                    Console.Write("전화 재입력 : ");
                    string uPhone = Console.ReadLine();
                    Console.Write("주소 재입력 : ");
                    string uAddress = Console.ReadLine();

                    if (string.IsNullOrEmpty(uName) || string.IsNullOrEmpty(uPhone))
                    {
                        Console.WriteLine("빈값은 입력할 수 없습니다.");
                        Console.ReadLine();
                    }
                    else
                    {
                        item.Name = uName;
                        item.Phone = uPhone;
                        item.Address = uAddress;
                    }
                    break; //foreach를 빠져나감
                }
                idx++;
            }
            if (isFind == false)
            {
                Console.WriteLine("검색결과가 없습니다.");
            }
            Console.ReadLine();
        }
```
-------------------------------------

## 5. Delete
<kbd>![Delete](/chap99_주소록/실행화면/주소삭제.PNG "주소삭제")</kbd>
```
public void DeleteAddress()
        {
            Console.WriteLine("주소검색");
            Console.WriteLine("----------------------------------------");
            Console.Write("이름 입력 : ");
            string name = Console.ReadLine();
            int idx = 0;
            bool isFind = false;
            foreach (var item in listAddress)
            {
                if (item.Name == name)
                {
                    isFind = true;
                    Console.WriteLine($"[{idx}]-------------------------------------");
                    Console.WriteLine($"이름 : {item.Name}");
                    Console.WriteLine($"전화 : {item.Phone}");
                    Console.WriteLine($"주소 : {item.Address}");
                    Console.WriteLine("----------------------------------------");
                    Console.WriteLine("정말 삭제하시겠습니까? [Y/N]");
                    string answer = Console.ReadLine();
                    if (answer.ToLower() == "y")
                    {
                        listAddress.RemoveAt(idx);
                        Console.WriteLine("삭제되었습니다.");
                    }
                    break; //foreach를 빠져나감
                }
                idx++;
            }
            if (isFind == false)
            {
                Console.WriteLine("검색결과가 없습니다.");
            }
            Console.ReadLine();
        }
```
-------------------------------------

## 6. Select *
<kbd>![Select_all](/chap99_주소록/실행화면/주소전체출력.PNG "주소전체출력")</kbd>
```
public void PrintAddress()
        {
            int idx = 0;
            if (listAddress.Count == 0)
            {
                Console.WriteLine("주소록이 없습니다.");
            }
            else
            {
                foreach (var item in listAddress)
                {
                    Console.WriteLine($"[{idx}]-------------------------------------");
                    Console.WriteLine($"이름 : {item.Name}");
                    Console.WriteLine($"전화 : {item.Phone}");
                    Console.WriteLine($"주소 : {item.Address}");
                    Console.WriteLine("----------------------------------------");
                    Console.WriteLine();
                    idx++;
                }
            }
            Console.ReadLine();
        }
```
-------------------------------------

## 7. 데이터 저장
```
public void WriteData(List<AddressInfo> list)
        {
            var filePath = Environment.CurrentDirectory + "\\" + dataFileName; // 데이터파일 저장 위치 
            StreamWriter sw = new StreamWriter(
                           new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Write)
                           );
            if (list.Count > 0)
            {
                foreach (var item in list)
                {
                    sw.WriteLine($"{item.Name}|{item.Phone}|{item.Address}");
                }
            }
            sw.Close();
        }
```
-------------------------------------
