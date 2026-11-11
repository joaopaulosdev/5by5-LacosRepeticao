Console.WriteLine("-- EXIBIÇÃO NÚMEROS INTEIROS--\n");

//DECLARAÇÃO E INPUT
int numAlvo;

Console.Write("Insira até que número você quer que exiba, partindo do 0: ");
numAlvo = int.Parse(Console.ReadLine());


Console.WriteLine("\nNÚMEROS ÍMPARES:\n");
for(int i = 1; i <= numAlvo; i+=2)
{   
    Console.WriteLine(i);
}

Console.WriteLine("\nNÚMEROS PARES:\n");
for (int i = 0; i <= numAlvo; i += 2)
{
    Console.WriteLine(i);
}

Console.WriteLine("\n-- NUMEROS IMPRESSOS, PROGRAMA FINALIZADO! --");