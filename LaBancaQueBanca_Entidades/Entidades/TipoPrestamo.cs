using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace LaBancaQueBanca_Entidades.Entidades
{
    [DataContract]
    public class TipoPrestamo
    {
        String _linea;
        double _tna;
        int _id;

        public TipoPrestamo(string linea, double tna)
        {
            _linea = linea;
            _tna = tna;
            _id = 0;
        }

        [DataMember(Name = "linea")]
        public string Linea { get => _linea; set => _linea = value; }

        [DataMember(Name = "tna")]
        public double Tna { get => _tna; set => _tna = value; }

        [DataMember(Name = "id")]
        public int Id { get => _id; set => _id = value; }

        public override string ToString()
        {
            return "Tipo prestamo: " + this.Linea;
        }
    }
}
