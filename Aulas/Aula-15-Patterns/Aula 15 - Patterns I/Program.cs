/* 
 * lufer
 * Patterns: SingleTon
 * **/
using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns
{
    class Program
    {
        static void Main(string[] args)
        {

            Singleton s = Singleton.Instance;

            Singleton s1 = Singleton.Instance;

            s.doSomething();
        }
    }
}
