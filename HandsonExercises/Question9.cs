public class Question9{
    public void Division(){
        int n;
        int d;
        Console.WriteLine("Enter n : ");
        n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter d : ");
        d = int.Parse(Console.ReadLine());
        
        try{
            int result = n/d;
            Console.WriteLine($"The quotient is : {result}");

        }
        catch(DivideByZeroException){
            Console.WriteLine("Error : Division by zero is not allowed");

        }

    }
}