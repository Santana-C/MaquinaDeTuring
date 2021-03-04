using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaquinaDeTuring
{
    public partial class Nueva : Form
    {
        public Nueva()
        {
            InitializeComponent();
        }

        private void btnAgregarEspacio_Click(object sender, EventArgs e)
        {
            txtCadena.Text += "Δ";
            txtCadena.Focus();
            txtCadena.SelectionStart = txtCadena.Text.Length;
            txtCadena.SelectionLength = 0;
        }
        public string ObtenerCadena()
        {
            return txtCadena.Text;
        }
        public int ObtenerPosicionCabezal()
        {
            try
            {
                return int.Parse(txtPosicionCabezal.Text);
            }
            catch(Exception)
            {
                return 0;
            }
        }

        private void txtPosicionCabezal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
                e.Handled = false;
            else if (Char.IsControl(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }


        private void btnCrearMaquina_Click(object sender, EventArgs e)
        {
            AreaTrabajo.Maquina = new Modelos.MaquinaTuring();
            List<char> preAlfabeto = txtCadena.Text.ToList();
            List<char> alfabeto = new List<char>();
            foreach (char letra in preAlfabeto)
            {
                if (letra == 'Δ')
                    continue;
                if (!alfabeto.Contains(letra))
                    alfabeto.Add(letra);
            }
            AreaTrabajo.Maquina.Alfabeto = alfabeto.ToArray();
            AreaTrabajo.Maquina.Simbolos = alfabeto.ToArray();
            char[] cinta = txtCadena.Text.ToArray();
            AreaTrabajo.Maquina.Cinta = cinta;
            int posicionCabezal;
            try
            {
                posicionCabezal = int.Parse(txtPosicionCabezal.Text);
            }
            catch (Exception) 
            {
                posicionCabezal = 0;
            }
            AreaTrabajo.Maquina.Cabezal = posicionCabezal;
            AreaTrabajo.CintaOriginal = cinta;
            AreaTrabajo.CabezalOriginal = posicionCabezal;
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
