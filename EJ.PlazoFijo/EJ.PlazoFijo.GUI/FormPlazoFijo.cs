using EJ.PlazoFijo.Entidades;
using EJ.PlazoFijo.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EJ.PlazoFijo.GUI
{
    public partial class FormPlazoFijo : Form
    {
        PlazoFijoNegocio _plazoFijoNegocio;
        public FormPlazoFijo()
        {
            this._plazoFijoNegocio = new PlazoFijoNegocio();
            InitializeComponent();
        }

        private void FormPlazoFijo_Load(object sender, EventArgs e)
        {
            CargarTiposPlazoFijo();
            CargarListaPlazosFijos();
        }

        private void CargarListaPlazosFijos()
        {
            try
            {
                Operador operador = this._plazoFijoNegocio.Traer();
                lstPlazoFijo.DataSource = null;
                lstPlazoFijo.DataSource = operador.PlazoFijo;
                txtMontoTotal.Text = operador.MontoTotal.ToString("0.00");
                txtComTotal.Text = operador.Comision.ToString("0.00");
            }
            catch (Exception exe)
            {
                MessageBox.Show(exe.Message);
            }
        }

        private void CargarTiposPlazoFijo()
        {
            try
            {
                cmbTipoPF.DataSource = null;
                cmbTipoPF.DataSource = TipoPlazoFijoHelper.GetTipos();
                cmbTipoPF.DisplayMember = "Descripcion";
            }
            catch (Exception exe)
            {
                MessageBox.Show(exe.Message);
            }
        }

        private void cmbTipoPF_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTipoPF.DataSource != null)
            {
                TipoPlazoFijo tipoSeleccionado = (TipoPlazoFijo)cmbTipoPF.SelectedItem;
                txtTasaInt.Text = tipoSeleccionado.Tasa.ToString();
            }
        }

        private void btnSimular_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbTipoPF.SelectedIndex == 0)
                    throw new Exception("Debe seleccionar un tipo de plazo fijo");
                ValidarCampos();
                TipoPlazoFijo tipoSeleccionado = (TipoPlazoFijo)cmbTipoPF.SelectedItem;
                PlazoFijo1 simulacionPlazoFijo = new PlazoFijo1(tipoSeleccionado.Tasa, int.Parse(txtDias.Text), double.Parse(txtCapital.Text));
                txtInteres.Text = simulacionPlazoFijo.Interes.ToString("0.00");
                txtMontoFinal.Text = simulacionPlazoFijo.MontoFinal.ToString("0.00");
            }
            catch (Exception exe)
            {
                MessageBox.Show(exe.Message);
            }
        }

        private void ValidarCampos()
        {
            if (!int.TryParse(txtDias.Text, out int dias))
                throw new Exception("Días: Debe ingresar un número");

            if (!double.TryParse(txtCapital.Text, out double capital))
                throw new Exception("Capital: Debe ingresar un número");
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbTipoPF.SelectedIndex == 0)
                    throw new Exception("Debe seleccionar un tipo de plazo fijo");
                ValidarCampos();
                TipoPlazoFijo tipoSeleccionado = (TipoPlazoFijo)cmbTipoPF.SelectedItem;
                PlazoFijo1 nuevoPlazoFijo = new PlazoFijo1(tipoSeleccionado.Id, tipoSeleccionado.Tasa, int.Parse(txtDias.Text), double.Parse(txtCapital.Text));
                ResultadoTransaccion resultado = this._plazoFijoNegocio.Agregar(nuevoPlazoFijo);
                MessageBox.Show(resultado.ToString());
                CargarListaPlazosFijos();
                LimpiarCampos();
            }
            catch (Exception exe)
            {
                MessageBox.Show(exe.Message);
            }
        }

        private void LimpiarCampos()
        {
            cmbTipoPF.SelectedIndex = 0;
            txtTasaInt.Text = string.Empty;
            txtCapital.Text = string.Empty;
            txtInteres.Text = string.Empty;
            txtMontoFinal.Text = string.Empty;
            txtDias.Text = string.Empty;
        }
    }
}
