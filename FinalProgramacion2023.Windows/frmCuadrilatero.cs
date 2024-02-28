using FinalProgramacion2023.Entidades;
using FinalProgramacion2023.Datos;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProgramacion2023.Windows
{
    public partial class frmCuadrilatero : Form
    {
        private Cuadrilateros cuadrilateros;

        public frmCuadrilatero()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (cuadrilateros != null)
            {
                txtLadoA.Text = cuadrilateros.ladoA.ToString();
                txtLadoB.Text = cuadrilateros.ladoB.ToString();
                cboRelleno.Text = cuadrilateros.Relleno.ToString();
                groupBox1.Text = cuadrilateros.Relleno.ToString();
                rbtRayas.Text = cuadrilateros.Relleno.ToString();
                rbtPuntos.Text = cuadrilateros.Relleno.ToString();
            }
        }


        internal Cuadrilateros GetCuadrilateros()
        {
            double ladoA = Convert.ToDouble(txtLadoA.Text);
            double ladoB = Convert.ToDouble(txtLadoB.Text);

            return cuadrilateros;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                cuadrilateros = new Cuadrilateros();
                cuadrilateros.ladoA = int.Parse(txtLadoA.Text);
                cuadrilateros.ladoB = int.Parse(txtLadoB.Text);
                cuadrilateros.Relleno = (int)cboRelleno.SelectedIndex;

                if (cuadrilateros.Validar())
                {
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("lados mal ingresados", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        internal void SetCuadrilateros(Cuadrilateros copiaCuadrilateros)
        {
            this.cuadrilateros = copiaCuadrilateros;
        }

        private bool ValidarDatos()
        {
            bool esValido = true;
            errorProvider1.Clear();
            if (!int.TryParse(txtLadoA.Text, out int ladoMayor))
            {
                esValido = false;
                errorProvider1.SetError(txtLadoA, "Lado mal ingresado");
            }

            if (!int.TryParse(txtLadoB.Text, out int ladoMenor))
            {
                esValido = false;
                errorProvider1.SetError(txtLadoB, "Lado mal ingresado");
            }

            return esValido;
        }
    }
}
