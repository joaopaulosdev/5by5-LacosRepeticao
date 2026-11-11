Console.WriteLine("-- EXIBIÇÃO NÚMEROS PRIMOS--\n");

//DECLARAÇÃO E INPUT
int numAlvo;

Console.Write("Insira até que número você quer que exiba os números primos: ");
numAlvo = int.Parse(Console.ReadLine());

for(int i = 2; i<=numAlvo; i++)
{
    bool primo = true;

    for(int j = 2; j<i; j++)
    {
        if(i % j == 0)
        {
            primo = false;
            break;
        }
    }

    if (primo)
    {
        Console.WriteLine(i);
    }
}

Console.WriteLine("\n-- NUMEROS PRIMOS IMPRESSOS, PROGRAMA FINALIZADO! --");