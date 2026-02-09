class Student{
    public int StuId{get; set;}
    public string Name {get; set;}
    public string Department {get; set;}

    public Student(int Id, string name, string dept){
        StuId = Id;
        Name = name;
        Department = dept;
    }
}