class Program
{
    static void Main(string[] args)
    {
        string opcion;
        string[] Nombre;
        int[] Edad;
        string[] NomyApe;
        int[] Nota;
        int EdadMayor = 0;
        int sumaE = 0;
        int sumaN = 0;
        int NoDatos = 5;


        Console.WriteLine("Bienvenido al siguiente menú, por favor seleccione una opción: ");
        Console.WriteLine("Presione 1: ------>  Registro de nombres y edades ");
        Console.WriteLine("Presione 2: ------>  Registro de Notas");
        Console.WriteLine("Presione 3: ------>  Salir");

        opcion = Console.ReadLine();

        switch (opcion)
        {
            case "1":

                Nombre = new string[5];
                Edad = new int[5];
                for (int f = 0; f < 5; f++)
                {
                    Console.WriteLine("Ingrese su nombre: ");
                    Nombre[f] = Console.ReadLine();

                    Console.WriteLine("Ingrese su edad: ");
                    Edad[f] = int.Parse(Console.ReadLine());
                    sumaE = sumaE + Edad[f];

                }

                for (int f = 0; f < 5; f++)
                {
                    Console.WriteLine("");
                    Console.WriteLine("El nombre y edad de la persona es: ");
                    
                    Console.WriteLine("Se llama " + Nombre[f] + " y tiene " + Edad[f] + " años.");

                    if (EdadMayor < Edad[f])
                    {
                        EdadMayor = Edad[f];
                        Console.WriteLine("La persona con mayor edad es: " + Nombre[f]);
                    }
                }

                Console.WriteLine(" ");
                Console.WriteLine("La edad promedio de los 5 nombres es: " + sumaE / NoDatos);

                break;

            case "2":

                NomyApe = new string[5];
                for (int f = 0; f < 5; f++)
                {
                    Console.WriteLine("Ingrese su nombre y apellido (SOLO UNO): ");
                    NomyApe[f] = Console.ReadLine();
                }

                Nota = new int[5];
                for (int f = 0; f < 5; f++)
                {
                    Console.WriteLine("Ingrese la nota de programación para cada nombre ingresado: ");
                    Nota[f] = int.Parse(Console.ReadLine());
                    sumaN = sumaN + Nota[f];
                }

                for (int f = 0; f < 5; f++)
                {
                    Console.WriteLine("");
                    Console.WriteLine("El nombre de cada persona y su nota es: ");
                    Console.WriteLine(NomyApe[f] + " tiene una nota en la clase de programación de " + Nota[f]);
                    if (Nota[f] >= 71)
                    {
                        Console.WriteLine("APROBO EL CURSO");
                    }
                    else
                    {
                        Console.WriteLine("REPROBO EL CURSO");
                    }
                            
                }
                
                Console.WriteLine(" ");
                Console.WriteLine("La nota promedio de los 5 estudiantes es: " + sumaN / NoDatos);

                break;



            case "3":
                Console.WriteLine("Usted salio del programa");
                Environment.Exit(0);
                break;

            default:
                Console.WriteLine("ERROR, ingrese una opción del 1 al 3");
                break;

        }

    }
}