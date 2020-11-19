using System;

namespace LanguageMain
{
    class Program
    {
        static void Main(string[] args)
        {
            CSharpLib.TestDemo testcsharp = new CSharpLib.TestDemo();
            testcsharp.GetFullName("Lindsey", "Nicole", "Weber");
            var resCsharp = testcsharp.LoadFile();
            Console.WriteLine(resCsharp);
            

            Console.WriteLine("~~~~~~~~~~~~");

            VbLib.TestDemo testvb = new VbLib.TestDemo();
            testvb.GetFullName("Joseph", "Arnold", "Petrie");
            var resVb = testvb.LoadFile();
            Console.WriteLine(resVb);
            


        }
    }
}
