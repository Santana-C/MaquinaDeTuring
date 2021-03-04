using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaquinaDeTuring
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            dgvCinta.Rows.Add("Δ", "Δ", "Δ", "Δ", "Δ", "Δ", "Δ", "Δ", "Δ", "Δ");
            gpbAlfabeto.ForeColor = Color.White;
            gpbSimbolosCinta.ForeColor = Color.White;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Nueva nuevaDialog = new Nueva();
            nuevaDialog.ShowDialog();
            if(AreaTrabajo.Maquina != null)
            {
                pnlContenido.Enabled = true;
                dgvCinta.Columns.Clear();
                for (int i = 0; i < AreaTrabajo.Maquina.Cinta.Length; i++)
                {
                    dgvCinta.Columns.Add($"Celda{i}", $"Celda{i}");
                }
                dgvCinta.Rows.Add();
                for (int i = 0; i < dgvCinta.Columns.Count; i++)
                {
                    dgvCinta.Rows[0].Cells[i].Value = AreaTrabajo.Maquina.Cinta[i];
                }
                lblAlfabeto.Text = "Σ = { "+AreaTrabajo.Maquina.AlfabetoToString()+" }";
                lblSimbolosCinta.Text = "Γ = { " + AreaTrabajo.Maquina.SimbolosToString() + " }";
                if(AreaTrabajo.Maquina.Cabezal > 0)
                    dgvCinta.CurrentCell = dgvCinta.Rows[0].Cells[AreaTrabajo.Maquina.Cabezal-1];
                else
                    dgvCinta.CurrentCell = dgvCinta.Rows[0].Cells[0];
                dgvEstados.Rows.Clear();
                dgvTransiciones.Rows.Clear();
            }
            
        }

        private void GenerarImagen()
        {
            List<string> definiciones = new List<string>()
            {
                "digraph maquina{",
                "rankdir=LR",
                "bgcolor=white",
                "node [shape = none, fontcolor=white] _",
                $"node [shape = doublecircle, fontcolor=black, style=\"filled\"] {AreaTrabajo.Maquina.EstadoFinal}",
                "node [shape = circle, style=\"filled\",color=black,fillcolor=\"#FFFFFF\",fontcolor=black]",
                "_ -> q0"
            };
            definiciones.AddRange(AreaTrabajo.Maquina.ObtenerAristas());
            definiciones.Add("}");
            string pathArchivoDot = "C:\\MaquinaTuringResources\\maquinaTuring.dot";
            if (!File.Exists(pathArchivoDot))
            {
                File.CreateText(pathArchivoDot);
            }
            string pathArchivoBat = "C:\\MaquinaTuringResources\\HacerDiagrama.bat";
            if (!File.Exists(pathArchivoBat))
            {
                using (StreamWriter sw = File.CreateText(pathArchivoBat))
                {
                    sw.WriteLine("@echo off");
                    sw.WriteLine("cd C:\\MaquinaTuringResources\\");
                    sw.WriteLine("dot.exe -Tpng maquinaTuring.dot -o maquinaTuring.png");
                }
            }
            File.WriteAllLines("C:\\MaquinaTuringResources\\maquinaTuring.dot", definiciones.ToArray());
            string direccionBat = @"C:\MaquinaTuringResources\HacerDiagrama.bat";
            Process process = new Process();
            process.StartInfo.FileName = direccionBat;
            process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            process.Start();
            process.WaitForExit();
        }

        private void btnAgregarEstado_Click(object sender, EventArgs e)
        {
            Estado estado = new Estado();
            if (AreaTrabajo.Maquina.Estados.Count == 0)
            {
                estado.Id = "q0";
                AreaTrabajo.Maquina.EstadoInicial = estado;
            }
            else
            {
                int cvo = int.Parse(AreaTrabajo.Maquina.Estados.Last().Id.Substring(1))  + 1;
                estado.Id = $"q{cvo}";
            }
            AreaTrabajo.Maquina.Estados.Add(estado);
            MostrarEstados();
            cargarDatosParaTransiciones();
        }

        private void btnAgregarTransicion_Click(object sender, EventArgs e)
        {
            if(cboDestino.Text == "" || cboEscritura.Text == "" || cboLectura.Text == "")
                MessageBox.Show("Llene los campos para poder agregar una transición adecuada.", "Rellene los campos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                try
                {
                    Transicion transicion = new Transicion();
                    Estado estadoOrigen = AreaTrabajo.Maquina.ObtenerEstado(dgvEstados.CurrentRow.Cells[0].Value.ToString());
                    Estado estadoDestino = AreaTrabajo.Maquina.ObtenerEstado(cboDestino.Text);
                    transicion.Origen = estadoOrigen;
                    transicion.Destino = estadoDestino;
                    transicion.Lectura = char.Parse(cboLectura.Text);
                    transicion.Escritura = char.Parse(cboEscritura.Text);
                    if (cboDireccion.Text == "D")
                        transicion.Direccion = 1;
                    else if (cboDireccion.Text == "N")
                        transicion.Direccion = 0;
                    else
                        transicion.Direccion = -1;
                    estadoOrigen.Transiciones.Add(transicion);
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            List<char> simbolos = AreaTrabajo.Maquina.Simbolos.ToList();
            if (!simbolos.Contains(char.Parse(cboLectura.Text)))
                AreaTrabajo.Maquina.AgregarSimbolo(char.Parse(cboLectura.Text));
            if (!simbolos.Contains(char.Parse(cboEscritura.Text)))
                AreaTrabajo.Maquina.AgregarSimbolo(char.Parse(cboEscritura.Text));
            MostrarTransiciones();
            cargarDatosParaTransiciones();
        }

        private void cargarDatosParaTransiciones()
        {
            cboDestino.Items.Clear();
            foreach (Estado estado in AreaTrabajo.Maquina.Estados)
            {
                cboDestino.Items.Add(estado);
            }
            cboDestino.SelectedIndex = -1;
            cboEscritura.Items.Clear();
            foreach (char simbolo in AreaTrabajo.Maquina.Simbolos)
            {
                cboEscritura.Items.Add(simbolo);
            }
            cboEscritura.SelectedIndex = -1;
            cboLectura.Items.Clear();
            foreach (char simbolo in AreaTrabajo.Maquina.Simbolos)
            {
                cboLectura.Items.Add(simbolo);
            }
            cboLectura.SelectedIndex = -1;
        }
        private void MostrarEstados()
        {
            dgvEstados.Rows.Clear();
            foreach (Estado estado in AreaTrabajo.Maquina.Estados)
                dgvEstados.Rows.Add(estado);
        }
        private void MostrarTransiciones()
        {
            dgvTransiciones.Rows.Clear();
            Estado estado = AreaTrabajo.Maquina.ObtenerEstado(dgvEstados.CurrentRow.Cells[0].Value.ToString());
            foreach (Transicion transicion in AreaTrabajo.Maquina.ObtenerTransiciones(dgvEstados.CurrentRow.Cells[0].Value.ToString()))
                dgvTransiciones.Rows.Add(transicion);
        }

        private void btnMarcarEstadoFinal_Click(object sender, EventArgs e)
        {
            AreaTrabajo.Maquina.EstadoFinal = AreaTrabajo.Maquina.ObtenerEstado(dgvEstados.CurrentRow.Cells[0].Value.ToString());
            MessageBox.Show($"Se ha asignado el estado final como: {AreaTrabajo.Maquina.EstadoFinal}", "Asignación de estado final.", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnEliminarEstado_Click(object sender, EventArgs e)
        {
            string id = dgvEstados.CurrentRow.Cells[0].Value.ToString();
            if (id == "q0")
                MessageBox.Show("no es posible eliminar el estado inicial.");
            else
            {
                try
                {
                    AreaTrabajo.Maquina.EliminarEstado(id);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            MostrarEstados();
            MostrarTransiciones();
            cargarDatosParaTransiciones();
        }

        private void btnEliminarTransicion_Click(object sender, EventArgs e)
        {
            //TODO
        }

        private void dgvEstados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MostrarTransiciones();
            cargarDatosParaTransiciones();
        }

        private void dgvEstados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MostrarTransiciones();
            cargarDatosParaTransiciones();
        }

        private void btnRecargarImagen_Click(object sender, EventArgs e)
        {
            this.GenerarImagen();
            Form frmNuevaVentana = new Form();
            frmNuevaVentana.Width = 1000;
            frmNuevaVentana.Height = 600;
            frmNuevaVentana.AutoScroll = true;
            frmNuevaVentana.Text = "Máquina de Turing";
            frmNuevaVentana.StartPosition = FormStartPosition.CenterScreen;
            frmNuevaVentana.Show();
            PictureBox picMT = new PictureBox();
            picMT.Parent = frmNuevaVentana;
            picMT.SizeMode = PictureBoxSizeMode.Zoom;
            picMT.Dock = DockStyle.Fill;

            System.IO.FileStream AliasFigura;
            try
            {
                AliasFigura = new System.IO.FileStream(@"C:\MaquinaTuringResources\maquinaTuring.png", System.IO.FileMode.Open, System.IO.FileAccess.Read);
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo abrir el archivo", "E R R O R", MessageBoxButtons.OK, MessageBoxIcon.Error);
                frmNuevaVentana.Close();
                return;
            }
            try
            {
                picMT.Image = System.Drawing.Bitmap.FromStream(AliasFigura);
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo cargar la imagen del archivo.", "E R R O R", MessageBoxButtons.OK, MessageBoxIcon.Error);
                AliasFigura.Close();
                frmNuevaVentana.Close();
                return;
            }
            AliasFigura.Close();
            picMT.Refresh();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if(AreaTrabajo.Maquina == null)
            {
                MessageBox.Show("Favor de crear una máquina para poder ejecutarla");
                return;
            }
            else if(AreaTrabajo.Maquina.EstadoInicial == null)
            {
                MessageBox.Show("Favor de crear ingresar transiciones para poder ejecutarla. No posee Estado Inicial");
                return;
            }
            else if (AreaTrabajo.Maquina.EstadoFinal == null)
            {
                MessageBox.Show("Favor de crear ingresar transiciones para poder ejecutarla. No posee Estado Final.");
                return;
            }
            pnlContenido.Enabled = false;
            lblEstadoMaquina.Text = $"Estado: {AreaTrabajo.Maquina.EstadoActual}";
            AreaTrabajo.Maquina.EstadoActual = AreaTrabajo.Maquina.ObtenerEstado("q0");
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            try
            {
                AreaTrabajo.Maquina.EstadoActual = AreaTrabajo.Maquina.SiguientePaso();
                dgvCinta.Columns.Clear();
                for (int i = 0; i < AreaTrabajo.Maquina.Cinta.Length; i++)
                {
                    dgvCinta.Columns.Add($"Celda{i}", $"Celda{i}");
                }
                dgvCinta.Rows.Add();
                for (int i = 0; i < dgvCinta.Columns.Count; i++)
                {
                    dgvCinta.Rows[0].Cells[i].Value = AreaTrabajo.Maquina.Cinta[i];
                }
                if (AreaTrabajo.Maquina.Cabezal > 0)
                    dgvCinta.CurrentCell = dgvCinta.Rows[0].Cells[AreaTrabajo.Maquina.Cabezal];
                else
                    dgvCinta.CurrentCell = dgvCinta.Rows[0].Cells[0];
                lblEstadoMaquina.Text = $"Estado: {AreaTrabajo.Maquina.EstadoActual}";
                if (AreaTrabajo.Maquina.CalculosTerminados)
                    MessageBox.Show("Los Cálculos han terminado", "Cálculos Terminados", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            AreaTrabajo.Maquina.Cabezal = 0;
            AreaTrabajo.Maquina.EstadoActual = AreaTrabajo.Maquina.ObtenerEstado("q0");
            pnlContenido.Enabled = true;
            AreaTrabajo.Maquina.Cinta = AreaTrabajo.CintaOriginal;
            AreaTrabajo.Maquina.Cabezal = AreaTrabajo.CabezalOriginal;
            dgvCinta.Columns.Clear();
            for (int i = 0; i < AreaTrabajo.Maquina.Cinta.Length; i++)
            {
                dgvCinta.Columns.Add($"Celda{i}", $"Celda{i}");
            }
            dgvCinta.Rows.Add();
            for (int i = 0; i < dgvCinta.Columns.Count; i++)
            {
                dgvCinta.Rows[0].Cells[i].Value = AreaTrabajo.Maquina.Cinta[i];
            }
            if (AreaTrabajo.Maquina.Cabezal > 0)
                dgvCinta.CurrentCell = dgvCinta.Rows[0].Cells[AreaTrabajo.Maquina.Cabezal];
            else
                dgvCinta.CurrentCell = dgvCinta.Rows[0].Cells[0];
        }
    }
}
