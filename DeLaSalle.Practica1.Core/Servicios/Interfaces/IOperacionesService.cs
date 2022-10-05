using DeLaSalle.Practica1.Core.Entidades;
using DeLaSalle.Practica1.Core.Enums;

namespace DeLaSalle.Practica1.Core.Servicios.Interfaces
{
    public interface IOperacionesService
    {
        Calculo ProcesarPeso(Persona p, EnumPlaneta planeta);
    }
}