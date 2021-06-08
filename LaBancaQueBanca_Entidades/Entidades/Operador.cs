using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaBancaQueBanca_Entidades.Entidades
{
    public class Operador
    {
        List<Prestamo> _prestamos;
        double _comision;
        double _porcentajeComision;

        public List<Prestamo> Prestamos { get => _prestamos; set => _prestamos = value; }
        public double Comision { get => _comision; set => _comision = value; }
        public double PorcentajeComision { get => _porcentajeComision; set => _porcentajeComision = value; }

        public static double calcularComision(List<Prestamo> prestamos)
        {
            double porcentajeComision = 0.15;
            double comision = 0;
            foreach(Prestamo prestamo in prestamos)
            {
                double cuotaCapital = prestamo.cuotaCapital();
                double cuotaIntereses = prestamo.cuotaInteres(cuotaCapital);
                double cuotaTotal = prestamo.cuota(cuotaCapital, cuotaIntereses);
                comision = comision + (cuotaTotal * porcentajeComision);
            }
            return comision;

        }
    }
}
