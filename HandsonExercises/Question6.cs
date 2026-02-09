public class Question6{
    public int CountVowels(){
        int count = 0;
        string text;
        Console.WriteLine("Enter text : ");
        text = Console.ReadLine();
        text = text.ToLower();

        for (int i = 0; i<text.Length; i++){
            if (text[i] == 'a' || text[i] == 'e' || text[i] == 'i' || text[i] == 'o' || text[i] == 'u'){
                count++;
            }
        }
        return count;
    }
}