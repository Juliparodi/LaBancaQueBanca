using LaBancaQueBanca_Entidades.Entidades;
using LaBancaQueBanca_Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaBancaQueBanca_Console
{
    public partial class Form1 : Form
    {
        private PrestamosNegocio _prestamosNegocio;
        public Form1()
        {
            _prestamosNegocio = new PrestamosNegocio();
            InitializeComponent();
        }

        private void lstTiposPrestamos_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.lstTiposPrestamos.DataSource == null || this.lstTiposPrestamos.SelectedIndex == 0)
                {

                }
                else
                {
                    llenarCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void llenarCampos()
        {
         
            TipoPrestamo tipoPrestamo = (TipoPrestamo)lstTiposPrestamos.SelectedValue;
            if (tipoPrestamo == null)
            {
                throw new Exception("Tipo Prestamo vacio");
            }

            this.txtLinea.Text = tipoPrestamo.Linea;
            this.txtTNA.Text = tipoPrestamo.Tna.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.lstPrestamos.DataSource = null;
            this.lstTiposPrestamos.DataSource = _prestamosNegocio.TraerTodosTiposPrestamos();
            configurarBotones();
        }

        private void configurarBotones()
        {
            this.txtLinea.Text = String.Empty;
            this.txtTNA.Text = String.Empty;
            this.txtLinea.Enabled = false;
            this.txtTNA.Enabled = false;
            this.txtMonto.Text = String.Empty;
            this.txtPlazo.Text = String.Empty;
            this.txtCuotaCapital.Text = String.Empty;
            this.txtCuotaInteres.Text = String.Empty;
            this.txtCuotaTotal.Text = String.Empty;
            this.txtCuotaCapital.Enabled = false;
            this.txtCuotaInteres.Enabled = false;
            this.txtCuotaTotal.Enabled = false;
        }

        private void btnSimular_Click(object sender, EventArgs e)
        {
            try
            {
                validar();
                MostrarSimulacion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error al simular el prestamo");
                
            }

        }

        private void validar()
        {
            if(this.txtPlazo.Text==null || this.txtMonto.Text == null)
            {
                throw new Exception("Los parametros plazo o monto son nulos");
            }
        }

        private void MostrarSimulacion()
        {
            double monto = Convert.ToDouble(this.txtMonto.Text);
            int plazo = Convert.ToInt32(this.txtPlazo.Text);
            double tna = Convert.ToDouble(this.txtTNA.Text);
            Prestamo prestamo = new Prestamo(this.txtLinea.Text, tna, plazo, monto);

            double cuotaCapital = prestamo.cuotaCapital();
            this.txtCuotaCapital.Text = cuotaCapital.ToString();
            double cuotaIntereses = prestamo.cuotaInteres(cuotaCapital);
            this.txtCuotaInteres.Text = cuotaIntereses.ToString();
            double cuotaTotal = prestamo.cuota(cuotaCapital, cuotaIntereses);
            this.txtCuotaTotal.Text = cuotaTotal.ToString();
            
        }

        private void txtMonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar);
        }

        private void txtPlazo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar);
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            try
            {
                validar();
                TransactionResult result = _prestamosNegocio.darDeAlta(this.txtLinea.Text, this.txtMonto.Text, this.txtPlazo.Text, this.txtTNA.Text, conseguirTipoPrestamo());
                if (!result.IsOk)
                {
                    MessageBox.Show("Ha ocurrido un problema al dar de alta el prestamo");
                }
                else
                {
                    MessageBox.Show("prestamo con id: " + result.Id + " se ha ingresado exitosamente");
                    this.lstPrestamos.DataSource = null;
                    this.lstPrestamos.DataSource = _prestamosNegocio.TraerTodosPrestamos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
               
            }
        }

        private TipoPrestamo conseguirTipoPrestamo()
        {
            return new TipoPrestamo(txtLinea.Text, Convert.ToDouble(txtTNA.Text));
        }

        private void txtComisionTotal_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.lstPrestamos.DataSource == null)
                {
                    throw new Exception("No hay prestamos");
                }
                List<Prestamo> prestamos = (List<Prestamo>)this.lstPrestamos.DataSource;
                if (!prestamos.Any())
                {
                    throw new Exception("No hay prestamos a calcular");
                }
                this.txtComisionTotal.Text = Operador.calcularComision(prestamos).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
