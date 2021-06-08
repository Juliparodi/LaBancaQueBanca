using LaBancaQueBanca_Entidades.Entidades;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaBancaQueBanca_Datos
{

    public class PrestamosMapper
    {
        public List<TipoPrestamo> TraerTodosTiposPrestamos()
        {
            try
            {
                string json2 = WebHelper.Get("prestamoTipo"); // trae un texto en formato json de una web
                List<TipoPrestamo> resultado = MapListTipoPrestamo(json2);
                return resultado;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }
        }

        private List<TipoPrestamo> MapListTipoPrestamo(string json)
        {
            return JsonConvert.DeserializeObject<List<TipoPrestamo>>(json);
        }

        private List<Prestamo> MapListPrestamo(string json)
        {
            return JsonConvert.DeserializeObject<List<Prestamo>>(json);
        }


        private NameValueCollection ReverseMap(Prestamo prestamo)
        {
            NameValueCollection n = new NameValueCollection();

            n.Add("id", prestamo.Id.ToString());
            n.Add("tna", prestamo.Tna.ToString("0.00"));
            n.Add("linea", prestamo.Linea);
            n.Add("plazo", prestamo.Plazo.ToString("0.00"));
            n.Add("monto", prestamo.Monto.ToString("0.00"));
            n.Add("usuario", prestamo.Usuario);
           // n.Add("tipoPrest", prestamo.TipoPrestamo.Id.ToString);

            /*
            n.Add("nroCuenta", cuenta.NroCuenta.ToString());
            n.Add("descripcion", cuenta.Descripcion);
            n.Add("saldo", cuenta.Saldo.ToString("0.00"));
            n.Add("fechaApertura", cuenta.FechaApertura.ToString("yyyy-MM-dd"));
            n.Add("fechaModificacion", cuenta.FechaModificacion.ToString("yyyy-MM-dd"));
            n.Add("activo", cuenta.Activo.ToString());
            n.Add("idCliente", cuenta.IdCliente.ToString());
            n.Add("id", cuenta.Id.ToString());
            */
            return n;
        }

        public List<Prestamo> TraerTodosPrestamos()
        {
            try
            {
                string json2 = WebHelper.Get("prestamoTipo"); // trae un texto en formato json de una web
                List<Prestamo> resultado = MapListPrestamo(json2);
                return resultado;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }
        }

        public TransactionResult darDeAlta(Prestamo prestamo)
        {
            try
            {
                NameValueCollection obj = ReverseMap(prestamo);

                string json = WebHelper.Post("prestamo", obj);

                TransactionResult lst = JsonConvert.DeserializeObject<TransactionResult>(json);

                if (!lst.IsOk)
                {
                    throw new Exception("No se pudo ingresar el prestamo para el id : " + prestamo.Id);
                }
                else
                {
                    return lst;
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

   
    }
}
