using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace EJ.PlazoFijo.Entidades
{
    [DataContract]
    public class ResultadoTransaccion
    {
        [DataMember]
        public bool isOk { get; set; }
        [DataMember]
        public string error { get; set; }
        [DataMember]
        public int id { get; set; }

        public override string ToString()
        {
            if (isOk)
                return $"Operación exitosa: {this.id}";
            else
                return $"La operación no pudo realizarse: {this.error}";
        }


    }

}
