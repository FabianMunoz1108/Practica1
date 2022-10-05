using System.Reflection;

namespace DeLaSalle.Practica1.Core.Enums
{
    public enum EnumPlaneta : int
    {
        [StringValue("3.7")]
        Mercurio = 1,
        [StringValue("8.87")]
        Venus = 2,
        [StringValue("9.807")]
        Tierra = 3,
        [StringValue("3.721")]
        Marte = 4,
        [StringValue("24.79")]
        Jupiter = 5,
        [StringValue("10.44")]
        Saturno = 6,
        [StringValue("8.87")]
        Urano = 7,
        [StringValue("11.15")]
        Neptuno = 8
    }
    public sealed class StringValue : System.Attribute
    {
        public StringValue(string valor)
        {
            this.Valor = valor;
        }

        public string Valor { get; internal set; }
    }
    public static class StringEnumHelper
    {
        #region Métodos
        /// <summary>
        /// Método que realiza la extracción de la descripción de un enumerador que implementa el atributo StringValue.
        /// </summary>
        /// <returns>La descripción del enumerador que implementa el atributo StringValue.</returns>
        /// <param name="enumerador">El enumerador que implementa el atributo StringValue.</param>
        public static string? GetStringValue(Enum enumerador)
        {
            string? salida = null;
            Type tipo = enumerador.GetType();
            FieldInfo? campo = tipo.GetField(enumerador.ToString());
            StringValue[]? atributos = campo != null ? campo.GetCustomAttributes(typeof(StringValue), false) as StringValue[] : null;

            if (atributos != null && atributos.Length > 0)
            {
                salida = atributos[0].Valor;
            }
            return salida;
        }

        #endregion
    }
}