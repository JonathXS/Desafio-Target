using System.Text;

Console.WriteLine("Digite um número inteiro");
int number = 0;
var numberValid = int.TryParse(Console.ReadLine(), out number);
while(!numberValid) 
{
    Console.WriteLine("Número invalido, digite novamente");
    numberValid = int.TryParse(Console.ReadLine(), out number);
}
Fibonnacci(number);

Console.WriteLine();

Console.WriteLine("Digite uma alguma palavra para ficar invertida");
string word = Console.ReadLine();
StringReverse(word);


static void Fibonnacci(int number)
{
    Console.WriteLine();

    int a = 0;
    int b = 1;
    int fibonacci = 0;

    while (fibonacci < number)
    {
        fibonacci = a + b;
        a = b;
        b = fibonacci;
        Console.WriteLine(fibonacci);
    }

    Console.WriteLine();

    if (fibonacci == number)
    {
        Console.WriteLine("O número digitado faz parte da Sequência de Fibonacci");
    } else
    {
        Console.WriteLine("o número digitado não faz parte da Sequência de Fibonacci");
    }
}


static void StringReverse(string word) 
{ 
    var sb = new StringBuilder();
    
    for (int i = word.Length - 1; i >= 0; i--)
        sb.Append(word[i]);

    Console.WriteLine();

    Console.WriteLine(sb);
}


