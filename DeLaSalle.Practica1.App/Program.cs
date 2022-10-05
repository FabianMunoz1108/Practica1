using DeLaSalle.Practica1.Core.Admin;
using DeLaSalle.Practica1.Core.Entidades;
using DeLaSalle.Practica1.Core.Enums;
using DeLaSalle.Practica1.Core.Servicios;

namespace DeLaSalle.Practica1.App;
public class Program
{

    public static void Main(string[] args)
    {
        Console.WriteLine("*********************************************************");
        Console.WriteLine("*\tCalcula tu peso en los siguientes planetas\t*");
        foreach (EnumPlaneta item in Enum.GetValues(typeof(EnumPlaneta)))
        {
            Console.WriteLine($"*\t{(int)item} = {item} \tGravedad({StringEnumHelper.GetStringValue(item)} m/s²)\t\t*");
        }
        Console.WriteLine("*********************************************************");
        bool bandera = true;

        while (bandera)
        {
            Console.WriteLine("Ingresa el peso en kg");
            string? p = Console.ReadLine();

            if (float.TryParse(p, out float peso) && peso > 0)
            {
                EnumPlaneta planeta;
                Console.WriteLine("Ingresa el número que corresponde al planeta deseado");
                string? o = Console.ReadLine();
                if (!Enum.TryParse(o, out planeta))
                {
                    planeta = EnumPlaneta.Marte;
                    Console.WriteLine($"El planeta seleccionado no es válido, el cálculo se realizará por defecto con el planeta {planeta}");
                }
                OperacionesAdmin admin = new(new OperacionesService());
                Calculo cal = admin.CalcularPeso(new Persona() { Peso = peso }, planeta);
                Console.WriteLine($"Tu peso en {planeta} es de {cal.Peso} kg");

                /*Se pregunta a usuario sí desea continuar con otra operación*/
                Console.WriteLine("¿Desea calcular otro peso? s=si n=No");
                bandera = Console.ReadLine() == "s";
            }
            else
            {
                Console.WriteLine(string.Format("El valor '{0}' no es un peso válido", p));
            }
        }
        Console.WriteLine("Cálculo finalizado");
    }
}