using QuickAndExternalSorting;
using System.Diagnostics;
int[] testarray = new int[] {1,6,9,3,1,7,4,3,8,2 };
//MergeSort.Sort(testarray);
CountTime(QuickSort.QuickSorting);
CountTime(MergeSort.MergeSorting);

static int[] CreateTestData(int amount)
{
    var array = new int[amount];
    Random randNum = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = randNum.Next(0, array.Length);
    }
    return array;
}
static void CountTime(Action<int[]> sortMethod)
{
    Stopwatch clock = new Stopwatch();
    for (int N = 100; N <= 1_000_000; N *= 10)
    {
        var testArray = CreateTestData(N);
        clock.Start();
        sortMethod(testArray);
        clock.Stop();
        Console.WriteLine($"{N} -{sortMethod.Method.Name} {clock.ElapsedMilliseconds} ms");
    }
}