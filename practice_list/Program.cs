using System;
using System.Collections.Generic;

namespace practice_list
{
    class Program
    {
        static void Main(string[] args)
        {
            //listの使い方
            //空のリストを宣言

            var name_list = new List<string> {};
            var old_list = new List<int> {};

            Console.WriteLine("今日は何人で来ましたか");
            var count = Console.ReadLine();


            for(int x=1;x<=int.Parse(count); x++)
            {
                Console.WriteLine($"{x}人目の名前を入力してください");
                var input1 = Console.ReadLine();
                name_list.Add(input1);

                Console.WriteLine($"{x}人目の年齢を入力してください");
                var input2 = Console.ReadLine();
                old_list.Add(int.Parse(input2));

            }


            foreach (var i in name_list)
            {
                Console.WriteLine(i);
            }
            foreach (var i in old_list)
            {
                Console.WriteLine(i);
            }

            old_list.Remove(12);

            foreach (var i in old_list)
            {
                Console.WriteLine(i);
            }

            //LinkedListはインデックス値から読み書き不可。最初と最後へのアクセスは速い
            var meals = new[] {"①肉じゃが","②ハンバーグ","③からあげ" };
            //配列を引数にするのもOK
            var meals_list = new LinkedList<string>(meals);
            foreach (var m in meals_list)
            {
                Console.WriteLine(m);
            }
            meals_list.AddFirst("④アジフライ");
            meals_list.AddLast("⑤ナポリタン");
            meals_list.AddAfter(meals_list.First,"⑥きんぴらごぼう");
            meals_list.AddBefore(meals_list.Last,"⑦おでん");
            foreach (var m in meals_list)
            {
                Console.WriteLine(m);
            }
            meals_list.Clear();

            //Stack（後入れ先出し）について
            //Pushで押し込み、Popで取り出して削除、Peekはちらっと覗く
            var s = new Stack<int>();
            s.Push(10);
            s.Push(20);
            s.Push(30);
            Console.WriteLine($"要素数{s.Count}個");
            Console.WriteLine(s.Peek());
            Console.WriteLine(s.Pop());

            Console.WriteLine($"要素数{s.Count}個");
            if (s.Contains(20))
            {
                Console.WriteLine(s.Peek());

            }
            var a = s.ToArray();
            Console.WriteLine(String.Join(",",a));

            //Queue（先入れ先出し）
            var q = new Queue<string>();
            q.Enqueue("豆腐");
            q.Enqueue("牛乳");
            q.Enqueue("人参");
            if (q.Contains("豆腐"))
            {
                q.Dequeue();
            }
            Console.WriteLine(String.Join("&",q.ToArray()));
        }
    }
}
