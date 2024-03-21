using System;

class Program
{
    static void Main()
    {
        double speakingMark, readingMark, writingMark, listeningMark;

        // Foydalanuvchidan imtihon ballarini kiritish
        Console.Write("Inter your Listening score: ");
        speakingMark = Convert.ToDouble(Console.ReadLine());

        Console.Write("Inter your reading score: ");
        readingMark = Convert.ToDouble(Console.ReadLine());

        Console.Write("Inter your writing score: ");
        writingMark = Convert.ToDouble(Console.ReadLine());

        Console.Write("Inter your Listening score: ");
        listeningMark = Convert.ToDouble(Console.ReadLine());

        // All score calculation
        double totalMarks = speakingMark + readingMark + writingMark + listeningMark;

        // Ortacha ballni hisoblash
        double averageMark = totalMarks / 4;


        Console.WriteLine($"average score: {averageMark}");
        Console.Write("Is countiniu? (yes/no): ");
        string scaultiniu = Console.ReadLine();

        if (scaultiniu.ToLower() == "yes")
        {
            Main();
        }
        else if (scaultiniu.ToLower() == "no")
        {
            Console.WriteLine("Dastur to'xtatildi.");
        }
        else
        {
            Console.WriteLine("ERROR.");
        }
    }
}
