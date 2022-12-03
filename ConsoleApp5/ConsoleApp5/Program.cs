using System;

class Program
{
    static void Main(string[] args)
    {
        // tu wpisujesz kod
        string nazwisko = Console.ReadLine();
        int wiek = int.Parse(Console.ReadLine());
        int wiek_emerytalny = int.Parse(Console.ReadLine());
        Console.WriteLine($"Witaj, {nazwisko}!");
        if (wiek < 0 && wiek_emerytalny <= 0)
        {
            Console.WriteLine("Wiek nie może być ujemny!");
        }
        if (wiek < 0 && wiek_emerytalny >= 0)
        {
            Console.WriteLine($"Wiek nie może być ujemny!");
        }
        if (wiek >= 0 && wiek_emerytalny < 0)
        {
            Console.WriteLine($"Wiek nie może być ujemny!");
        }
        if (wiek < wiek_emerytalny && wiek >= 0 && wiek_emerytalny > 0)
        {
            Console.WriteLine($"Do emerytury brakuje Ci {wiek_emerytalny - wiek} lat!");
        }
        if (wiek >= wiek_emerytalny && wiek > 0 && wiek_emerytalny >= 0)
        {
            Console.WriteLine("Jesteś emerytem!");
        }

    }
}


