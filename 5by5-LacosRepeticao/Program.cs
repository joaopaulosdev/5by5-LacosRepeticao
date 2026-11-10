int contador = 10;

//WHILE

while (contador > 0)
{
    Console.WriteLine(contador);
    contador--;
    Thread.Sleep(200);
}
Console.WriteLine("Happy New Year COM WHILE");


//DO-WHILE
contador = 10;

do
{
    Console.WriteLine(contador);
    contador--;
    Thread.Sleep(200);

} while (contador > 0);
Console.WriteLine("Happy New Year COM DO-WHILE");


//FOR

for(contador = 10; contador > 0; contador--)
{
    Console.WriteLine(contador);
    Thread.Sleep(200);
}

Console.WriteLine("Happy New Year COM FOR");