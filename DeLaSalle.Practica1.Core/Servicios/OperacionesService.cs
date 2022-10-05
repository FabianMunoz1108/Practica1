using DeLaSalle.Practica1.Core.Entidades;
using DeLaSalle.Practica1.Core.Enums;
using DeLaSalle.Practica1.Core.Servicios.Interfaces;

namespace DeLaSalle.Practica1.Core.Servicios
{
    public class OperacionesService : IOperacionesService
    {
        public Calculo ProcesarPeso(Persona p, EnumPlaneta planeta)
        {
            Calculo c = new();
            /*Obtención de gravedad en la Tierra*/
            float.TryParse(StringEnumHelper.GetStringValue(EnumPlaneta.Tierra), out float gravedadTierra);
            float.TryParse(StringEnumHelper.GetStringValue(planeta), out float gravedad);

            c.Peso = (p.Peso / gravedadTierra) * gravedad;
            return c;
        }
    }
}