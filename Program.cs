namespace ConsoleApp;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Podaj liczby oddzielone spacją:");
        string input = Console.ReadLine();
        
        string[] parts = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        int[] numbers = new int[parts.Length];
        
        for (int i = 0; i < parts.Length; i++)
        {
            numbers[i] = int.Parse(parts[i]);
        }
        
        int sum = StatisticsHelper.CalculateSum(numbers);
        double average = StatisticsHelper.CalculateAverage(numbers);
        
        Console.WriteLine($"Suma: {sum}");
        Console.WriteLine($"Średnia: {average}");
    }
}