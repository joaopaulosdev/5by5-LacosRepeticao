Console.WriteLine("-- EXIBIÇÃO FATORIAL--\n");

//DECLARAÇÃO E INPUT
int numAlvo;

Console.Write("Insira o número para ser mostrado o seu fatorial: ");
numAlvo = int.Parse(Console.ReadLine());


int resultado = 1;

for (int i = numAlvo; i >= 1; i--)
{
    resultado *= i;
}

Console.WriteLine(resultado);

Console.WriteLine("\n-- FATORIAL MOSTRADO, PROGRAMA FINALIZADO! --");