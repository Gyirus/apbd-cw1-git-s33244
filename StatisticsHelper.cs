namespace ConsoleApp;

public static class StatisticsHelper
{
    public static int CalculateSum(int[] numbers)
    {
        int sum = 0;
        foreach (var num in numbers)
        {
            sum += num;
        }
        return sum;
    }
    
    public static double CalculateAverage(int[] numbers)
    {
        if (numbers == null || numbers.Length == 0)
            return 0;
        
        int sum = 0;
        foreach (var num in numbers)
        {
            sum += num;
        }
        return (double)sum / numbers.Length;
    }
}