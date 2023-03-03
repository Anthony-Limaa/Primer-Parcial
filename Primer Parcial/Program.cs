
using System.Security.Cryptography;
int n, factorial = 1, may = 1;


//Ingresar un número postivo mayor a cero.
do
{
    Console.WriteLine("Ingrese un número positivo mayor a cero: ");
    n = int.Parse(Console.ReadLine());
try
{

    if (n <= 0)
    {
        Console.WriteLine("No puedes ingresar el número 0 o uno menor a este.");
    }
}
catch (FormatException)
{
    Console.WriteLine("Ingresa un número válido.");
}

} while (n <= 0);


//Calcular el factorial del número dado.
for (int i = 1; i <= n; i++)
{
    factorial *= i;
}

//Calcular los números enteros positivos menores o iguales que N divisibles entre 3.
Console.WriteLine("");
Console.WriteLine("los números enteros positivos menores o iguales que N divisibles entre 3 son:");

for (int i = 1; i <= n; i++)
{
    if (i % 3 == 0)
    {
        Console.WriteLine(i + " ");
    }
}

//Calcular los números enteros positivos menores o iguales que N divisibles entre 5.
Console.WriteLine("");
Console.WriteLine("los números enteros positivos menores o iguales que N divisibles entre 5 son:");

for (int i = 1; i <= n; i++)
{
    if (i % 5 == 0)
    {
        Console.WriteLine(i + " ");
    }
}

//Imprimir en la pantalla la secuencia de números enteros positivos que comienzan en 1 y se incrementan en 2 hasta que se alcance un valor mayor que N.

Console.WriteLine("");
Console.WriteLine("La secuencia de números es la siguiente:");
while (may <= n)
{
    Console.WriteLine(may + "");
    may += 2;
}

//Valor de la variable factorial.
Console.WriteLine("");
Console.WriteLine("El factorial del número ingresado por el usuario es de: " + factorial);

