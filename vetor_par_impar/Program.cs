int[] numeros = new int[10];

//1 - leia 10 numeros inteiros e imprima os seguintes itens:

for (int i = 0; i < 10; i++)
{
    Console.Write($"Informe um valor para a posição {i} do vetor: ");
    numeros[i] = int.Parse(Console.ReadLine());
}

//a) somente os valores pares;
Console.WriteLine("\nMostrando apenas os valores PARES:");
for (int i = 1; i < 10; i++)
{
    if (numeros[i] % 2 == 0) Console.Write(numeros[i] + " ");
}

//b) somente os valores impares;
Console.WriteLine("Mostrando apenas os valores IMPARES:");
for (int i = 0; i < 10; i++)
{
    if (numeros[i] % 2 != 0) Console.Write(numeros[i] + " ");
}

//c) somente a primeira e a ultima posição;
Console.Write("\nPrimeiro valor do vetor:");
Console.WriteLine(numeros[0]);

Console.Write("\nUltimo valor do vetor:");
Console.WriteLine(numeros[9]);