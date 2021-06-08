using LaBancaQueBanca_Datos;
using LaBancaQueBanca_Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaBancaQueBanca_Negocio
{
   public class PrestamosNegocio
    {
        PrestamosMapper _prestamosMapper;

        public PrestamosNegocio()
        {
            _prestamosMapper = new PrestamosMapper();
        }

        public List<TipoPrestamo> TraerTodosTiposPrestamos()
        {
            return _prestamosMapper.TraerTodosTiposPrestamos();
        }

        public TransactionResult darDeAlta(string linea, string monto, string plazo, string tna, TipoPrestamo tipoPrestamo)
        {
            try
            {
                Random random = new Random();
                Prestamo prestamo = new Prestamo();
                prestamo.Linea = linea;
                prestamo.Monto = Convert.ToDouble(monto);
                prestamo.Plazo = Convert.ToInt32(plazo);
                prestamo.Tna = Convert.ToDouble(tna);
                prestamo.Usuario = random.Next(50).ToString();
                prestamo.Id = 0;

                return _prestamosMapper.darDeAlta(prestamo);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Prestamo> TraerTodosPrestamos()
        {
            return _prestamosMapper.TraerTodosPrestamos();
        }
    }
}
