public class Question2{
    int num;
    public void CheckNumber(){
        Console.WriteLine("Enter number : ");
        num = int.Parse(Console.ReadLine());

        if (num < 0){
            Console.WriteLine("The number is negative");

        }
        else if (num > 0){
            Console.WriteLine("The number is positive");
        }

        else{
            Console.WriteLine("The number is zero");
        }
    }

}