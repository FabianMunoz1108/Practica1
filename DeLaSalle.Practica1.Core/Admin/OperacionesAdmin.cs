using DeLaSalle.Practica1.Core.Admin.Interfaces;
using DeLaSalle.Practica1.Core.Entidades;
using DeLaSalle.Practica1.Core.Enums;
using DeLaSalle.Practica1.Core.Servicios.Interfaces;

namespace DeLaSalle.Practica1.Core.Admin
{
    public class OperacionesAdmin : IOperacionesAdmin
    {
        #region Campos
        private IOperacionesService _service;
        #endregion

        #region Constructores
        public OperacionesAdmin(IOperacionesService servicio)
        {
            _service = servicio;
        }
        #endregion

        #region Métodos
        public Calculo CalcularPeso(Persona persona, EnumPlaneta planeta)
        {
            return _service.ProcesarPeso(persona, planeta);
        }
        #endregion
    }
}