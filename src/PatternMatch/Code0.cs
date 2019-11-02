using System;

namespace PatternMatch
{
    // 宣言パターン
    class Code0
    {
        public void Run()
        {
            Console.WriteLine("===== Code0 =====");
            Run0(1);
            Run0("ABC");
            Run0('A');
            Run0(null);
            string s = null;
            Run0(s);
        }
        private void Run0(object x)
        {
            if (x is int i) { Console.WriteLine("int型"); }
            else if (x is string s) { Console.WriteLine("string型"); }
            else  { Console.WriteLine("int,string以外の型"); }
        }
    }
}
