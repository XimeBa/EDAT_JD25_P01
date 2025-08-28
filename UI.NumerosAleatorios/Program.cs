namespace UI.NumerosAleatorios
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new frmDatosAleatorios());

           //Random aleatorio = new Random();

           // Empleado empleado = new Empleado();

           // empleado.Numero = aleatorio.Next(1, 5);

           // string[] strNombresA = { "Ximena", "Diana", "Martin", "Uriel", "Antonio" };
           
           // empleado.Nombre = strNombresA[aleatorio.Next(strNombresA.Length)];  //Length es para cadenas de tipo string y se usa en arrays 

           //** empleado.FechaNacimiento = 

           // if (empleado.Nombre.Substring(empleado.Nombre.Length - 1, 1) == "a")   //Substring es para tomar un valor especifico de la cadena 
           //     empleado.Sexo = "Femenino";                                       // el "a" va a determinar si es de sexo femenino 
           //                                                                       //if y else para realizar la  comparación
           // else
           //     empleado.Sexo = "Masculino";

            //** empleado.Grupo = ;



           // empleado.Sueldo = aleatorio.NextDouble()*2000;

     
            //** empleado.SeguroMedico = aleatorio.Next()

           
                    
        }
    }
}