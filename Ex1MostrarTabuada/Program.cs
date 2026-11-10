Console.WriteLine("-- MOSTRAR TABUADA --");

int num;

Console.Write("Insira um número para a tabuada: ");
num = int.Parse(Console.ReadLine());

for(int i = 1; i <= 10; i++)
{
    int resultado = num * i;
    Console.WriteLine(num + " x " + i + " = " + resultado);
}

Console.WriteLine("\n TABUADA IMPRESSA, PROGRAMA FINALIZADO!");