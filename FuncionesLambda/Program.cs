using FuncionesLambda;
using System.Timers;

internal class Program
{
    private static void Main(string[] args)
    {

        Console.WriteLine("Expresión Lambda como función");

        //Func<int, int> b = (a) => a * 2;           //   => FuncionesLambda 

        //int resultado = b(4);

        //Console.WriteLine("El resultado es: " + resultado);



        //Func<int, int, int> suma = (a, b) => a + b;           //   => FuncionesLambda 
        //int resultado = suma(4, 6);
        //Console.WriteLine("El resultado es: " + resultado);


        //Func<int, int, int> mayor = (a, b) => 
        //{
        //    if (a > b)
        //    {
        //        return a;
        //    }
        //    else 
        //    { 
        //        return b;
        //    }
        //};          
        
        //int resultado = mayor(45, 20);

        //Console.WriteLine("El mayor es: " + resultado);


        //Console.WriteLine("Funciones Lambda");
        //Persona pers = new Persona();
        //int edad = 18;
        //edad++;
        //edad++;
        //Console.WriteLine("El valor de la variable es: " + edad);
        //Console.WriteLine("La división de memoria" + );

        var numeros = new List<int> { 8, 5, 9, 34, 2, 26, 8 };  

        Func<int, bool> ObtenerPares =(num) => num % 2 == 0;

        //var pares = numeros.Where(ObtenerPares);
        var pares = numeros.Where((num) => num % 2 == 0);

        Console.WriteLine("Hola ");

        Console.ReadKey();

        //& edad solo los numeros, &pers toda la direccion de memoria  
    }
}