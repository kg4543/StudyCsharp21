using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap15
{
    class Profile
    {
        public string Name { get; set; }
        public short Height { get; set; }

    }

    class Product
    {
        public string Title { get; set; }
        public string Star { get; set; }

    }

    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 9, 2, 6, 4, 5, 3, 7, 8, 1, 10}; //10배열
            /*List<int> result = new List<int>();

            foreach (var item in numbers)
            {
                if(item % 2 == 0)
                {
                    result.Add(item);
                }
            }
            result.Sort();*/

            //LINQ 사용
            var result = from item in numbers
                         where item % 2 == 0
                         orderby item
                         select item;

            foreach (var item in result)
            {
                Console.WriteLine($"짝수 : {item}");
            }

            List<Profile> profiles = new List<Profile>();
            profiles.Add(new Profile() { Name = "정우성", Height = 186 });
            profiles.Add(new Profile() { Name = "김태희", Height = 158 });
            profiles.Add(new Profile() { Name = "고현정", Height = 172 });
            profiles.Add(new Profile() { Name = "이문세", Height = 178 });
            profiles.Add(new Profile() { Name = "하하", Height = 171 });

            List<Product> products = new List<Product>();
            products.Add(new Product() { Title = "C_IT", Star = "정우성" });
            products.Add(new Product() { Title = "K_뷰티", Star = "김태희" });
            products.Add(new Product() { Title = "D_자동차", Star = "고현정" });
            products.Add(new Product() { Title = "A_제약", Star = "이문세" });

            var resProfiles = from item in profiles
                              where item.Height < 175
                              orderby item.Height descending /*ascending*/
                              select new
                              {
                                  Name = item.Name,
                                  Height = item.Height,
                                  InchHeight = item.Height * 0.393
                              };

            foreach (var item in resProfiles)
            {
                Console.WriteLine($"{item.Name}, {item.Height}cm, {item.InchHeight}Inch");
            }

            var resProfiles2 = from item in profiles
                               where item.Height < 175
                               orderby item.Height descending /*ascending*/
                               select item.Name;
            foreach (var item in resProfiles)
            {
                Console.WriteLine($"{item}");
            }

            //group by
            var resProfiles3 = from item in profiles
                               orderby item.Height
                               group item by item.Height < 175 into g
                               select new
                               {
                                   GroupKey = g.Key,
                                   Items = g
                               };

            foreach (var group in resProfiles3)
            {
                Console.WriteLine($"175cm 미만 그룹 : {group.GroupKey}");

                foreach (var item in group.Items)
                {
                    Console.WriteLine($"{item.Name}, {item.Height}cm");
                }
            }

            var joinProfile = from p in profiles
                              join d in products
                              on p.Name equals d.Star
                              select new
                              {
                                  Name = p.Name,
                                  Work = d.Title,
                                  InchHeight = p.Height * 0393
                              };
            Console.WriteLine("외부조인");
            foreach (var item in joinProfile)
            {
                Console.WriteLine($"이름: {item.Name}, CF:{item.Work} 키:{item.InchHeight}inch");
            }

            var joinProfile2 = from p in profiles
                              join d in products
                              on p.Name equals d.Star into ps
                              from d2 in ps.DefaultIfEmpty(new Product() { Title = "작품없음" })
                              select new
                              {
                                  Name = p.Name,
                                  Work = d2.Title,
                                  InchHeight = p.Height * 0393
                              };
            Console.WriteLine("내부조인");
            foreach (var item in joinProfile)
            {
                Console.WriteLine($"이름: {item.Name}, CF:{item.Work} 키:{item.InchHeight}inch");
            }
        }
    }
}
