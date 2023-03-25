namespace SortTypes.ShellSort;

/*
 * Universidad Nacional Abierta y a Distancia (UNAD)
 * Escuela de Ciencias Básicas, Tecnología e Ingeniería – ECBTI
 * Programación (213023_137)
 * Autor: Alfonso Gonzalez Posso
 * Etapa 4 - Tipos de Ordenamientos
 *
 */

public class ShellSort
{

    private DatosNum _datosNum = new DatosNum();

    public void addDatos()
    {
        _datosNum.IngresarDatos();
            
        Console.WriteLine();
        Console.Write("\tOrden de Números Ingresados: ");
        _datosNum.SetDatosIngresados();
        Console.WriteLine();
        Console.WriteLine("\nCantidad de Números Ingresados -> {0}", _datosNum.DatosIngresados.Length);
        Console.WriteLine();
    }
    
    public void Shell_Sort()
    {
        int[]? datos = _datosNum.DatosOrdenados;

        int pos = datos.Length;
        int shrink = 2;
        
        int temp;
        int j = 0;

        while (pos > 0)
        {
            pos = (pos / shrink);

            for (int i = 0; i < datos.Length; i++)
            {
                temp = datos[i];
                j = i;
                while ((j >= pos) && (datos[j - pos] > temp))
                {
                    datos[j] = datos[j - pos];
                    j -= pos;
                    datos[j] = temp;
                }
            }
        }
    }
    
    public void SetOrden()
    {
        Console.Write("\tNúmeros Ordenados: ");
        _datosNum.SetDatosOrdenados();
        Console.WriteLine("\n");
    }
    
    public void GenerarArchivo()
        {
            try
            {
                string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                
                string nuevaCarpeta = Path.Combine(docPath, "Ordenamiento");
                //Directory.CreateDirectory(nuevaCarpeta);

                //System.IO.File.Exists(nuevaCarpeta)
                if (!File.Exists(nuevaCarpeta))
                {
                    Directory.CreateDirectory(nuevaCarpeta);
                }

                string nombreArchivo = "Ordenamiento_por_Shell_"+(DateTime.UtcNow.Minute)+"_.txt";
                using (StreamWriter outputFile = new StreamWriter(Path.Combine(nuevaCarpeta, nombreArchivo), true))
                {
                    outputFile.WriteLine(
                        "\t* Universidad Nacional Abierta y a Distancia (UNAD) \n" +
                        "\t* Escuela de Ciencias Básicas, Tecnología e Ingeniería – ECBTI \n" +
                        "\t* Programación (213023_137) \n" +
                        "\t* Autor: Alfonso Gonzalez Posso \n" +
                        "\t* Etapa 4 - Tipos de Ordenamientos \n"
                    );
                    outputFile.WriteLine("\t\t\tOrdenamiento por Shell.");
                    outputFile.WriteLine();
                    outputFile.Write("\tOrden de Números Ingresados: [ ");
                    for (int i = 0; i < _datosNum.DatosIngresados.Length; i++)
                    {
                        outputFile.Write(_datosNum.DatosIngresados[i]);
                        if (i == _datosNum.DatosIngresados.Length - 1)
                        {
                            break;
                        }
                        outputFile.Write(" , ");
                    }
                    outputFile.Write(" ]\n");
                
                    outputFile.WriteLine();
                    outputFile.Write("\tNúmeros Ordenados: [ ");
                    for (int i = 0; i < _datosNum.DatosOrdenados.Length; i++)
                    {
                        outputFile.Write(_datosNum.DatosOrdenados[i]);
                        if (i == _datosNum.DatosOrdenados.Length - 1)
                        {
                            break;
                        }
                        outputFile.Write(" , ");
                    }
                    outputFile.Write(" ]\n");
                
                    outputFile.WriteLine("\nRuta del Archivo Guardado: {0}/{1}", docPath, nombreArchivo);
                    outputFile.Flush();
                    outputFile.Close();
                }
                Console.WriteLine("\nRuta del Archivo Generado: {0}/{1}", docPath, nombreArchivo);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error al Generar Archivo -> {0}", e);
                throw;
            }
        }
}