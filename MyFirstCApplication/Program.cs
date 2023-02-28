// Deklaracja zmiennych
string name = "Ewa";
int age = 17;
char sex = 'M';

// Wyświetl dane wejściowe
Console.WriteLine("Dane wejściowe:");
Console.WriteLine("Imie osoby: " + name);
Console.WriteLine("Wiek osoby: " + age + " lat");
if (sex == 'K')
{
    Console.WriteLine("Płeć: Kobieta");
}
else
{
    Console.WriteLine("Płeć: Mężczyzna");
 }

// Wyświetl wynik analizy danych
Console.WriteLine(" ");
Console.WriteLine("Wynik analizy danych:");
if (sex == 'K')
{
    if (age < 30)
    {
        Console.WriteLine("Kobieta poniżej 30 lat");
    }
    else if (age == 33 && name == "Ewa")
    {
        Console.WriteLine("Ewa, lat 33");
    }
    else
    {
        Console.WriteLine("Wprowadzone dane nie spełniają zadanych kryteriów analizy. Zmień dane wejściowe.");
    }
 }
else
{
    if (age < 18)
    {
        Console.WriteLine("Niepełnoletni Mężczyzna");
    }
    else
    {
        Console.WriteLine("Wprowadzone dane nie spełniają zadanych kryteriów analizy. Zmień dane wejściowe.");
    }
}