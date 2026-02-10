public class Employee{
    /*private int id;
    public int Id
    {
        get
        {
            return id;
        }
        set
        {
            id = value;
        }
    }*/
    public string Name {get; set;}  //auto implement property
    public int Id {get; set;}
    public string EmailId {get; set;}
    public string Contact {get; set;}
    public DateTime ReportingDate {get; set;}
    public override string ToString()
    {
        return $"Id: {Id} Name: {Name} EmailId : {EmailId} Contact : {Contact} ReportingDate : {ReportingDate}";
    }
}