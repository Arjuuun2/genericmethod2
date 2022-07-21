// See https://aka.ms/new-console-template for more information
class Generic
{
    static void Main(String[] ar)
    {
        int[] intArray = { 1, 2, 3, 4, 5 };
        String[] stringArray = { "one", "two", "three", "four" };
        double[] doubleArray = { 1.0, 2.0, 3.0, 4.0 };


        dispalyArrayelements(intArray);
        dispalyArrayelements(stringArray);
        dispalyArrayelements(doubleArray);
    }


    public static void dispalyArrayelements<t>(t[] Array)
    {
        foreach (t item in Array)
        {
            Console.WriteLine(item);
        }
        
        Console.WriteLine();

        
    }
}
