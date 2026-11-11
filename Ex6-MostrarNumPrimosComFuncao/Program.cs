bool EPrimo(int numero)
{
    
    if (numero <= 1)
    {   
        return false;
    }

    for (int i = 2; i < numero; i++)
    {
        if (numero % i == 0)
        {
            return false;
        }

    }

    return true;
}

Console.WriteLine("-- EXIBIÇÃO NÚMEROS PRIMOS--\n");

//DECLARAÇÃO E INPUT
int numAlvo;

Console.Write("Insira até que número você quer que exiba os números primos: ");
numAlvo = int.Parse(Console.ReadLine());

//UTILIZANDO A FUNÇÃO E FAZENDO OUTPUT
for (int i = 2; i <= numAlvo; i++)
{
    if (EPrimo(i))
    {
        Console.WriteLine(i);
    }
}

Console.WriteLine("\n-- NUMEROS PRIMOS IMPRESSOS, PROGRAMA FINALIZADO! --");