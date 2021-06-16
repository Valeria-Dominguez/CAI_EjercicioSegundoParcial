using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EJ.PlazoFijo.Entidades;
using Newtonsoft.Json;

namespace EJ.PlazoFijo.Datos
{
    public class PlazoFijoMapper
    {
        static string rutaMapper;
        static string registro;

        public PlazoFijoMapper()
        {
            rutaMapper = ConfigurationManager.AppSettings["URL_PLAZO_FIJO"];
            registro = ConfigurationManager.AppSettings["REGISTRO"];
        }

        public List<PlazoFijo1> TraerTodos()
        {
            string json = WebHelper.Get(rutaMapper+registro);
            List<PlazoFijo1> result = MapList(json);
            return result;
        }

        private List<PlazoFijo1> MapList(string json)
        {
            List<PlazoFijo1> list = JsonConvert.DeserializeObject<List<PlazoFijo1>>(json);
            return list;
        }

        public ResultadoTransaccion Agregar (PlazoFijo1 plazoFijo)
        {
            NameValueCollection parametros = ReverseMap(plazoFijo);
            string json = WebHelper.Post(rutaMapper, parametros);
            ResultadoTransaccion resultado = JsonConvert.DeserializeObject<ResultadoTransaccion>(json);
            return resultado;
        }

        private NameValueCollection ReverseMap(PlazoFijo1 plazoFijo)
        {
            NameValueCollection n = new NameValueCollection();
            n.Add("idCliente", "0");
            n.Add("id", "0");
            n.Add("Tipo", plazoFijo.Tipo.ToString());
            n.Add("Dias", plazoFijo.Dias.ToString());
            n.Add("CapitalInicial", plazoFijo.CapitalInicial.ToString("0.00"));
            n.Add("Tasa", plazoFijo.Tasa.ToString("0.00"));
            n.Add("Interes", plazoFijo.Interes.ToString("0.00"));
            n.Add("Usuario", registro);
            return n;

        }
    }
}
