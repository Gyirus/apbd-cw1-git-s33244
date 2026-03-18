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
        if (numbers.Length == 0) return 0;
        
        int sum = CalculateSum(numbers);
        return (double)sum / numbers.Length;
    }
}