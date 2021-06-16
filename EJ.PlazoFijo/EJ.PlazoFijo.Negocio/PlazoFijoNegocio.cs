using EJ.PlazoFijo.Datos;
using EJ.PlazoFijo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ.PlazoFijo.Negocio
{
    public class PlazoFijoNegocio
    {
        PlazoFijoMapper _plazoFijoMapper;

        public PlazoFijoNegocio()
        {
            this._plazoFijoMapper = new PlazoFijoMapper();
        }

        public Operador Traer()
        {
            Operador operador = new Operador(this._plazoFijoMapper.TraerTodos());
            return operador;
        }

        public ResultadoTransaccion Agregar (PlazoFijo1 plazoFijo)
        {
            if (plazoFijo.CapitalInicial > 1000000)
                throw new Exception("El importe del plazo fijo no debe superar ARS 1,000,000");
            ResultadoTransaccion resultado = this._plazoFijoMapper.Agregar(plazoFijo);
            return resultado;

        }
    }
}
