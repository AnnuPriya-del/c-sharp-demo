public class ContractEmployee : Employee
{
    public int Stipend {get; set;}
    public override string ToString()
    {
        //base.ToString();
        return $"{base.ToString()}Stipend : {Stipend}";
    }
}