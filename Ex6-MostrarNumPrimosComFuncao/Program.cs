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

void ImprimirPrimo(int numAlvo)
{
    for (int i = 2; i <= numAlvo; i++)
    {
        if (EPrimo(i))
        {
            Console.WriteLine(i);
        }
    }
}


Console.WriteLine("-- EXIBIÇÃO NÚMEROS PRIMOS--\n");

//DECLARAÇÃO E INPUT
int numAlvo;

Console.Write("Insira um número limite para exibir os números primos: ");
numAlvo = int.Parse(Console.ReadLine());

//UTILIZANDO A FUNÇÃO E FAZENDO OUTPUT
ImprimirPrimo(numAlvo);

Console.WriteLine("\n-- NUMEROS PRIMOS IMPRESSOS, PROGRAMA FINALIZADO! --");