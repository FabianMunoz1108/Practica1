using DeLaSalle.Practica1.Core.Entidades;
using DeLaSalle.Practica1.Core.Enums;

namespace DeLaSalle.Practica1.Core.Admin.Interfaces
{
    internal interface IOperacionesAdmin
    {
        Calculo CalcularPeso(Persona persona, EnumPlaneta planeta);
    }
}