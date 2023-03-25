namespace SortTypes;

/*
 * Universidad Nacional Abierta y a Distancia (UNAD)
 * Escuela de Ciencias Básicas, Tecnología e Ingeniería – ECBTI
 * Programación (213023_137)
 * Autor: Alfonso Gonzalez Posso
 * Etapa 4 - Tipos de Ordenamientos
 *
 */
public class GuardarTxt
{
    public void GenerarArchivo(string nombreArchivoG, int[] datosIngresados, int[] datosOrdenados)
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

            string nombreArchivo = nombreArchivoG + "_" + (DateTime.UtcNow.Minute) + "_.txt";
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(nuevaCarpeta, nombreArchivo), true))
            {
                outputFile.WriteLine("\t{0}", nombreArchivoG);
                outputFile.WriteLine();
                outputFile.Write("Orden de Números Ingresados: [ ");
                for (int i = 0; i < datosIngresados.Length; i++)
                {
                    outputFile.Write(datosIngresados[i]);
                    if (i == datosIngresados.Length - 1)
                    {
                        break;
                    }

                    outputFile.Write(" , ");
                }

                outputFile.Write(" ]\n");

                outputFile.WriteLine();
                outputFile.Write("Números Ordenados: [ ");
                for (int i = 0; i < datosOrdenados.Length; i++)
                {
                    outputFile.Write(datosOrdenados[i]);
                    if (i == datosOrdenados.Length - 1)
                    {
                        break;
                    }

                    outputFile.Write(" , ");
                }

                outputFile.Write(" ]\n");

                outputFile.WriteLine("Ruta del Archivo Guardado: {0}/{1}", docPath, nombreArchivo);
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