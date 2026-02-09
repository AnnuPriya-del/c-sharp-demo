class Question10{
    public void FileHandler(){
        string fileName = "sample.txt";
        File.WriteAllText(fileName, "Hello this is a sample file");

        string content = File.ReadAllText(fileName);
        Console.WriteLine($"The file content is : {content}");
    }
}