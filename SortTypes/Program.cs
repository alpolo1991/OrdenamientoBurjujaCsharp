// See https://aka.ms/new-console-template for more informatio
//

using SortTypes;
using SortTypes.BurbujaSort;
using SortTypes.InsertionSort;
using SortTypes.SelectionSort;
using SortTypes.ShellSort;

/*
 * Universidad Nacional Abierta y a Distancia (UNAD)
 * Escuela de Ciencias Básicas, Tecnología e Ingeniería – ECBTI
 * Programación (213023_137)
 * Autor: Alfonso Gonzalez Posso
 * Etapa 4 - Tipos de Ordenamientos
 *
 */

BurbujaSort burbujaSort = new BurbujaSort();
ShellSort shellSort = new ShellSort();
SelectionSort selectionSort = new SelectionSort();
InsertionSort insertionSort = new InsertionSort();

Boolean isSalir = true;

while (isSalir)
{
    try
    {
        Console.Clear();
        Console.WriteLine(
            "\t* Universidad Nacional Abierta y a Distancia (UNAD) \n" +
            "\t* Escuela de Ciencias Básicas, Tecnología e Ingeniería – ECBTI \n" +
            "\t\t* Programación (213023_137) \n" +
            "\t\t* Autor: Alfonso Gonzalez Posso \n" +
            "\t\t* Etapa 4 - Tipos de Ordenamientos \n"
            );
        Console.WriteLine("\tManu Principal Tipos de Ordenamientos.\n");
        Console.WriteLine("\t\t1. Ordenamiento por Burbuja.");
        Console.WriteLine("\t\t2. Ordenamiento por Shell.");
        Console.WriteLine("\t\t3. Ordenamiento por Selección.");
        Console.WriteLine("\t\t4. Ordenamiento por Inserción.");
        Console.WriteLine("\t\t5. Salir.\n");
        Console.Write("\tSeleccione una opción -> ");
        int opc = Int32.Parse(Console.ReadLine());
        Console.WriteLine();

        switch (opc)
        {
            case 1:
                Console.WriteLine("\tOrdenamiento por Burbuja.\n");
                burbujaSort.addDatos();
                burbujaSort.Burbuja_Sort();
                burbujaSort.SetOrden();
                burbujaSort.GenerarArchivo();
                Console.ReadKey();
                break;
            case 2:
                Console.WriteLine("\tOrdenamiento por Shell.\n");
                shellSort.addDatos();
                shellSort.Shell_Sort();
                shellSort.SetOrden();
                shellSort.GenerarArchivo();
                Console.ReadKey();
                break;
            case 3:
                Console.WriteLine("\tOrdenamiento por Selección.\n");
                selectionSort.addDatos();
                selectionSort.Selection_Sort();
                selectionSort.SetOrden();
                selectionSort.GenerarArchivo();
                Console.ReadKey();
                break;
            case 4:
                Console.WriteLine("\tOrdenamiento por Inserción.\n");
                insertionSort.addDatos();
                insertionSort.Insercion_Sort();
                insertionSort.SetOrden();
                insertionSort.GenerarArchivo();
                Console.ReadKey();
                break;
            case 5:
                Console.WriteLine("\tSalio del programa correctamente.\n");
                isSalir = false;
                break;
            default:
                Console.WriteLine("\tPor favor seleccione una opcion válida.\n");
                Console.ReadKey();
                break;
        }
    }
    catch (FormatException ex)
    {
        Console.WriteLine("Por favor ingresa un valor válido. {0}", ex.Message);
        Console.ReadKey();
    }
    catch (ArgumentOutOfRangeException ex)
    {
        Console.WriteLine("El rango del número ingresado no es correcto, por favor valide de nuevo. {0}", ex.Message);
        Console.ReadKey();
    }
    catch (Exception ex)
    {
        Console.WriteLine("Error inesperado.. {0}", ex.Message);
        Console.ReadKey();
    }
}
