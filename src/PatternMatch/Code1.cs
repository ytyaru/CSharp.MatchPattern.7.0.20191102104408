using System;

namespace PatternMatch
{
    // 定数パターン
    class Code1
    {
        public void Run()
        {
            Console.WriteLine("===== Code1 =====");
            Run0(5);
            Run0(4);
            Run0("A");
            Run0(null);

            Run1("キーワード");
            Run1("A");
            Run1(null);

            Console.WriteLine($"{Run2(1)}"); // 1
            Console.WriteLine($"{Run2("ABC")}"); // 3
            Console.WriteLine($"{Run2('A')}"); // -1
            Console.WriteLine($"{Run2(null)}"); // -1
            string s = null;
            Console.WriteLine($"{Run2(s)}"); // -1

            Console.WriteLine($"{Run3(8, 8)}"); // 0
            Console.WriteLine($"{Run3(8, 7)}"); // -1
            Console.WriteLine($"{Run3("ABC")}");
            Console.WriteLine($"{Run3(s)}");
        }
        private void Run0(object x)
        {
            if (x is 5) { Console.WriteLine("5である"); }
            else { Console.WriteLine("5でない"); }
        }
        private void Run1(object x)
        {
            if (x is "キーワード") { Console.WriteLine("キーワードである"); }
            else { Console.WriteLine("キーワードでない"); }
        }
        private int Run2(object x)
        {
            switch (x)
            {
                // 定数パターン
                case 0: return 0;
                // 宣言パターン
                case int i: return i;
                case string s: return s.Length;
                default: return -1;
            }
        }
        private int Run3(object x, int comparand=0)
        {
            switch (x)
            {
                // 定数パターン
                case 0: return 0;
                // 宣言パターン
                case int i when i == comparand: return 0;
                case string s: return s.Length;
                default: return -1;
            }
        }
    }
}
