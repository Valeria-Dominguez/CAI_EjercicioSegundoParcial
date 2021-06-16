using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ.PlazoFijo.Entidades
{
    public static class TipoPlazoFijoHelper
    {
        public static List<TipoPlazoFijo> GetTipos()
        {
            List<TipoPlazoFijo> tiposPlazosFijos = new List<TipoPlazoFijo>();
            TipoPlazoFijo s = new TipoPlazoFijo(0, 0, "Seleccione");
            TipoPlazoFijo w = new TipoPlazoFijo(1, 41, "Plazo Fijo Web");
            TipoPlazoFijo u = new TipoPlazoFijo(2, 3, "Plazo Fijo UVA");
            tiposPlazosFijos.Add(s);
            tiposPlazosFijos.Add(w);
            tiposPlazosFijos.Add(u);
            return tiposPlazosFijos;
        }
    }
}
