public class MainClass{
    public static void Main(){
        Employee emp = new Employee(){
            Name = "Annu Priya",
            Id = 2479585,
            EmailId = "2479585@cognizant.com",
            Contact = "8603439902",
            ReportingDate = new DateTime(2026,01,31)
        };
        /*Console.WriteLine(emp.Name);
        Console.WriteLine(emp.Id);
        Console.WriteLine(emp.EmailId);
        Console.WriteLine(emp.Contact);
        Console.WriteLine(emp.ReportingDate);
        Console.WriteLine(emp.ToString());
        Console.WriteLine(emp);*/

        FullTimeEmployee fte = new FullTimeEmployee{
            Name = "Annu",
            Id = 2790,
            EmailId = "2790@cognizant.com",
            Contact = "8723908632",
            ReportingDate = new DateTime(2026,01,31),
            Salary = 675000
        };

        ContractEmployee intern = new ContractEmployee{
            Name = "Annu Priya",
            Id = 2479585,
            EmailId = "2479585@cognizant.com",
            Contact = "8603439902",
            ReportingDate = new DateTime(2026,01,31),
            Stipend = 15000
        };

        Console.WriteLine(fte.ToString());
        Console.WriteLine(intern.ToString());


    }
}