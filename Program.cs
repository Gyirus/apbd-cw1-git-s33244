namespace ConsoleApp;

class Program
{
    static void Main(string[] args)
    {
        
        Console.WriteLine("=== APBD Git Exercise - Główna gałąź main ===");
        Console.WriteLine("Witamy w głównej wersji programu!");
    
        Console.WriteLine("Podaj liczby oddzielone spacją:");
        string input = Console.ReadLine();
        
        if (string.IsNullOrWhiteSpace(input))
        {
            Console.WriteLine("Błąd: Nie podano żadnych liczb!");
            return;
        }
        
        string[] parts = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        List<int> validNumbers = new List<int>();
        
        foreach (string part in parts)
        {
            if (int.TryParse(part, out int number))
            {
                validNumbers.Add(number);
            }
            else
            {
                Console.WriteLine($"Ostrzeżenie: '{part}' nie jest poprawną liczbą i zostało pominięte");
            }
        }
        
        if (validNumbers.Count == 0)
        {
            Console.WriteLine("Błąd: Brak poprawnych liczb do przetworzenia!");
            return;
        }
        
        
        int max = StatisticsHelper.CalculateMax(numbers);
        Console.WriteLine($"Maksimum: {max}");
        
        int[] numbers = validNumbers.ToArray();
        int sum = StatisticsHelper.CalculateSum(numbers);
        double average = StatisticsHelper.CalculateAverage(numbers);
        
        Console.WriteLine($"Suma: {sum}");
        Console.WriteLine($"Średnia: {average}");
        Console.WriteLine($"Liczba poprawnych liczb: {numbers.Length}");
    }
}