using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace LaBancaQueBanca_Entidades.Entidades
{
    [DataContract]
    public class Prestamo
    {
        string _linea;
        double _tna;
        int _plazo;
        double _monto;
        string _usuario;
        int _id;
        TipoPrestamo _tipoPrestamo;

        public Prestamo() { }

        public Prestamo(string linea, double tna, int plazo, double monto, TipoPrestamo tipoPrestamo)
        {
            _linea = linea;
            _tna = tna;
            _plazo = plazo;
            _monto = monto;
            TipoPrestamo = tipoPrestamo;
        }

        public Prestamo(string linea, double tna, int plazo, double monto)
        {
            _linea = linea;
            _tna = tna;
            _plazo = plazo;
            _monto = monto;
        }

            [DataMember(Name = "linea")]
        public string Linea { get => _linea; set => _linea = value; }

        [DataMember(Name = "tna")]
        public double Tna { get => _tna; set => _tna = value; }

        [DataMember(Name = "plazo")]
        public int Plazo { get => _plazo; set => _plazo = value; }

        [DataMember(Name = "monto")]
        public double Monto { get => _monto; set => _monto = value; }

        [DataMember(Name = "usuario")]
        public string Usuario { get => _usuario; set => _usuario = value; }

        [DataMember(Name = "id")]
        public int Id { get => _id; set => _id = value; }

        [DataMember(Name = "tipoPrest")]
        public TipoPrestamo TipoPrestamo { get => _tipoPrestamo; set => _tipoPrestamo = value; }

        public double cuotaCapital()
        {
            return this.Monto / this.Plazo;
        }


        public double cuotaInteres(double cuotaCapital) 
        {
            return cuotaCapital * (this.Tna / 12 / 100);
        }

        public double cuota(double cuotaCapita, double cuotaIntereses)
        {
            return cuotaCapita + cuotaIntereses;
        }

        public override string ToString()
        {
            return "linea: " + this.Linea + " con TNA: " + this.Tna + " al usuario: " + this.Usuario;
        }
    }
}
