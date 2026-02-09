public class Question5{
    public int FindMax(){
        int[] arr = new int[5];
        int max;

        for (int i = 0; i < 5; i++){
            Console.WriteLine($"Enter number: {i+1}");
            arr[i] = int.Parse(Console.ReadLine());
        }

        max = arr[0];
        for(int i = 0; i<5; i++){
            if (arr[i] > max){
                max = arr[i];
            }
        }
        return max;

    }
}