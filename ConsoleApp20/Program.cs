using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ConsoleApp20
{
    class Program
    {
        static void Task1()
        {
            char[] mas;
            List<int> mas2 = new List<int>();

            using (FileStream stream = new FileStream(@"C:\Users\madik\Documents\Visual Studio 2017\projects\ConsoleApp20\INPUT1.txt", FileMode.Open))
            {
                byte[] bytes = new byte[stream.Length];
                stream.Read(bytes, 0, bytes.Length);
                mas = Encoding.UTF8.GetChars(bytes);

                for(int i=0;i<bytes.Length;i++)
                {
                    if(mas[i]!=' ')
                    {
                        mas2.Add((int)Char.GetNumericValue(mas[i]));
                    }
                }

                for(int j=0;j<bytes.Length;j++)
                {
                    int next = mas2.Last() + mas2.ElementAt(mas2.Count - 2);
                    mas2.Add(next);
                    mas2.TrimExcess();
                }
            }

            using (StreamWriter stream = new StreamWriter(@"C:\Users\madik\Documents\Visual Studio 2017\projects\ConsoleApp20\OUTPUT1.txt"))
            {
                foreach (var value in mas2)
                {
                   stream.WriteLine(value);
                }
            }

            foreach (var value in mas2)
            {
                 Console.WriteLine(value);
            }

        }
        static void Task2()
        {
            char[] mas;
            List<int> mas2 = new List<int>();
            int sum = 0;

            using (FileStream stream = new FileStream(@"C:\Users\madik\Documents\Visual Studio 2017\projects\ConsoleApp20\INPUT2.txt", FileMode.Open))
            {
                byte[] bytes = new byte[stream.Length];
                stream.Read(bytes, 0, bytes.Length);
                mas = Encoding.UTF8.GetChars(bytes);

                for (int i = 0; i < mas.Length; i++)
                {
                    if (mas[i] != ' ')
                    {
                        mas2.Add((int)Char.GetNumericValue(mas[i]));
                        sum += (int)Char.GetNumericValue(mas[i]);
                    }
                }
            }

            using (StreamWriter stream = new StreamWriter(@"C:\Users\madik\Documents\Visual Studio 2017\projects\ConsoleApp20\OUTPUT2.txt"))
            {
                stream.WriteLine(sum);
            }
        
        }
        static void Main(string[] args)
        {
            Task1();
            Task2();
            Console.ReadLine();
        }
    }
}
