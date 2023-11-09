using Abstraccion;
using System;


public interface PromedioInterfaz
{
    float CalcularPromedio();
    bool Aprobar();
}

public class Promedio : PromedioInterfaz
{
  
    private float nota1;
    private float nota2;
    private float nota3;

  
    public Promedio(float nota1, float nota2, float nota3)
    {
        this.nota1 = nota1;
        this.nota2 = nota2;
        this.nota3 = nota3;
    }

    public float CalcularPromedio()
    {
        return (nota1 + nota2 + nota3) / 3;
    }

    public bool Aprobar()
    {
        return CalcularPromedio() >= 4;
    }
}

public class Notas
{
    public static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Ingrese la primera nota: ");
            float nota1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la segunda nota: ");
            float nota2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la tercera nota: ");
            float nota3 = float.Parse(Console.ReadLine());

            Promedio promedio = new Promedio(nota1, nota2, nota3);

            Console.WriteLine("El promedio de las notas es: " + promedio.CalcularPromedio());

            if (promedio.Aprobar())
            {
                Console.WriteLine("El alumno ha aprobado!");
            }
            else
            {
                Console.WriteLine("El alumno ha reprobado...");
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("Error al ingresar los datos: " + e.Message);
        }
    }
}