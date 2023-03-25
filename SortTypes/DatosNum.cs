namespace SortTypes;

/*
 * Universidad Nacional Abierta y a Distancia (UNAD)
 * Escuela de Ciencias Básicas, Tecnología e Ingeniería – ECBTI
 * Programación (213023_137)
 * Autor: Alfonso Gonzalez Posso
 * Etapa 4 - Tipos de Ordenamientos
 *
 */

public class DatosNum
{
     private int[]? datos;
     private int[]? datosIngresados;

     public void IngresarDatos()
     {            
         try
         {
             Console.Write("Ingrese la cantidad de datos a ordenar -> ");
             int cant = Int32.Parse(Console.ReadLine());
             datos = new int[cant];
             datosIngresados = new int[cant];

             int newNumero;

             for (int i = 0; i < datos.Length; i++)
             {
                 Console.Write("{0}. Ingrese el valor: ", i+1);
                 newNumero = Int32.Parse(Console.ReadLine());
                 datos[i] = newNumero;
                 datosIngresados[i] = newNumero;
             }
         }
         catch (FormatException ex)
         {
             //Console.WriteLine("Por favor ingresa un valor válido. {0}", ex.Message);
             throw;
         }
         catch (ArgumentOutOfRangeException ex)
         {
             //Console.WriteLine("El rango del número ingresado no es correcto, por favor valide de nuevo.{0}", ex.Message);
             throw;
         }
         catch (Exception ex)
         {
             //Console.WriteLine("Error inesperado.. {0}", ex.Message);
             throw;
         }
     }
     
     public int[]? DatosIngresados
     {
         get => datosIngresados;
         set => datosIngresados = value;
     }

     public int[]? DatosOrdenados
     {
         get => datos;
         set => datos = value;
     }

     public void SetDatosIngresados()
     {
         Console.Write("[ ");
         for (int i = 0; i < DatosIngresados.Length; i++)
         {
             Console.Write(DatosIngresados[i]);
             if (i == DatosIngresados.Length - 1)
             {
                 break;
             }
             Console.Write(" , ");
         }
         Console.Write(" ]");
     }
     
     public void SetDatosOrdenados()
     {
         Console.Write("[ ");
         for (int i = 0; i < DatosOrdenados.Length; i++)
         {
             Console.Write(DatosOrdenados[i]);
             if (i == DatosOrdenados.Length - 1)
             {
                 break;
             }
             Console.Write(" , ");
         }
         Console.Write(" ]");
     }
}