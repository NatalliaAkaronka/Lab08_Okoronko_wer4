using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab08_Okoronko_wer4
{
    class Program
    {
        static StreamReader ввод = new StreamReader("Строки.txt");
        static StreamWriter вывод = new StreamWriter("Names.txt");
        static void Main(string[] args)
        {
            string way;
            while ((way= ввод.ReadLine()) !=null)
            {
                string way2 = way.Remove(way.Length - 4);
                //Console.WriteLine(way2);
                string[] words = way2.Split('\\');
                int number = words.Length;
                //Console.WriteLine(words[number - 1]);
                вывод.WriteLine(words[number - 1]+" ");
            }

            
            вывод.Close();
            Console.WriteLine("Нажмите Enter для обработки результатов.");
            Console.ReadLine();
        }
    }
}
