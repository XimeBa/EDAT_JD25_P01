using System.Reflection.Metadata.Ecma335;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Complejidad de algoritmos\n");
        Console.WriteLine("Complejidad Big 0 (1)");

        var numeros = new List<int> {1, 3, 5, 7, 9, 3};
        var numeroMayor = (List<int> arreglo) => 
        {
            if (arreglo == null || arreglo.Count == 0)
            {
                return 0;
            }
                 int mayor = arreglo [0];
                for (int i = 0; i < arreglo.Count; i++) 
                {
                    if (arreglo[i] > mayor) 
                    {
                        mayor = arreglo [i];
                    }
                }
            return mayor;
        };

        int may = numeroMayor(numeros); //Se invoca funcion lambda
        Console.WriteLine("El numero mayor es: " + may);

        // var nombres = new List<string> { 
        //  "Ileny", "Alondra", "José", "Juam", "Alejanfdra", "Karla"};

        //var primero = (List<string> arreglo) => arreglo != null && arreglo.Count > 0 ?
        //    arreglo [0] : "Lista vacía";

        //Console.WriteLine(primero(nombres));


        Console.ReadKey();
    }
}