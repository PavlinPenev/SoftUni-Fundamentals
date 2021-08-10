using System;

namespace RefactoringPrimeChecker
{
    class RefactoringPrimeChecker
    {
        static void Main(string[] args)
        {
            int ___Do___ = int.Parse(Console.ReadLine());
            for (int takoa = 2; takoa <= ___Do___; takoa++)
            {
                bool takovalie = true;
                for (int cepitel = 2; cepitel < takoa; cepitel++)
                {
                    if (takoa % cepitel == 0)
                    {
                        takovalie = false;
                        break;
                    }
                }
                string boolean = takovalie.ToString().ToLower();
                Console.WriteLine("{0} -> {1}", takoa, boolean);
            }
        }
    }
}
