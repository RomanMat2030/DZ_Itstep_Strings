using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //Task.1
            //string StrArr = "Привіт світ ! ";
            //Console.WriteLine(StrArr.Length);
            //Console.WriteLine("Enter word to insert: ");
            //string message = Console.ReadLine();

            //Console.WriteLine("Введи індекс: ");
            //int indexOfChar = int.Parse(Console.ReadLine());

            //StrArr = StrArr.Insert(indexOfChar, message);
            //Console.WriteLine(StrArr);
            //Task.2
            //string wordArr = "pop";
            //bool flag = false;
            //Console.WriteLine(wordArr.Length);
            //for (int i = 0; i < wordArr.Length; i++)
            //{
            //    if (wordArr[i] == wordArr[wordArr.Length - i - 1])
            //    {
            //        flag = true;
            //    }
            //    else
            //    {
            //        flag = false;
            //    }
            //}
            //if (flag == true)
            //{
            //    Console.WriteLine("Is palidrome!");
            //}
            //else
            //{
            //    Console.WriteLine("Is not palidrome!");
            //}
            //Task.3
            //string text = "Sample Text With Uppercase And Lowercase Letters";
            //int countUpper = 0;
            //int countLower = 0;
            //Console.WriteLine("Total letter: "+text.Length);
            //foreach (char c in text)
            //{
            //    if (char.IsUpper(c)) countUpper++;
            //    if (char.IsLower(c)) countLower++;
            //}
            //char.IsLower(text[0]);
            //double upperPercen = (double)countUpper / text.Length * 100;
            //double lowerPercen = (double)countLower / text.Length * 100;
            //Console.WriteLine("Count Upper: " + countUpper);
            //Console.WriteLine("Count Lower: " + countLower);
            //Console.WriteLine("Percentage of upper letters: " + upperPercen.ToString("0.0")+"%");
            //Console.WriteLine("Percentage of lower letters: " + lowerPercen.ToString("0.0") +"%");

            //Task 4
            //string[] strarr = { "pizza", "fish", "shaurma", "cat", "bike" };
            //Console.WriteLine(strarr.Length);
            //int targetLength = int.Parse(Console.ReadLine());
            //for (int i = 0; i < strarr.Length; i++)
            //{
            //    if (strarr[i].Length == targetLength)
            //    {
            //        strarr[i] = strarr[i].Substring(0, targetLength - 3)+ "$";
            //    }
            //}
            //Console.Write("Result: ");
            //foreach (string str in strarr) 
            //{
            //    Console.WriteLine(str);
            //}
            //Task 5
            //string text = "Hello my friend!"; 
            //Console.WriteLine(text.Length);
            //int wordNumber = int.Parse(Console.ReadLine());

            //string[] words = text.Split(new char[] { ' ', ',', '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

            //if (wordNumber > 0 && wordNumber <= words.Length)
            //{
            //    string word = words[wordNumber - 1];
            //    char firstLetter = word[0];
            //    Console.WriteLine("The first letter of the search word: " + firstLetter);
            //}
            //else
            //{
            //    Console.WriteLine("Word with the specified number was not found.");
            //}
            //Task 6
            //string strarr = "   Дано   рядок   слів,  розділених   пробілами.   ";

            //strarr = strarr.Trim();

            //var coll = strarr.Split(new char[] { ' ', ',', '\n', '?', '!' }, StringSplitOptions.RemoveEmptyEntries);
            //foreach (var item in coll) 
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine(string.Join('*', coll));

            //Task 7

            StringBuilder stringBuilder = new StringBuilder();
            string str;
            Console.WriteLine("Enter text: ");

            do
            {
                str = Console.ReadLine();
                if (str != ".")
                {
                    stringBuilder.Append(str);
                    stringBuilder.Append(", ");
                }
            } while (str[str.Length - 1] != '.');
            
            if (stringBuilder.Length > 0)
            {
                stringBuilder.Length -= 2;
            }

            Console.WriteLine("Result: " + stringBuilder.ToString());
        }
    }
}