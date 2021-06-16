using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ.PlazoFijo.Entidades
{
    public class Operador
    {
        private List<PlazoFijo1> _plazoFijo;

        public Operador(List<PlazoFijo1> plazoFijo)
        {
            _plazoFijo = plazoFijo;
        }

        public List<PlazoFijo1> PlazoFijo { get => _plazoFijo; set => _plazoFijo = value; }
        public double MontoTotal
        {
            get
            {
                double totalCapital = 0;
                foreach (PlazoFijo1 plazoFijo in this._plazoFijo)
                {
                    totalCapital = totalCapital + plazoFijo.CapitalInicial;
                }
                return totalCapital;
            }
        }
        public double Comision
        {
            get
            {
                double totalComision = 0;
                double comFijo = 15;
                double comVar = 0.01;
                foreach (PlazoFijo1 plazoFijo in this._plazoFijo)
                {
                    totalComision = totalComision + plazoFijo.Interes * comVar + comFijo;
                }
                return totalComision;
            }
        }
    } 
}
