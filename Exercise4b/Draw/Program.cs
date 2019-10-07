using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draw
{
    class Program
    {
        static void Main(string[] args)
        {

            VlineLetters(4, "i");
            Console.WriteLine();
            DrawRectangle(4, "o");
            Console.WriteLine();
            DrawRectangle1(4, "o");
            Console.WriteLine();
            DrawletterU(5, "U");
            Console.WriteLine();
            DrawLettersV(4, "v");
            Console.WriteLine();
            DrawTrilangleV(4, "V");
            Console.WriteLine();
            DrawTrilangleA(4, "A");
            Console.WriteLine();
            DrawLettersW(4, "W");
            Console.ReadLine();

        }
        // a.

        static void VlineLetters(int a, string s)
        {
            for (int i = 0; i < a; i++)
            {
                Console.WriteLine(s);

            }
        }

        // b.

        static void DrawRectangle(int b, string s)
        {
            for (int j = 0; j < b; j++)
            {
                for (int i = 0; i < b; i++)
                {
                    Console.Write(s);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }

        // c.

        static void DrawRectangle1(int b, string s)
        {
            for (int j = 1; j <= b; j++)
            {
                for (int i = 1; i <= b; i++)
                {
                    if ((j != 1 && i != 1))
                    {
                        if (j != b && i != b)
                        {
                            Console.Write(" ");
                            Console.Write(" ");
                        }
                        else
                        {
                            Console.Write(s);
                            Console.Write(" ");
                        }
                    }
                    else
                    {
                        Console.Write(s);
                        Console.Write(" ");
                    }


                }
                Console.WriteLine();
            }
        }


        static void HlineTemp(int n, String s)
        {
            for (int i = 1; i <= n; i++)
            {
                Console.Write(s);
            }
        }
        // d.
        static void DrawletterU(int n, String s)
        {
            for (int i = 0; i < n - 1; i++)
            {
                HlineTemp(1, s);
                HlineTemp(n - 2, " ");
                HlineTemp(1, s);
                Console.WriteLine();
            }
            HlineTemp(n, s);

        }

        // e.

        static void DrawLettersV(int n, string s)
        {
            HlineTemp(1, s);
            HlineTemp(2 * n - 3, " ");
            HlineTemp(1, s);
            Console.WriteLine();
            int a = 5;
            int b = 1;
            for (int i = 1; i <= n - 2; i++)
            {
                HlineTemp(b, " ");
                HlineTemp(1, s);
                HlineTemp(2 * n - a, " ");
                HlineTemp(1, s);
                HlineTemp(b, " ");
                Console.WriteLine();
                a = a + 2;
                b = b + 1;
            }
            HlineTemp(n - 1, " ");
            HlineTemp(1, s);
            HlineTemp(n - 1, " ");

        }

        // f.


        static void DrawTrilangleV(int n, string s)
        {
            HlineTemp(2 * n - 1, s);
            Console.WriteLine();
            int a = 5;
            int b = 1;
            for (int i = 1; i <= n - 2; i++)
            {
                HlineTemp(b, " ");
                HlineTemp(1, s);
                HlineTemp(2 * n - a, " ");
                HlineTemp(1, s);
                HlineTemp(b, " ");
                Console.WriteLine();
                a = a + 2;
                b = b + 1;
            }
            HlineTemp(n - 1, " ");
            HlineTemp(1, s);
            HlineTemp(n - 1, " ");

        }

        // g.

        static void DrawTrilangleA(int n, string s)
        {
            HlineTemp(n - 1, " ");
            HlineTemp(1, s);
            HlineTemp(n - 1, " ");
            Console.WriteLine();
            int a = 1;
            int b = n - 2;
            for (int i = 1; i <= n - 2; i++)
            {
                HlineTemp(b, " ");
                HlineTemp(1, s);
                HlineTemp(a, " ");
                HlineTemp(1, s);
                HlineTemp(b, " ");
                Console.WriteLine();
                a = a + 2;
                b = b - 1;

            }
            HlineTemp(2 * n - 1, s);

        }

        // h.

        static void DrawLettersW(int n, string s)
        {
            HlineTemp(1, s);
            HlineTemp(2 * n - 3, " ");
            HlineTemp(1, s);
            HlineTemp(2 * n - 3, " ");
            HlineTemp(1, s);
            Console.WriteLine();
            int a = 5;
            int b = 1;
        }
    }
}