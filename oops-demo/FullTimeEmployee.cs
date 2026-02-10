public class FullTimeEmployee : Employee {
    public int Salary {get; set;}
    public override string ToString()
    {
        //base.ToString();
        return $"{base.ToString()}Salary : {Salary}";
    }
}