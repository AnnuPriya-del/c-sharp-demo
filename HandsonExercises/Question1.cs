public class Question1{
    public string Name;
    public int Age;
    public double Salary;

    public void ReadInfo(){
        Console.WriteLine("Enter Name : ");
        Name = Console.ReadLine();
        Console.WriteLine("Enter Age : ");
        Age = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter Salary : ");
        Salary = double.Parse(Console.ReadLine());
    }

    public void DisplayInfo(){
        Console.WriteLine($"The Name is : {Name}");
        Console.WriteLine($"The Age is : {Age}");
        Console.WriteLine($"The Salary is : {Salary}");
    }
}