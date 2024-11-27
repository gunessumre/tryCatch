using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Lütfen bir sayı giriniz:");

        try
        {
            
            string input = Console.ReadLine();

            
            int number = int.Parse(input);

            
            int square = number * number;
            Console.WriteLine($"Girdiğiniz sayının karesi: {square}");
        }
        catch (FormatException)
        {
            
            Console.WriteLine("Geçersiz giriş! Lütfen bir sayı giriniz.");
        }
        catch (Exception ex)
        {
            
            Console.WriteLine($"Bir hata oluştu: {ex.Message}");
        }
    }
}