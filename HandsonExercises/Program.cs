using System;

public class Program{
    public static void Main(string[] args){
        Question1 user = new Question1();

        //user.ReadInfo();
        //user.DisplayInfo();

        Question2 numChecker = new Question2();

        //numChecker.CheckNumber();

        //Question3 printEvens = new Question3();
        //printEvens.PrintEvens();

        //int result = Question4.AddNumbers(10,20);
        //Console.WriteLine(result);

        //Question5 max = new Question5();
        //int maximum = max.FindMax();
        //Console.WriteLine($"maximum number is : {maximum}");

        Question6 vowels = new Question6();
        int count = vowels.CountVowels();
        Console.WriteLine($"The number of vowels in this string is : {count}");
    }
}



    