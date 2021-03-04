
namespace MaquinaDeTuring
{
    partial class Nueva
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtCadena = new System.Windows.Forms.TextBox();
            this.btnAgregarEspacio = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPosicionCabezal = new System.Windows.Forms.TextBox();
            this.btnCrearMaquina = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese la cadena de entrada:";
            // 
            // txtCadena
            // 
            this.txtCadena.Location = new System.Drawing.Point(15, 39);
            this.txtCadena.Name = "txtCadena";
            this.txtCadena.Size = new System.Drawing.Size(465, 27);
            this.txtCadena.TabIndex = 1;
            // 
            // btnAgregarEspacio
            // 
            this.btnAgregarEspacio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnAgregarEspacio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarEspacio.FlatAppearance.BorderSize = 0;
            this.btnAgregarEspacio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarEspacio.Location = new System.Drawing.Point(440, 72);
            this.btnAgregarEspacio.Name = "btnAgregarEspacio";
            this.btnAgregarEspacio.Size = new System.Drawing.Size(40, 40);
            this.btnAgregarEspacio.TabIndex = 2;
            this.btnAgregarEspacio.Text = "Δ";
            this.btnAgregarEspacio.UseVisualStyleBackColor = false;
            this.btnAgregarEspacio.Click += new System.EventHandler(this.btnAgregarEspacio_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(251, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ingrese la posición del cabezal:";
            // 
            // txtPosicionCabezal
            // 
            this.txtPosicionCabezal.Location = new System.Drawing.Point(272, 118);
            this.txtPosicionCabezal.MaxLength = 3;
            this.txtPosicionCabezal.Name = "txtPosicionCabezal";
            this.txtPosicionCabezal.Size = new System.Drawing.Size(70, 27);
            this.txtPosicionCabezal.TabIndex = 4;
            this.txtPosicionCabezal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPosicionCabezal_KeyPress);
            // 
            // btnCrearMaquina
            // 
            this.btnCrearMaquina.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnCrearMaquina.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCrearMaquina.FlatAppearance.BorderSize = 0;
            this.btnCrearMaquina.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearMaquina.Location = new System.Drawing.Point(375, 175);
            this.btnCrearMaquina.Name = "btnCrearMaquina";
            this.btnCrearMaquina.Size = new System.Drawing.Size(80, 40);
            this.btnCrearMaquina.TabIndex = 5;
            this.btnCrearMaquina.Text = "Crear";
            this.btnCrearMaquina.UseVisualStyleBackColor = false;
            this.btnCrearMaquina.Click += new System.EventHandler(this.btnCrearMaquina_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(264, 175);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(80, 40);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // Nueva
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(495, 236);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnCrearMaquina);
            this.Controls.Add(this.txtPosicionCabezal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAgregarEspacio);
            this.Controls.Add(this.txtCadena);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Nueva";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nueva";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCadena;
        private System.Windows.Forms.Button btnAgregarEspacio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPosicionCabezal;
        private System.Windows.Forms.Button btnCrearMaquina;
        private System.Windows.Forms.Button btnCancelar;
    }
}