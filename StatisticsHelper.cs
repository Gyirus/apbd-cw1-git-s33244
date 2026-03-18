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
        
        
        
    public static class StatisticsHelper
    {
    
      
            if (numbers == null || numbers.Length == 0)
                throw new ArgumentException("Array cannot be null or empty");
            
            int max = numbers[0];
            foreach (var num in numbers)
            {
                if (num > max)
                    max = num;
            }
            return max;
        }
    
    }
}