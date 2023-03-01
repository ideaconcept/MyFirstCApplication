// Deklaracja zmiennych
int number = 256965200;

// Wyświetl dane wejściowe
Console.WriteLine("Wprowadzona liczba: " + number + " zawiera:");

// Analiza danych
//Kod nie rozwiązuje "problemu" podania jako pierwszej lizby zera 0, która jest pomijana przy konwersji do stringa :-)
string numberInString = number.ToString();
char[] letters = numberInString.ToCharArray();
int[] result = new int[10]; //Użyłem tablicy z uwagi na skończoną liczbę elementów -> cyfr 0-9
int petle = numberInString.Length;

for (var i = 0; i < petle; i++)
{
    if (letters[i] == '0')
    {
        result[0] = result[0] + 1;
    }
    else if (letters[i] == '1')
    {
        result[1] = result[1] + 1;
    }
    else if (letters[i] == '2')
    {
        result[2] = result[2] + 1;
    }
    else if (letters[i] == '3')
    {
        result[3] = result[3] + 1;
    }
    else if (letters[i] == '4')
    {
        result[4] = result[4] + 1;
    }
    else if (letters[i] == '5')
    {
        result[5] = result[5] + 1;
    }
    else if (letters[i] == '6')
    {
        result[6] = result[6] + 1;
    }
    else if (letters[i] == '7')
    {
        result[7] = result[7] + 1;
    }
    else if (letters[i] == '8')
    {
        result[8] = result[8] + 1;
    }
    else
    {
        result[9] = result[9] + 1;
    }
}
//Wyświetlenie wyniku
Console.WriteLine("\n");
for (var i = 0; i < 10; i++)
{
    Console.WriteLine("Liczba " + i + " występuje " + result[i] + " razy");
}
Console.WriteLine("\n");
