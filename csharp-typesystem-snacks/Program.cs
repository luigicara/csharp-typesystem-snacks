// 1° snack

int n1, n2;

Console.WriteLine("Inserisci un numero");
string input1 = Console.ReadLine();

Console.WriteLine("Inserisci un altro numero");
string input2 = Console.ReadLine();

if (int.TryParse(input1, out n1) && int.TryParse(input2, out n2))
{
    if (n1 > n2)
        Console.WriteLine(n1);
    else
        Console.WriteLine(n2);
}
else
    Console.WriteLine("Input non validi!");


// 2° snack


Console.WriteLine("Inserisci la prima parola");
string? word1 = Console.ReadLine();

Console.WriteLine("Inserisci la seconda parola");
string? word2 = Console.ReadLine();

if (word1 != null || word2 != null)
{
    if (word1.Length == word2.Length)
        Console.WriteLine($"Le parole '{word1}' e '{word2}' hanno la stessa lunghezza");
    else if (word1.Length > word2.Length)
        Console.WriteLine($"La parola '{word1}' è più lunga di '{word2}'");
    else
        Console.WriteLine($"La parola '{word2}' è più lunga di '{word1}'");

}
else
    Console.WriteLine("Input non validi!");


//3° snack

int sum = 0;

for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"Inserisci il {i + 1}° numero");
    sum += Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine($"La somma totale è {sum}");


//4° snack

int sum = 0;
int counter = 0;

for (int i = 2; i <= 10; i++)
{
    counter++;
    sum += i;
}

int average = sum / counter;

Console.WriteLine($"La somma totale è {sum} e la media è {average}");


//5° snack

Console.Write("Inserisci un numero: ");

try
{
    int n = Convert.ToInt32(Console.ReadLine());

    if (n % 2 == 0)
    {
        Console.WriteLine(n);
    }
    else
    {
        Console.WriteLine(n + 1);
    }
}
catch (Exception e)
{
    Console.Write("Input non valido");
}


//6° snack

string[] invitati = new string[] { "Pippo", "Pluto", "Paperino" };

Console.Write("Inserisci il tuo nome: ");

string? nome = Console.ReadLine();

bool success = false;

if (nome != null && nome.Length != 0)
{
    foreach (var invitato in invitati)
    {
        success = nome == invitato;

        if (success)
        {
            Console.WriteLine("Complimenti! Sei invitato");
            break;
        }
    }

    if (!success)
        Console.WriteLine("Mi dispiace non sei invitato");

}
else
    Console.WriteLine("Input non valido");


//7° snack

int[] arrayNumbers = new int[6];

for (int i = 0; i < 6; i++)
{
    Console.WriteLine($"Inserisci il {i + 1} numero");

    int n = Convert.ToInt32(Console.ReadLine());

    if (n % 2 != 0)
    {
        arrayNumbers[i] = n;
    }
}

for (int i = 0; i < arrayNumbers.Length; i++)
{
    Console.Write($"-{arrayNumbers[i]}");
}


//8° snack

int[] num = new int[] { 12, 24, 10, 15, 17, 6, 28 };

int sum = 0;

for (int i = 1; i < num.Length; i += 2)
{
    sum += num[i];
}

Console.WriteLine(sum);


//9° snack 

int[] numeri = new int[50];

int sum = 0;

int counter = 0;

Console.WriteLine("Inserisci numeri finchè la loro somma non supera 50!");

while (sum <= 50)
{
    sum = 0;

    int input = Convert.ToInt32(Console.ReadLine());

    if (input < 1)
        continue;

    numeri[counter++] = input;

    foreach (int i in numeri)
    {
        sum += i;
    }
}

Console.WriteLine("Hai superato 50!");


//10° snack

Console.WriteLine("Inserisci un numero");

int n = Convert.ToInt32(Console.ReadLine());


Random randNum = new Random();

for (int i = 0; i < n; i++)
{
    int[] newArray = new int[10];

    for (int j = 0; j < newArray.Length; j++)
    {
        newArray[j] = randNum.Next(1, 100);
    }

    string[] result = newArray.Select(i => i.ToString()).ToArray();
    Console.WriteLine(String.Join(", ", result));
}


//11° snack

Console.WriteLine("Inserisci la prima parola");
string? word1 = Console.ReadLine();

Console.WriteLine("Inserisci la seconda parola");
string? word2 = Console.ReadLine();


static void wordLenght(string? word1, string? word2)
{
    if (word1 != null || word2 != null)
    {
        if (word1.Length == word2.Length)
            Console.WriteLine($"Le parole '{word1}' e '{word2}' hanno la stessa lunghezza");
        else if (word1.Length > word2.Length)
            Console.WriteLine($"La parola '{word1}' è più lunga di '{word2}'");
        else
            Console.WriteLine($"La parola '{word2}' è più lunga di '{word1}'");

    }
    else
        Console.WriteLine("Input non validi!");
}

wordLenght(word1, word2);


//12° snack

static bool evenOrOdd(int num)
{
    bool result;

    result = num % 2 == 0;

    return result;
}

int n;

Console.WriteLine("Inserisci un numero");
string input = Console.ReadLine();

if (int.TryParse(input, out n))
{
    if(evenOrOdd(n))
    {
        Console.WriteLine($"Il numero che hai inserito '{n}' è pari!");
    } else
    {
        Console.WriteLine($"Il numero che hai inserito '{n}' è dispari!");
    }

}
else
    Console.WriteLine("Input non validi!");


