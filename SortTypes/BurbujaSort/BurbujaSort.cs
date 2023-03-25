/*
 * Universidad Nacional Abierta y a Distancia (UNAD)
 * Escuela de Ciencias Básicas, Tecnología e Ingeniería – ECBTI
 * Programación (213023_137)
 * Autor: Alfonso Gonzalez Posso
 * Etapa 4 - Tipos de Ordenamientos
 *
 */

namespace SortTypes.BurbujaSort
{
    internal class BurbujaSort
    {
        DatosNum datosNum = new DatosNum();

        public void addDatos()
        {
            datosNum.IngresarDatos();
            
            Console.WriteLine();
            Console.Write("\tOrden de Números Ingresados: ");
            datosNum.SetDatosIngresados();
            Console.WriteLine();
            Console.WriteLine("\nCantidad de Números Ingresados -> {0}", datosNum.DatosIngresados.Length);
            Console.WriteLine();
        }
        
        public void Burbuja_Sort()
        {
            int temp;
            for (int i = 0; i < datosNum.DatosOrdenados.Length; i++)
            {
                for (int j = 0; j < datosNum.DatosOrdenados.Length - 1; j++)
                {
                    if (datosNum.DatosOrdenados[j + 1] < datosNum.DatosOrdenados[j])
                    {
                        temp = datosNum.DatosOrdenados[j + 1];
                        datosNum.DatosOrdenados[j + 1] = datosNum.DatosOrdenados[j];
                        datosNum.DatosOrdenados[j] = temp;
                    }
                }
            }
        }

        public void SetOrden()
        {
            Console.Write("\tNúmeros Ordenados: ");
            datosNum.SetDatosOrdenados();
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

                string nombreArchivo = "Ordenamiento_por_Burbuja_"+(DateTime.UtcNow.Minute)+"_.txt";
                using (StreamWriter outputFile = new StreamWriter(Path.Combine(nuevaCarpeta, nombreArchivo), true))
                {
                    outputFile.WriteLine(
                        "\t* Universidad Nacional Abierta y a Distancia (UNAD) \n" +
                        "\t* Escuela de Ciencias Básicas, Tecnología e Ingeniería – ECBTI \n" +
                        "\t* Programación (213023_137) \n" +
                        "\t* Autor: Alfonso Gonzalez Posso \n" +
                        "\t* Etapa 4 - Tipos de Ordenamientos \n"
                    );
                    outputFile.WriteLine("\t\t\tOrdenamiento por Burbuja.");
                    outputFile.WriteLine();
                    outputFile.Write("\tOrden de Números Ingresados: [ ");
                    for (int i = 0; i < datosNum.DatosIngresados.Length; i++)
                    {
                        outputFile.Write(datosNum.DatosIngresados[i]);
                        if (i == datosNum.DatosIngresados.Length - 1)
                        {
                            break;
                        }
                        outputFile.Write(" , ");
                    }
                    outputFile.Write(" ]\n");
                
                    outputFile.WriteLine();
                    outputFile.Write("\tNúmeros Ordenados: [ ");
                    for (int i = 0; i < datosNum.DatosOrdenados.Length; i++)
                    {
                        outputFile.Write(datosNum.DatosOrdenados[i]);
                        if (i == datosNum.DatosOrdenados.Length - 1)
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
}