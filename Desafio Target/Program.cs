Finbonnaci();

VerifyletterA();

// Verifica se o número é da sequência finbonnaci
static void Finbonnaci()
{ 
    int number;

    while (true)
    {
        Console.WriteLine("Escreva um número inteiro positivo:");

        string input = Console.ReadLine();
        if (int.TryParse(input, out number) && number >= 0)
        {
            break;
        } else
        {
            Console.WriteLine("Entrada inválida. Por favor, insira um número inteiro positivo.");
        }
    }

    if (number >= 0)
    {
        int a = 0;
        int b = 1;
        int finbonnaci = 0;

        while (number > finbonnaci)
        {
            Console.WriteLine(finbonnaci);

            finbonnaci = a + b;
            a = b;
            b = finbonnaci;
        }
        if (number >= finbonnaci)
        {
            Console.WriteLine($"O Número {number} pertence a sequncia Finbonnaci");
        } else
        {
            Console.WriteLine($"O Número {number} não faz parte da sequencia Finbonnaci");
        }

    } else
    {
        Console.WriteLine($"Número negativo não faz parte da sequencia de Finbonnaci");
    }
}

//Verifica se tem letra "A" maiuscula ou minuscula e conta quantas vezes aparece
static void VerifyletterA()
{
    Console.WriteLine("Digite uma string:");
    string text = Console.ReadLine();

    int count = 0;

    foreach (char c in text)
    {
        if (c == 'a' || c == 'A')
        {
            count++;
        }
    }

    if (count > 0)
    {
        Console.WriteLine($"A letra 'a ou A' aparece {count} vezes no texto.");
    } else
    {
        Console.WriteLine("A letra 'a ou A' não aparece no texto.");
    }
}