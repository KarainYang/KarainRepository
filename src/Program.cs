using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            // locl 用法 http://www.baidu.com/link?url=YNEUp-EYchcvzhU5QFsU--AaF7YjtidrtVUgSIBe8GKY6TkHq-VeSZiPozlZuKMPiepH4jl4ZjOI3t2b6h-tTa&ie=utf-8&f=8&tn=baidu&wd=lock&inputT=745&oq=Lambda

            FindListDelegate();
            Console.ReadLine();

        }
        static void FindListDelegate()
        {
            //先创建一个泛型的List类  
            List<string> list = new List<string>();
            list.AddRange(new string[] { "ASP.NET课程", "J2EE课程", "PHP课程", "数据结构课程" });
            List<string> bookCategory = list.FindAll(s => s.EndsWith("课程"));
           
            foreach (string str in bookCategory)
            {
                Console.WriteLine("{0}\t", str);
            }
        }

    }

}
