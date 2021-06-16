using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ.PlazoFijo.Entidades
{
    public class TipoPlazoFijo
    {
        private int _id;
        private double _tasa;
        private string _descripcion;

        public TipoPlazoFijo(int id, double tasa, string descripcion)
        {
            _id = id;
            _tasa = tasa;
            _descripcion = descripcion;
        }

        public int Id { get => _id; set => _id = value; }
        public double Tasa { get => _tasa; set => _tasa = value; }
        public string Descripcion { get => _descripcion; set => _descripcion = value; }
    }
}
