namespace Lab_1
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblResultado = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTiempo = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnAgregarLista = new System.Windows.Forms.Button();
            this.CHLSTcanciones = new System.Windows.Forms.CheckedListBox();
            this.btnMostrarLista = new System.Windows.Forms.Button();
            this.lstMusica = new System.Windows.Forms.ListBox();
            this.btnOrdenar = new System.Windows.Forms.Button();
            this.chknombre = new System.Windows.Forms.CheckBox();
            this.btnduracion = new System.Windows.Forms.Button();
            this.chkduracion = new System.Windows.Forms.CheckBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(519, 310);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblResultado);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txtBuscar);
            this.tabPage1.Controls.Add(this.btnBuscar);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtTiempo);
            this.tabPage1.Controls.Add(this.txtNombre);
            this.tabPage1.Controls.Add(this.BtnAgregar);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(377, 284);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Agregar musica";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(14, 215);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 13);
            this.lblResultado.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Resultado :";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(201, 74);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(145, 20);
            this.txtBuscar.TabIndex = 6;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(201, 115);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(145, 20);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tiempo de la Canción";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre Canción";
            // 
            // txtTiempo
            // 
            this.txtTiempo.Location = new System.Drawing.Point(10, 75);
            this.txtTiempo.Name = "txtTiempo";
            this.txtTiempo.Size = new System.Drawing.Size(144, 20);
            this.txtTiempo.TabIndex = 2;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(10, 23);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(140, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Location = new System.Drawing.Point(6, 115);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(144, 23);
            this.BtnAgregar.TabIndex = 0;
            this.BtnAgregar.Text = "Agregar Cancion";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.chkduracion);
            this.tabPage2.Controls.Add(this.btnduracion);
            this.tabPage2.Controls.Add(this.chknombre);
            this.tabPage2.Controls.Add(this.btnOrdenar);
            this.tabPage2.Controls.Add(this.btnMostrarLista);
            this.tabPage2.Controls.Add(this.lstMusica);
            this.tabPage2.Controls.Add(this.btnAgregarLista);
            this.tabPage2.Controls.Add(this.CHLSTcanciones);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(511, 284);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Crear Play-List";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnAgregarLista
            // 
            this.btnAgregarLista.Location = new System.Drawing.Point(145, 47);
            this.btnAgregarLista.Name = "btnAgregarLista";
            this.btnAgregarLista.Size = new System.Drawing.Size(147, 23);
            this.btnAgregarLista.TabIndex = 1;
            this.btnAgregarLista.Text = "Agregar a la lista ";
            this.btnAgregarLista.UseVisualStyleBackColor = true;
            this.btnAgregarLista.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // CHLSTcanciones
            // 
            this.CHLSTcanciones.FormattingEnabled = true;
            this.CHLSTcanciones.Location = new System.Drawing.Point(9, 7);
            this.CHLSTcanciones.Name = "CHLSTcanciones";
            this.CHLSTcanciones.Size = new System.Drawing.Size(120, 274);
            this.CHLSTcanciones.TabIndex = 0;
            // 
            // btnMostrarLista
            // 
            this.btnMostrarLista.Location = new System.Drawing.Point(331, 47);
            this.btnMostrarLista.Name = "btnMostrarLista";
            this.btnMostrarLista.Size = new System.Drawing.Size(147, 23);
            this.btnMostrarLista.TabIndex = 3;
            this.btnMostrarLista.Text = "Mostrar Lista";
            this.btnMostrarLista.UseVisualStyleBackColor = true;
            this.btnMostrarLista.Click += new System.EventHandler(this.btnMostrarLista_Click);
            // 
            // lstMusica
            // 
            this.lstMusica.FormattingEnabled = true;
            this.lstMusica.Location = new System.Drawing.Point(135, 183);
            this.lstMusica.Name = "lstMusica";
            this.lstMusica.Size = new System.Drawing.Size(355, 95);
            this.lstMusica.TabIndex = 2;
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.Location = new System.Drawing.Point(145, 101);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(137, 23);
            this.btnOrdenar.TabIndex = 4;
            this.btnOrdenar.Text = "Ordenar por nombre ";
            this.btnOrdenar.UseVisualStyleBackColor = true;
            this.btnOrdenar.Click += new System.EventHandler(this.btnOrdenar_Click);
            // 
            // chknombre
            // 
            this.chknombre.AutoSize = true;
            this.chknombre.Location = new System.Drawing.Point(331, 105);
            this.chknombre.Name = "chknombre";
            this.chknombre.Size = new System.Drawing.Size(159, 17);
            this.chknombre.TabIndex = 5;
            this.chknombre.Text = "ascendiente / descendiente";
            this.chknombre.UseVisualStyleBackColor = true;
            // 
            // btnduracion
            // 
            this.btnduracion.Location = new System.Drawing.Point(145, 138);
            this.btnduracion.Name = "btnduracion";
            this.btnduracion.Size = new System.Drawing.Size(137, 23);
            this.btnduracion.TabIndex = 6;
            this.btnduracion.Text = "Ordenar por duracion";
            this.btnduracion.UseVisualStyleBackColor = true;
            // 
            // chkduracion
            // 
            this.chkduracion.AutoSize = true;
            this.chkduracion.Location = new System.Drawing.Point(331, 144);
            this.chkduracion.Name = "chkduracion";
            this.chkduracion.Size = new System.Drawing.Size(159, 17);
            this.chkduracion.TabIndex = 7;
            this.chkduracion.Text = "ascendiente / descendiente";
            this.chkduracion.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 322);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTiempo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckedListBox CHLSTcanciones;
        private System.Windows.Forms.Button btnAgregarLista;
        private System.Windows.Forms.Button btnMostrarLista;
        private System.Windows.Forms.ListBox lstMusica;
        private System.Windows.Forms.CheckBox chkduracion;
        private System.Windows.Forms.Button btnduracion;
        private System.Windows.Forms.CheckBox chknombre;
        private System.Windows.Forms.Button btnOrdenar;
    }
}

