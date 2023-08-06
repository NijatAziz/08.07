using System;

namespace Homework
{
    internal static class Extension
    {
        public static bool CustomContains(this string mainText, string searchText)
        {
            string mainLower = mainText.ToLower();
            string searchLower = searchText.ToLower();

            int index = 0;
            foreach (char c in mainLower)
            {
                if (c == searchLower[index])
                {
                    index++;
                    if (index == searchLower.Length)
                        return true;
                }
                else
                {
                    index = 0;
                }
            }

            return false;
        }



        public static string[] CustamSplit(this string sentence,char symbol)
        {
            string symbl = " ";
            string[] arr = new string[0];

            for (int i = 0; i < sentence.Length; i++)
            {
             if (sentence[i]==symbol )
                {
                    Array.Resize(ref arr, arr.Length + 1);
                    arr[arr.Length - 1] = symbl;
                    symbl = string.Empty;
                }
                else
                {
                    symbl += sentence[i];
                }
            }
            Array.Resize(ref arr, arr.Length + 1);
            arr[arr.Length - 1] = symbl;
            return arr;
        }
    }


}
