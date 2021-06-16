using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace EJ.PlazoFijo.Entidades
{
    [DataContract]
    public class PlazoFijo1
    {
        private int _id;
        private int _idCliente;
        private int _tipo;
        private double _tasa;
        private int _dias;
        private double _capitalInicial;
        private string _usuario;

        public PlazoFijo1()
        {
        }

        public PlazoFijo1(double tasa, int dias, double capitalInicial)
        {
            _tasa = tasa;
            _dias = dias;
            _capitalInicial = capitalInicial;
        }

        public PlazoFijo1(int tipo, double tasa, int dias, double capitalInicial)
        {
            _tipo = tipo;
            _tasa = tasa;
            _dias = dias;
            _capitalInicial = capitalInicial;
        }

        [DataMember(Name = "id")]
        public int id { get => _id; set => _id = value; }
        [DataMember(Name = "idCliente")]
        public int idCliente { get => _idCliente; set => _idCliente = value; }
        [DataMember(Name = "tipo")]
        public int Tipo { get => _tipo; set => _tipo = value; }
        [DataMember(Name = "tasa")]
        public double Tasa { get => _tasa; set => _tasa = value; }
        [DataMember(Name = "dias")]
        public int Dias { get => _dias; set => _dias = value; }
        [DataMember(Name = "capitalInicial")]
        public double CapitalInicial { get => _capitalInicial; set => _capitalInicial = value; }
        [DataMember(Name = "usuario")]
        public string Usuario { get => _usuario; set => _usuario = value; }

        [DataMember(Name = "interes")]
        public double Interes { get => ((this._tasa / 365 * this._dias) * this._capitalInicial) / 100; }
        public double MontoFinal { get => this._capitalInicial  + this.Interes; }

        public override string ToString()
        {
            return $"{this.id}) {this._dias} días - ARS {this._capitalInicial} (interés {this.Interes})";
        }
    }
}
