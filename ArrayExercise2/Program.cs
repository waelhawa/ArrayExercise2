using System;

namespace ArrayExercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "wael", "isha", "anna", "anthony", "david", "george" };
            string[] arrangedNames = new string[names.Length];
            string[] arrangedLettersInNames = new string[names.Length];
            for (int i = 0; i < names.Length; i++)
            {
                arrangedNames[i] = names[i];
            }
            Array.Sort(arrangedNames);
            //foreach (string i in arrangedNames)
            //{
            //    Console.WriteLine(i);
            //}

            for (int i = 0; i < arrangedNames.Length; i++)
            {
                char [] sorter = arrangedNames[i].ToCharArray();
                Array.Sort(sorter);
                arrangedLettersInNames[i] = string.Join("", sorter);
            }

            for (int i = 0; i < arrangedNames.Length; i++)
            {
                Console.WriteLine($"{names[i]}\t\t{arrangedNames[i]}\t\t{arrangedLettersInNames[i]}");
            }
        }
    }
}
