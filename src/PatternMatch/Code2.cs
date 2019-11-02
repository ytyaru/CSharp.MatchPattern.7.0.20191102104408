using System;

namespace PatternMatch
{
    // varパターン
    class Code2
    {
        public void Run()
        {
            Console.WriteLine("===== Code2 =====");
            Console.WriteLine($"{Run0(0)}"); // 0
            Console.WriteLine($"{Run0("ABC")}"); // 3
            Console.WriteLine($"{Run0(9999)}"); // 4
            Console.WriteLine($"{Run0(null)}"); // 4

            Run1(9);
            Run1("ABC");
            Run1('Z');
            Run1(DateTime.Now);

            Run2();
        }
        private int Run0(object x)
        {
            switch (x)
            {
                // 定数パターン
                case 0: return 0;
                // 宣言パターン
                case string s: return s.Length;
                // varパターンはnullにもヒットしてしまいNullReferenceExceptionになるのでここで回避
                case null: return -1;
                // varパターン（nullにもヒットしてしまう！）
                case var v: return v.ToString().Length;
            }
        }
        private void Run1(object x)
        {
            if (x is var v) { Console.WriteLine("何かしらの型。絶対ヒットする。nullすらも。"); }
            else { Console.WriteLine("何の型でもない。ヒットしえない。"); }
        }
        private void Run2()
        {
            if (GetStr() is var line && !string.IsNullOrEmpty(line))
            {
                Console.WriteLine(line);
            } else { Console.WriteLine("nullか空文字列のいずれか。"); }
        }
        private string GetStr() => "なんか適当な文字列";
    }
}
