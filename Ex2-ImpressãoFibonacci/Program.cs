Console.WriteLine("IMPRESSÃO FIBONACCI");

//DECLARAÇÃO E INPUT
int posicaoF;

Console.Write("Insira quantos números de Fibonacci devem ser exibidos: ");
posicaoF = int.Parse(Console.ReadLine());
int contador = 1;


int num1 = 0, num2 = 1, prox;

//LAÇO DE OUTPUT
while (contador <= posicaoF)
{
    Console.WriteLine("Posição: " + contador + " | Número: " + num1);
    prox = num1 + num2;
    num1 = num2;
    num2 = prox;
    contador++;

}

Console.WriteLine("\n FIBONACCI IMPRESSA, PROGRAMA FINALIZADO!");