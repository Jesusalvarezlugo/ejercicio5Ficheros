namespace ejercicio5Ficheros
{
    class Program
    {
        public static void Main(string[] args)
        {
            /*
                Desarrolla un programa que permita al usuario elegir entre dos opciones: 
                modificar una línea específica o insertar texto en una posición específica de una línea. 
                Dependiendo de la opción elegida, el programa debe solicitar los datos necesarios 
                (número de línea, posición, texto) 
                y realizar la modificación correspondiente en el archivo de texto.
            */

            string rutaArchivo = "archivo.txt";
            int numLinea;
            int posicion;
            int opcion;
            string textoACambiar;

            Console.WriteLine("1. modificar una línea específica ");
            Console.WriteLine("2. insertar texto en una posición específica de una línea");
            Console.WriteLine("############################################################");
            Console.WriteLine("Elija una opcion: ");
            opcion = Console.ReadKey(true).KeyChar - ('0');

            try
            {
                if (opcion == 1)
                {
                    Console.WriteLine("Introduzca la linea que desea modificar: ");
                    numLinea=Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Introduzca el texto para modificar: ");
                    textoACambiar = Console.ReadLine();

                    //Leer todas las lineas del archivo
                    string[] lineasTexto=File.ReadAllLines(rutaArchivo);

                    if(numLinea <= 0 && numLinea <= lineasTexto.Length)
                    {
                        //Reemplazar el contenido antiguo por el nuevo
                        lineasTexto[numLinea - 1] = textoACambiar;

                        //Reemplazar el archivo con las lineas actualizadas
                        File.WriteAllLines(rutaArchivo, lineasTexto);

                        Console.WriteLine("El texto se ha escrito correctamente en la línea especificada.");
                    }
                }
                else
                {

                }
            }catch (IOException e)
            {

            }


        }
    }
}


