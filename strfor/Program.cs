using System.Globalization;
using System.Net.Http.Headers;

namespace strfor
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //int[] num = { 12, 4, -7, 36, -27, -2 };
            //MinusPlus(num);  // task-1

            //Console.WriteLine(RepeatString("salam",3)); // task-2

            //Console.WriteLine(StringReverse("madam")); // task-3

            //SameCharacter("salfffffam"); // task-4

            //TersineStr("tagiyev"); // task-5

            //BosluqlariRemove("salam necesen"); // task-6

            //int[] num = {12,64,23,86,3,38,83};
            //Array.Sort(num);
            //foreach (var item in num) // task-7
            //{
            //    Console.WriteLine(item);

            //}


            //IlkFour("salamm");  // task-8






        }
        #region task-1
        //static void MinusPlus(int[] number)
        //{


        //    for (int i = 0; i < number.Length; i++)
        //    {
        //        if (number[i] < 0)
        //        {
        //            number[i] *= -1;
        //        }
        //        Console.WriteLine(number[i]);

        //    }
        //}
        #endregion
        #region task-2
        //static string RepeatString(string word, int count)
        //{
        //    string str = string.Empty;
        //    for (int i = 0; i < count; i++)
        //    {
        //        str += word;
        //    }
        //    return str;

        //}
        #endregion
        #region task-3
        //static string StringReverse(string randomwrd)
        //{
        //    string str= string.Empty;
        //    for (int i =randomwrd.Length - 1; i >= 0; i--)
        //    {
        //        str+= randomwrd[i]; 
        //    }
        //    if (str == randomwrd)
        //    {
        //        return "Sozler Palindromedir";
        //    }
        //    else
        //    {
        //        return "Sozler Palindrome deyil";
        //    }           
        //}
        #endregion
        #region task-4
        //static void SameCharacter(string word)
        //{
        //    string newStr=string.Empty;
        //    for (int i = 0; i < word.Length; i++)
        //    {
        //        int count = 0;
        //        for (int j = 0; j < word.Length; j++)
        //        {
        //            if (word[i] == word[j])
        //            {
        //                count++;
        //            }
        //        }
        //        if (count == 1)
        //        {
        //            newStr += word[i];
        //        }
        //    }
        //    Console.WriteLine(newStr);
        //}
        #endregion
        #region task-5
        //static void TersineStr(string word)
        //{

        //    if (string.IsNullOrWhiteSpace(word))
        //    {
        //        Console.WriteLine("dolu string yaz");

        //    }
        //    else
        //    {
        //        for (int i = word.Length - 1; i >= 0; i--)
        //        {


        //            Console.WriteLine(word[i]);

        //        }
        //    }

        //}
        #endregion
        #region task-6
        //static void BosluqlariRemove(string metn)
        //{
        //    string[] words = metn.Split(new char[] {' '});
        //    foreach (string word in words)
        //    {
        //        Console.WriteLine(word);
        //    }
        //}
        #endregion
        #region task-7 Main icinde.
        #endregion
        #region task-8
        //static void IlkFour(string word)
        //{
        //    string newWord = String.Empty;

        //    for (int i = 0; i < word.Length; i++)
        //    {
        //        if (i <= 3)
        //        {
        //            newWord += word[i];
        //            continue;
        //        }
        //        break;
        //    }
        //    Console.WriteLine(newWord);            
        //}
        #endregion


    }
}
