namespace lab3;

public static class Program
{
    private static void TestSortArray()
    {
        var sortArray = new SortArray(new[] { 1, 3, 2 });
        Console.WriteLine("SortArray:");

        var resultArray = sortArray.Sum(new[] { 2, 4, 3 });
        Console.WriteLine($"\tResult from Sum method: [{string.Join(", ", resultArray)}]");
        
        var sortedArray = new SortArray(resultArray).ForEach();
        Console.WriteLine($"\tResult from ForEach method: [{string.Join(", ", sortedArray)}]");
    }

    private static void TestXorArray()
    {
        var xorArray = new XorArray(new[] { 1, 2, 3 });
        Console.WriteLine("XorArray:");

        var resultArray = xorArray.Sum(new[] { 2, 4, 3 });
        Console.WriteLine($"\tResult from Sum method: [{string.Join(", ", resultArray)}]");
        
        var sqrtArray = new XorArray(resultArray).ForEach();
        Console.WriteLine($"\tResult from ForEach method: [{string.Join(", ", sqrtArray)}]");
    }

    public static void Main(string[] args)
    {
        TestSortArray();
        Console.WriteLine();
        TestXorArray();
    }
}