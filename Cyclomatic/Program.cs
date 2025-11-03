namespace Cyclomatic
{
    static class Program
    {
        static void Main(string[] args)
        {




            int[] a = { 15, 28, 72, 95, 36, 80, 66, 45, 29, 19, 21, 12, 41, 37, 60, 11, 49, 94, 40, 62,
                        85, 56, 70, 90, 50, 64, 16, 47, 87, 30, 76, 63, 57, 18, 91, 73, 68, 52, 78, 10,
                       };

            int it = BogoSort(a);
            Console.WriteLine("Sorted array:");
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine($"{i}: {a[i]}");
            }
            Console.WriteLine($" iteration : {it}");
        }

        static int  BogoSort(int[] a)
        {
            int ct = 0;
            int n = a.Length;
            while (SortCheck(a) == false)
            {
                Shuffle(a);
                ct++;
                Console.WriteLine($" iteration : {ct} : {string.Join(", ", a)}");
            }
            return ct;
        }

        static bool SortCheck(int[] a)
        {
            bool rt = true; 
            int n = a.Length;
            for (int i = 0; i < n - 1; i++)
            {
                if (a[i] > a[i + 1])
                {
                    rt = false;
                    break;
                }
            }
            return rt;
        }

        static void Shuffle(int[] a)
        {
            Random rnd = new Random();
            int n = a.Length;

            for (int i = 0; i < n; i++)
            {
                int r = rnd.Next(0, n);
                int tmp = a[i];
                a[i] = a[r];
                a[r] = tmp;
            }
        }
    }
}
