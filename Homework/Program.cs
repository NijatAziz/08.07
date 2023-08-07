using Homework;

internal class Program
{
    private static void Main()
    {
        //string mainText = "Bu bir custom contains methodudur";
        //string searchText = "xx";
        //bool contains = mainText.CustomContains(searchText);
        //Console.WriteLine($"'{searchText}' cumlede ardicil olaraq varmi? {contains}");



        string sentence = "Bu bir custom,split methodudur";
        string[] words = sentence.CustamSplit('b');
        foreach (string word in words)
        {
            Console.WriteLine(word);
        }

    }
}
