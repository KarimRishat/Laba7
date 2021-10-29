using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Metodichka
{
    class Program
    {
        public static string ReverseString(string input)
        {
            return new string(input.Reverse().ToArray());
        }
        public static void GetMail(ref string result)
        {
            result = result.Split('#').Last();
        }
        static bool CheckInterface(Object obj)
        {
            return obj is IFormattable;
        }
        public static void Task2()
        {
            Console.WriteLine("Task2\nВведите строку:");
            string s = Console.ReadLine();
            Console.WriteLine(ReverseString(s));
        }
        public static void Task3()
        {
            string path;
            Console.WriteLine("\nTask3\nВведите имя файла:");
            path = Console.ReadLine();
            if (File.Exists(path))
            {
                string[] test = File.ReadAllLines(path);
                for (int i = 0; i < test.Length; i++)
                {
                    test[i] = test[i].ToUpper();
                }
                File.WriteAllLines("output.txt", test);
            }
            else
            {
                Console.WriteLine("File doesn't exist");
            }
        }
        public static void Task4()
        {
            Console.WriteLine("\nTask4");
            Console.WriteLine(CheckInterface("string"));
            Console.WriteLine(CheckInterface(42));
        }
        public static void Task8_1()
        {
            string path = "1.txt";
            if (File.Exists(path))
            {
                string[] test = File.ReadAllLines(path);
                for (int i = 0; i < test.Length; i++)
                {
                    GetMail(ref test[i]);
                }
                File.WriteAllLines("2.txt", test);
            }
            else
            {
                Console.WriteLine("Ошибка");
            }
        }
        public static void Task8_2()
        {
            List<Song> songs = new List<Song>();
            Console.WriteLine("\nTask8.2\n");
            songs.Add(new Song("Lesnik", "KoroliShut", null));
            songs.Add(new Song("Batarei", "Nervy", songs[0]));
            songs.Add(new Song("Dark Side", "Blind Channel", songs[1]));
            songs.Add(new Song("Batarei", "Nervy", songs[2]));
            songs.Add(new Song("Donelzya", "Vodokachka", songs[3]));
            songs.Add(new Song("ZvezdaPoImeniSolnce", "KINO", songs[4]));
            songs.Add(new Song("Lesnik", "KoroliShut", songs[5]));
            foreach (Song item in songs)
            {
                Console.WriteLine(item.Title());
            }
            int x=0, y=0;
            Console.WriteLine("Какие песни сравнить?:");
            while (!(Int32.TryParse(Console.ReadLine(),out x) && Int32.TryParse(Console.ReadLine(), out y) && x<=songs.Count() && y <=songs.Count()))
            {
                Console.WriteLine("Некорректный ввод");
            }
            if (songs[x].Equals(songs[y]))
            {
                Console.WriteLine("Одна и та же песня");
            }
            else
            {
                Console.WriteLine("Разные песни");
            }
        }
        
        static void Main(string[] args)
        {
            //Task1
            BankAccount alisher = new BankAccount(125.5m);
            alisher.AddMoney(5000.5m);
            BankAccount snejanna = new BankAccount(1,12.5265m);
            snejanna.TakeFrom(ref alisher, 5m);
            alisher.GetInfo();
            snejanna.GetInfo();
            //Task2
            Task2();
            Task3();
            Task4();
            Task8_1();
            Task8_2();
            Console.ReadKey();
        }
    }
}
