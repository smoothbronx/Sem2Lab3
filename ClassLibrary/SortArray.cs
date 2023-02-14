namespace lab3;

public class SortArray : IArray
{
    private readonly int[] _array;
    
    public SortArray(int[] sourceArray)
    {
        _array = sourceArray;
    }


    public double[] ForEach()
    {
        var arraySize = _array.Length;
        var temperanceArray = new double[arraySize];
        var maxValue = _array.Max();
        _array.CopyTo(temperanceArray, 0);

        for (var exponent = 1; maxValue / exponent > 0; exponent *= 10)
        {
            var outputArr = new int[arraySize];
            var occurrences = new int[10];

            for (var index = 0; index < 10; index++)
                occurrences[index] = 0;

            for (var index = 0; index < arraySize; index++)
                occurrences[(int)temperanceArray[index] / exponent % 10]++;

            for (var index = 1; index < 10; index++)
                occurrences[index] += occurrences[index - 1];

            for (var index = arraySize - 1; index >= 0; index--)
            {
                outputArr[occurrences[(int)temperanceArray[index] / exponent % 10] - 1] = (int)temperanceArray[index];
                occurrences[(int)temperanceArray[index] / exponent % 10]--;
            }

            for (var index = 0; index < arraySize; index++)
                temperanceArray[index] = outputArr[index];
        }

        return temperanceArray;
    }

    public int[] Sum(int[] otherArray)
    {
        return _array.Union(otherArray).ToArray();
    }
}