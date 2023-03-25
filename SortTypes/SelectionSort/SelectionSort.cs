namespace SortTypes.SelectionSort;

/*
 * Universidad Nacional Abierta y a Distancia (UNAD)
 * Escuela de Ciencias Básicas, Tecnología e Ingeniería – ECBTI
 * Programación (213023_137)
 * Autor: Alfonso Gonzalez Posso
 * Etapa 4 - Tipos de Ordenamientos
 *
 */

public class SelectionSort
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

    public void Selection_Sort()
    {
        int[]? datos = _datosNum.DatosOrdenados;

        int temp;

        for (int i = 0; i < datos.Length - 1; i++)
        {
            int jmin = i;
            for (int j = i + 1; j < datos.Length; j++)
            {
                if (datos[j] < datos[jmin])
                {
                    jmin = j;
                }
            }

            if (jmin != i)
            {
                temp = datos[i];
                datos[i] = datos[jmin];
                datos[jmin] = temp;
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

                string nombreArchivo = "Ordenamiento_por_Selección_"+(DateTime.UtcNow.Minute)+"_.txt";
                using (StreamWriter outputFile = new StreamWriter(Path.Combine(nuevaCarpeta, nombreArchivo), true))
                {
                    outputFile.WriteLine(
                        "\t* Universidad Nacional Abierta y a Distancia (UNAD) \n" +
                        "\t* Escuela de Ciencias Básicas, Tecnología e Ingeniería – ECBTI \n" +
                        "\t* Programación (213023_137) \n" +
                        "\t* Autor: Alfonso Gonzalez Posso \n" +
                        "\t* Etapa 4 - Tipos de Ordenamientos \n"
                    );
                    outputFile.WriteLine("\t\t\tOrdenamiento por Selección.");
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