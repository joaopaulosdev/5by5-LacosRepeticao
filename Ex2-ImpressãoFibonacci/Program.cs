Console.WriteLine("IMPRESSÃO FIBONACCI");

int posicaoF;

Console.Write("Insira quantos números de Fibonacci devem ser exibidos: ");
posicaoF = int.Parse(Console.ReadLine());
int contador = 1;

int num1 = 0, numAtual = 0, resultFib = 0;

do
{
    Console.WriteLine("Posição: " + contador + "| Número: " + numAtual);
    resultFib = num1 + numAtual;
    num1 = numAtual;
    numAtual = resultFib;

    contador++;

}while(contador <= posicaoF);

Console.WriteLine("\n FIBONACCI IMPRESSA, PROGRAMA FINALIZADO!");