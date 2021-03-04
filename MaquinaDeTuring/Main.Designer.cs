
namespace MaquinaDeTuring
{
    partial class Main
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlBarraSuperior = new System.Windows.Forms.Panel();
            this.lblEstadoMaquina = new System.Windows.Forms.Label();
            this.pnlEjecucion = new System.Windows.Forms.Panel();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnReiniciar = new System.Windows.Forms.Button();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.pnlContenido = new System.Windows.Forms.Panel();
            this.btnRecargarImagen = new System.Windows.Forms.Button();
            this.btnAgregarTransicion = new System.Windows.Forms.Button();
            this.btnEliminarEstado = new System.Windows.Forms.Button();
            this.btnAgregarEstado = new System.Windows.Forms.Button();
            this.btnMarcarEstadoFinal = new System.Windows.Forms.Button();
            this.btnEliminarTransicion = new System.Windows.Forms.Button();
            this.cboDireccion = new System.Windows.Forms.ComboBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.cboEscritura = new System.Windows.Forms.ComboBox();
            this.lblEscribe = new System.Windows.Forms.Label();
            this.cboLectura = new System.Windows.Forms.ComboBox();
            this.lblLeectura = new System.Windows.Forms.Label();
            this.cboDestino = new System.Windows.Forms.ComboBox();
            this.lblDestino = new System.Windows.Forms.Label();
            this.dgvTransiciones = new System.Windows.Forms.DataGridView();
            this.Transicion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvEstados = new System.Windows.Forms.DataGridView();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpbSimbolosCinta = new System.Windows.Forms.GroupBox();
            this.lblSimbolosCinta = new System.Windows.Forms.Label();
            this.gpbAlfabeto = new System.Windows.Forms.GroupBox();
            this.lblAlfabeto = new System.Windows.Forms.Label();
            this.lblCinta = new System.Windows.Forms.Label();
            this.dgvCinta = new System.Windows.Forms.DataGridView();
            this.Celda1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Celda2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Celda3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Celda4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Celda5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Celda6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Celda7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Celda8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Celda9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Celda10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlBarraSuperior.SuspendLayout();
            this.pnlEjecucion.SuspendLayout();
            this.pnlContenido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransiciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstados)).BeginInit();
            this.gpbSimbolosCinta.SuspendLayout();
            this.gpbAlfabeto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCinta)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBarraSuperior
            // 
            this.pnlBarraSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.pnlBarraSuperior.Controls.Add(this.lblEstadoMaquina);
            this.pnlBarraSuperior.Controls.Add(this.pnlEjecucion);
            this.pnlBarraSuperior.Controls.Add(this.btnNuevo);
            this.pnlBarraSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBarraSuperior.Location = new System.Drawing.Point(0, 0);
            this.pnlBarraSuperior.Name = "pnlBarraSuperior";
            this.pnlBarraSuperior.Size = new System.Drawing.Size(833, 50);
            this.pnlBarraSuperior.TabIndex = 0;
            // 
            // lblEstadoMaquina
            // 
            this.lblEstadoMaquina.AutoSize = true;
            this.lblEstadoMaquina.Location = new System.Drawing.Point(718, 15);
            this.lblEstadoMaquina.Name = "lblEstadoMaquina";
            this.lblEstadoMaquina.Size = new System.Drawing.Size(68, 21);
            this.lblEstadoMaquina.TabIndex = 4;
            this.lblEstadoMaquina.Text = "Estado:";
            // 
            // pnlEjecucion
            // 
            this.pnlEjecucion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlEjecucion.Controls.Add(this.btnSiguiente);
            this.pnlEjecucion.Controls.Add(this.btnReiniciar);
            this.pnlEjecucion.Controls.Add(this.btnIniciar);
            this.pnlEjecucion.Location = new System.Drawing.Point(369, 0);
            this.pnlEjecucion.Name = "pnlEjecucion";
            this.pnlEjecucion.Size = new System.Drawing.Size(150, 50);
            this.pnlEjecucion.TabIndex = 3;
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSiguiente.FlatAppearance.BorderSize = 0;
            this.btnSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSiguiente.Image = global::MaquinaDeTuring.Properties.Resources.Siguiente;
            this.btnSiguiente.Location = new System.Drawing.Point(110, 5);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(40, 40);
            this.btnSiguiente.TabIndex = 3;
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReiniciar.FlatAppearance.BorderSize = 0;
            this.btnReiniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReiniciar.Image = global::MaquinaDeTuring.Properties.Resources.Reiniciar;
            this.btnReiniciar.Location = new System.Drawing.Point(55, 5);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(40, 40);
            this.btnReiniciar.TabIndex = 2;
            this.btnReiniciar.UseVisualStyleBackColor = true;
            this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);
            // 
            // btnIniciar
            // 
            this.btnIniciar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIniciar.FlatAppearance.BorderSize = 0;
            this.btnIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciar.Image = global::MaquinaDeTuring.Properties.Resources.Iniciar;
            this.btnIniciar.Location = new System.Drawing.Point(0, 5);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(40, 40);
            this.btnIniciar.TabIndex = 1;
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Image = global::MaquinaDeTuring.Properties.Resources.Nuevo;
            this.btnNuevo.Location = new System.Drawing.Point(10, 5);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(40, 40);
            this.btnNuevo.TabIndex = 0;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // pnlContenido
            // 
            this.pnlContenido.Controls.Add(this.btnRecargarImagen);
            this.pnlContenido.Controls.Add(this.btnAgregarTransicion);
            this.pnlContenido.Controls.Add(this.btnEliminarEstado);
            this.pnlContenido.Controls.Add(this.btnAgregarEstado);
            this.pnlContenido.Controls.Add(this.btnMarcarEstadoFinal);
            this.pnlContenido.Controls.Add(this.btnEliminarTransicion);
            this.pnlContenido.Controls.Add(this.cboDireccion);
            this.pnlContenido.Controls.Add(this.lblDireccion);
            this.pnlContenido.Controls.Add(this.cboEscritura);
            this.pnlContenido.Controls.Add(this.lblEscribe);
            this.pnlContenido.Controls.Add(this.cboLectura);
            this.pnlContenido.Controls.Add(this.lblLeectura);
            this.pnlContenido.Controls.Add(this.cboDestino);
            this.pnlContenido.Controls.Add(this.lblDestino);
            this.pnlContenido.Controls.Add(this.dgvTransiciones);
            this.pnlContenido.Controls.Add(this.dgvEstados);
            this.pnlContenido.Controls.Add(this.gpbSimbolosCinta);
            this.pnlContenido.Controls.Add(this.gpbAlfabeto);
            this.pnlContenido.Controls.Add(this.lblCinta);
            this.pnlContenido.Controls.Add(this.dgvCinta);
            this.pnlContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenido.Enabled = false;
            this.pnlContenido.Location = new System.Drawing.Point(0, 50);
            this.pnlContenido.Name = "pnlContenido";
            this.pnlContenido.Size = new System.Drawing.Size(833, 474);
            this.pnlContenido.TabIndex = 1;
            // 
            // btnRecargarImagen
            // 
            this.btnRecargarImagen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnRecargarImagen.FlatAppearance.BorderSize = 0;
            this.btnRecargarImagen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecargarImagen.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecargarImagen.Image = global::MaquinaDeTuring.Properties.Resources.Imagen;
            this.btnRecargarImagen.Location = new System.Drawing.Point(143, 405);
            this.btnRecargarImagen.Name = "btnRecargarImagen";
            this.btnRecargarImagen.Size = new System.Drawing.Size(40, 40);
            this.btnRecargarImagen.TabIndex = 17;
            this.btnRecargarImagen.Text = "X";
            this.btnRecargarImagen.UseVisualStyleBackColor = false;
            this.btnRecargarImagen.Click += new System.EventHandler(this.btnRecargarImagen_Click);
            // 
            // btnAgregarTransicion
            // 
            this.btnAgregarTransicion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.btnAgregarTransicion.FlatAppearance.BorderSize = 0;
            this.btnAgregarTransicion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarTransicion.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.btnAgregarTransicion.Location = new System.Drawing.Point(495, 298);
            this.btnAgregarTransicion.Name = "btnAgregarTransicion";
            this.btnAgregarTransicion.Size = new System.Drawing.Size(109, 29);
            this.btnAgregarTransicion.TabIndex = 14;
            this.btnAgregarTransicion.Text = "+ Transición";
            this.btnAgregarTransicion.UseVisualStyleBackColor = false;
            this.btnAgregarTransicion.Click += new System.EventHandler(this.btnAgregarTransicion_Click);
            // 
            // btnEliminarEstado
            // 
            this.btnEliminarEstado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnEliminarEstado.FlatAppearance.BorderSize = 0;
            this.btnEliminarEstado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarEstado.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarEstado.Location = new System.Drawing.Point(429, 422);
            this.btnEliminarEstado.Name = "btnEliminarEstado";
            this.btnEliminarEstado.Size = new System.Drawing.Size(35, 35);
            this.btnEliminarEstado.TabIndex = 5;
            this.btnEliminarEstado.Text = "X";
            this.btnEliminarEstado.UseVisualStyleBackColor = false;
            this.btnEliminarEstado.Click += new System.EventHandler(this.btnEliminarEstado_Click);
            // 
            // btnAgregarEstado
            // 
            this.btnAgregarEstado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.btnAgregarEstado.FlatAppearance.BorderSize = 0;
            this.btnAgregarEstado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarEstado.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarEstado.Location = new System.Drawing.Point(365, 373);
            this.btnAgregarEstado.Name = "btnAgregarEstado";
            this.btnAgregarEstado.Size = new System.Drawing.Size(35, 35);
            this.btnAgregarEstado.TabIndex = 3;
            this.btnAgregarEstado.Text = "+";
            this.btnAgregarEstado.UseVisualStyleBackColor = false;
            this.btnAgregarEstado.Click += new System.EventHandler(this.btnAgregarEstado_Click);
            // 
            // btnMarcarEstadoFinal
            // 
            this.btnMarcarEstadoFinal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnMarcarEstadoFinal.FlatAppearance.BorderSize = 0;
            this.btnMarcarEstadoFinal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMarcarEstadoFinal.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMarcarEstadoFinal.Location = new System.Drawing.Point(365, 422);
            this.btnMarcarEstadoFinal.Name = "btnMarcarEstadoFinal";
            this.btnMarcarEstadoFinal.Size = new System.Drawing.Size(35, 35);
            this.btnMarcarEstadoFinal.TabIndex = 4;
            this.btnMarcarEstadoFinal.Text = "F";
            this.btnMarcarEstadoFinal.UseVisualStyleBackColor = false;
            this.btnMarcarEstadoFinal.Click += new System.EventHandler(this.btnMarcarEstadoFinal_Click);
            // 
            // btnEliminarTransicion
            // 
            this.btnEliminarTransicion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnEliminarTransicion.FlatAppearance.BorderSize = 0;
            this.btnEliminarTransicion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarTransicion.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarTransicion.Location = new System.Drawing.Point(769, 373);
            this.btnEliminarTransicion.Name = "btnEliminarTransicion";
            this.btnEliminarTransicion.Size = new System.Drawing.Size(35, 35);
            this.btnEliminarTransicion.TabIndex = 16;
            this.btnEliminarTransicion.Text = "X";
            this.btnEliminarTransicion.UseVisualStyleBackColor = false;
            this.btnEliminarTransicion.Visible = false;
            this.btnEliminarTransicion.Click += new System.EventHandler(this.btnEliminarTransicion_Click);
            // 
            // cboDireccion
            // 
            this.cboDireccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDireccion.FormattingEnabled = true;
            this.cboDireccion.Items.AddRange(new object[] {
            "D",
            "N",
            "I"});
            this.cboDireccion.Location = new System.Drawing.Point(552, 260);
            this.cboDireccion.Name = "cboDireccion";
            this.cboDireccion.Size = new System.Drawing.Size(68, 29);
            this.cboDireccion.TabIndex = 13;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.lblDireccion.Location = new System.Drawing.Point(552, 236);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(84, 20);
            this.lblDireccion.TabIndex = 12;
            this.lblDireccion.Text = "Dirección:";
            // 
            // cboEscritura
            // 
            this.cboEscritura.FormattingEnabled = true;
            this.cboEscritura.Location = new System.Drawing.Point(478, 260);
            this.cboEscritura.Name = "cboEscritura";
            this.cboEscritura.Size = new System.Drawing.Size(68, 29);
            this.cboEscritura.TabIndex = 11;
            // 
            // lblEscribe
            // 
            this.lblEscribe.AutoSize = true;
            this.lblEscribe.Location = new System.Drawing.Point(478, 236);
            this.lblEscribe.Name = "lblEscribe";
            this.lblEscribe.Size = new System.Drawing.Size(68, 21);
            this.lblEscribe.TabIndex = 10;
            this.lblEscribe.Text = "Escribe:";
            // 
            // cboLectura
            // 
            this.cboLectura.FormattingEnabled = true;
            this.cboLectura.Location = new System.Drawing.Point(552, 204);
            this.cboLectura.Name = "cboLectura";
            this.cboLectura.Size = new System.Drawing.Size(68, 29);
            this.cboLectura.TabIndex = 9;
            // 
            // lblLeectura
            // 
            this.lblLeectura.AutoSize = true;
            this.lblLeectura.Location = new System.Drawing.Point(553, 181);
            this.lblLeectura.Name = "lblLeectura";
            this.lblLeectura.Size = new System.Drawing.Size(41, 21);
            this.lblLeectura.TabIndex = 8;
            this.lblLeectura.Text = "Lee:";
            // 
            // cboDestino
            // 
            this.cboDestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDestino.FormattingEnabled = true;
            this.cboDestino.Location = new System.Drawing.Point(478, 204);
            this.cboDestino.Name = "cboDestino";
            this.cboDestino.Size = new System.Drawing.Size(68, 29);
            this.cboDestino.TabIndex = 7;
            // 
            // lblDestino
            // 
            this.lblDestino.AutoSize = true;
            this.lblDestino.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.lblDestino.Location = new System.Drawing.Point(479, 181);
            this.lblDestino.Name = "lblDestino";
            this.lblDestino.Size = new System.Drawing.Size(67, 20);
            this.lblDestino.TabIndex = 6;
            this.lblDestino.Text = "Destino:";
            // 
            // dgvTransiciones
            // 
            this.dgvTransiciones.AllowUserToAddRows = false;
            this.dgvTransiciones.AllowUserToDeleteRows = false;
            this.dgvTransiciones.AllowUserToResizeColumns = false;
            this.dgvTransiciones.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dgvTransiciones.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTransiciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTransiciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTransiciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransiciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Transicion});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTransiciones.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTransiciones.Location = new System.Drawing.Point(652, 127);
            this.dgvTransiciones.Name = "dgvTransiciones";
            this.dgvTransiciones.ReadOnly = true;
            this.dgvTransiciones.RowHeadersVisible = false;
            this.dgvTransiciones.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvTransiciones.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgvTransiciones.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.dgvTransiciones.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvTransiciones.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.dgvTransiciones.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvTransiciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTransiciones.Size = new System.Drawing.Size(152, 240);
            this.dgvTransiciones.TabIndex = 15;
            // 
            // Transicion
            // 
            this.Transicion.HeaderText = "Transición";
            this.Transicion.Name = "Transicion";
            this.Transicion.ReadOnly = true;
            // 
            // dgvEstados
            // 
            this.dgvEstados.AllowUserToAddRows = false;
            this.dgvEstados.AllowUserToDeleteRows = false;
            this.dgvEstados.AllowUserToResizeColumns = false;
            this.dgvEstados.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dgvEstados.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvEstados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEstados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvEstados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Estado});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEstados.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvEstados.Location = new System.Drawing.Point(365, 127);
            this.dgvEstados.Name = "dgvEstados";
            this.dgvEstados.ReadOnly = true;
            this.dgvEstados.RowHeadersVisible = false;
            this.dgvEstados.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvEstados.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgvEstados.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.dgvEstados.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvEstados.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.dgvEstados.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvEstados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEstados.Size = new System.Drawing.Size(99, 240);
            this.dgvEstados.TabIndex = 2;
            this.dgvEstados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEstados_CellClick);
            this.dgvEstados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEstados_CellContentClick);
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            // 
            // gpbSimbolosCinta
            // 
            this.gpbSimbolosCinta.Controls.Add(this.lblSimbolosCinta);
            this.gpbSimbolosCinta.Location = new System.Drawing.Point(15, 250);
            this.gpbSimbolosCinta.Name = "gpbSimbolosCinta";
            this.gpbSimbolosCinta.Size = new System.Drawing.Size(320, 120);
            this.gpbSimbolosCinta.TabIndex = 1;
            this.gpbSimbolosCinta.TabStop = false;
            this.gpbSimbolosCinta.Text = "Símbolos de la cinta";
            // 
            // lblSimbolosCinta
            // 
            this.lblSimbolosCinta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSimbolosCinta.Location = new System.Drawing.Point(3, 23);
            this.lblSimbolosCinta.Name = "lblSimbolosCinta";
            this.lblSimbolosCinta.Size = new System.Drawing.Size(314, 94);
            this.lblSimbolosCinta.TabIndex = 0;
            this.lblSimbolosCinta.Text = "Γ = { }";
            this.lblSimbolosCinta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gpbAlfabeto
            // 
            this.gpbAlfabeto.Controls.Add(this.lblAlfabeto);
            this.gpbAlfabeto.Location = new System.Drawing.Point(15, 114);
            this.gpbAlfabeto.Name = "gpbAlfabeto";
            this.gpbAlfabeto.Size = new System.Drawing.Size(320, 120);
            this.gpbAlfabeto.TabIndex = 0;
            this.gpbAlfabeto.TabStop = false;
            this.gpbAlfabeto.Text = "Alfabeto";
            // 
            // lblAlfabeto
            // 
            this.lblAlfabeto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAlfabeto.Location = new System.Drawing.Point(3, 23);
            this.lblAlfabeto.Name = "lblAlfabeto";
            this.lblAlfabeto.Size = new System.Drawing.Size(314, 94);
            this.lblAlfabeto.TabIndex = 0;
            this.lblAlfabeto.Text = "Σ = { }";
            this.lblAlfabeto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCinta
            // 
            this.lblCinta.AutoSize = true;
            this.lblCinta.Location = new System.Drawing.Point(15, 15);
            this.lblCinta.Name = "lblCinta";
            this.lblCinta.Size = new System.Drawing.Size(58, 21);
            this.lblCinta.TabIndex = 1;
            this.lblCinta.Text = "Cinta:";
            // 
            // dgvCinta
            // 
            this.dgvCinta.AllowUserToDeleteRows = false;
            this.dgvCinta.AllowUserToResizeColumns = false;
            this.dgvCinta.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(135)))), ((int)(((byte)(125)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvCinta.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvCinta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCinta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(135)))), ((int)(((byte)(125)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCinta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvCinta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCinta.ColumnHeadersVisible = false;
            this.dgvCinta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Celda1,
            this.Celda2,
            this.Celda3,
            this.Celda4,
            this.Celda5,
            this.Celda6,
            this.Celda7,
            this.Celda8,
            this.Celda9,
            this.Celda10});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(135)))), ((int)(((byte)(125)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCinta.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvCinta.Location = new System.Drawing.Point(0, 40);
            this.dgvCinta.Name = "dgvCinta";
            this.dgvCinta.ReadOnly = true;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(135)))), ((int)(((byte)(125)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCinta.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvCinta.RowHeadersVisible = false;
            this.dgvCinta.RowHeadersWidth = 50;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(135)))), ((int)(((byte)(125)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvCinta.RowsDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvCinta.RowTemplate.Height = 48;
            this.dgvCinta.RowTemplate.ReadOnly = true;
            this.dgvCinta.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dgvCinta.Size = new System.Drawing.Size(833, 50);
            this.dgvCinta.TabIndex = 0;
            // 
            // Celda1
            // 
            this.Celda1.HeaderText = "Celda1";
            this.Celda1.Name = "Celda1";
            this.Celda1.ReadOnly = true;
            // 
            // Celda2
            // 
            this.Celda2.HeaderText = "Celda2";
            this.Celda2.Name = "Celda2";
            this.Celda2.ReadOnly = true;
            // 
            // Celda3
            // 
            this.Celda3.HeaderText = "Celda3";
            this.Celda3.Name = "Celda3";
            this.Celda3.ReadOnly = true;
            // 
            // Celda4
            // 
            this.Celda4.HeaderText = "Celda4";
            this.Celda4.Name = "Celda4";
            this.Celda4.ReadOnly = true;
            // 
            // Celda5
            // 
            this.Celda5.HeaderText = "Celda5";
            this.Celda5.Name = "Celda5";
            this.Celda5.ReadOnly = true;
            // 
            // Celda6
            // 
            this.Celda6.HeaderText = "Celda6";
            this.Celda6.Name = "Celda6";
            this.Celda6.ReadOnly = true;
            // 
            // Celda7
            // 
            this.Celda7.HeaderText = "Celda7";
            this.Celda7.Name = "Celda7";
            this.Celda7.ReadOnly = true;
            // 
            // Celda8
            // 
            this.Celda8.HeaderText = "Celda8";
            this.Celda8.Name = "Celda8";
            this.Celda8.ReadOnly = true;
            // 
            // Celda9
            // 
            this.Celda9.HeaderText = "Celda9";
            this.Celda9.Name = "Celda9";
            this.Celda9.ReadOnly = true;
            // 
            // Celda10
            // 
            this.Celda10.HeaderText = "Celda10";
            this.Celda10.Name = "Celda10";
            this.Celda10.ReadOnly = true;
            // 
            // Main
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(833, 524);
            this.Controls.Add(this.pnlContenido);
            this.Controls.Add(this.pnlBarraSuperior);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(849, 563);
            this.MinimumSize = new System.Drawing.Size(849, 563);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Máquina de Turing";
            this.Load += new System.EventHandler(this.Main_Load);
            this.pnlBarraSuperior.ResumeLayout(false);
            this.pnlBarraSuperior.PerformLayout();
            this.pnlEjecucion.ResumeLayout(false);
            this.pnlContenido.ResumeLayout(false);
            this.pnlContenido.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransiciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstados)).EndInit();
            this.gpbSimbolosCinta.ResumeLayout(false);
            this.gpbAlfabeto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCinta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBarraSuperior;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnReiniciar;
        private System.Windows.Forms.Panel pnlContenido;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Label lblCinta;
        private System.Windows.Forms.DataGridView dgvCinta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Celda1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Celda2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Celda3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Celda4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Celda5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Celda6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Celda7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Celda8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Celda9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Celda10;
        private System.Windows.Forms.GroupBox gpbAlfabeto;
        private System.Windows.Forms.GroupBox gpbSimbolosCinta;
        private System.Windows.Forms.Label lblSimbolosCinta;
        private System.Windows.Forms.Label lblAlfabeto;
        private System.Windows.Forms.DataGridView dgvEstados;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridView dgvTransiciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn Transicion;
        private System.Windows.Forms.Panel pnlEjecucion;
        private System.Windows.Forms.ComboBox cboEscritura;
        private System.Windows.Forms.Label lblEscribe;
        private System.Windows.Forms.ComboBox cboLectura;
        private System.Windows.Forms.Label lblLeectura;
        private System.Windows.Forms.ComboBox cboDestino;
        private System.Windows.Forms.Label lblDestino;
        private System.Windows.Forms.ComboBox cboDireccion;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Button btnAgregarEstado;
        private System.Windows.Forms.Button btnMarcarEstadoFinal;
        private System.Windows.Forms.Button btnEliminarTransicion;
        private System.Windows.Forms.Button btnEliminarEstado;
        private System.Windows.Forms.Button btnAgregarTransicion;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Button btnRecargarImagen;
        private System.Windows.Forms.Label lblEstadoMaquina;
    }
}

