internal class Program
{
    private static void Main(string[] args)
    {
        int[] inputArray = { 1, 2, 3 };
        int[] reverseArray = FnreverseArray(inputArray);

        foreach (int num in reverseArray)
        {
            Console.WriteLine(num);
        }
 
    static int[] FnreverseArray(int[] arrays)
        {
            int[] ints = new int[arrays.Length];
            int j = 0;
            for (int i = arrays.Length - 1; i >= 0; i--)
            {
                ints[j] = arrays[i];
                j++;
            }
            return ints;
        }
    }
}