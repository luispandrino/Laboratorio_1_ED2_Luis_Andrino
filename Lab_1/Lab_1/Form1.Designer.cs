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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            this.lstTiempo = new System.Windows.Forms.ListBox();
            this.chkduracion = new System.Windows.Forms.CheckBox();
            this.btnduracion = new System.Windows.Forms.Button();
            this.chknombre = new System.Windows.Forms.CheckBox();
            this.btnOrdenar = new System.Windows.Forms.Button();
            this.btnMostrarLista = new System.Windows.Forms.Button();
            this.lstMusica = new System.Windows.Forms.ListBox();
            this.btnAgregarLista = new System.Windows.Forms.Button();
            this.CHLSTcanciones = new System.Windows.Forms.CheckedListBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.WBMusica = new System.Windows.Forms.WebBrowser();
            this.comboBoxCanciones = new System.Windows.Forms.ComboBox();
            this.BtnReproducir = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(665, 463);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label4);
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
            this.tabPage1.Size = new System.Drawing.Size(657, 437);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Agregar musica";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(12, 328);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 25);
            this.lblResultado.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Resultado :";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(329, 75);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(145, 20);
            this.txtBuscar.TabIndex = 6;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(329, 115);
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
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tiempo de la Canción";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre Canción";
            // 
            // txtTiempo
            // 
            this.txtTiempo.Location = new System.Drawing.Point(10, 115);
            this.txtTiempo.Name = "txtTiempo";
            this.txtTiempo.Size = new System.Drawing.Size(144, 20);
            this.txtTiempo.TabIndex = 2;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(10, 41);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(140, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Location = new System.Drawing.Point(10, 161);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(144, 23);
            this.BtnAgregar.TabIndex = 0;
            this.BtnAgregar.Text = "Agregar Cancion";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lstTiempo);
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
            this.tabPage2.Size = new System.Drawing.Size(657, 437);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Crear Play-List";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lstTiempo
            // 
            this.lstTiempo.FormattingEnabled = true;
            this.lstTiempo.Location = new System.Drawing.Point(331, 178);
            this.lstTiempo.Name = "lstTiempo";
            this.lstTiempo.Size = new System.Drawing.Size(183, 238);
            this.lstTiempo.TabIndex = 8;
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
            // btnduracion
            // 
            this.btnduracion.Location = new System.Drawing.Point(145, 138);
            this.btnduracion.Name = "btnduracion";
            this.btnduracion.Size = new System.Drawing.Size(137, 23);
            this.btnduracion.TabIndex = 6;
            this.btnduracion.Text = "Ordenar por duracion";
            this.btnduracion.UseVisualStyleBackColor = true;
            this.btnduracion.Click += new System.EventHandler(this.btnduracion_Click);
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
            this.lstMusica.Location = new System.Drawing.Point(135, 178);
            this.lstMusica.Name = "lstMusica";
            this.lstMusica.Size = new System.Drawing.Size(167, 238);
            this.lstMusica.TabIndex = 2;
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
            this.CHLSTcanciones.Size = new System.Drawing.Size(120, 409);
            this.CHLSTcanciones.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.BtnReproducir);
            this.tabPage3.Controls.Add(this.comboBoxCanciones);
            this.tabPage3.Controls.Add(this.WBMusica);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(657, 437);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Repoductor";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // WBMusica
            // 
            this.WBMusica.Location = new System.Drawing.Point(211, 3);
            this.WBMusica.MinimumSize = new System.Drawing.Size(20, 20);
            this.WBMusica.Name = "WBMusica";
            this.WBMusica.Size = new System.Drawing.Size(443, 428);
            this.WBMusica.TabIndex = 0;
            // 
            // comboBoxCanciones
            // 
            this.comboBoxCanciones.FormattingEnabled = true;
            this.comboBoxCanciones.Location = new System.Drawing.Point(6, 45);
            this.comboBoxCanciones.Name = "comboBoxCanciones";
            this.comboBoxCanciones.Size = new System.Drawing.Size(174, 21);
            this.comboBoxCanciones.TabIndex = 1;
            // 
            // BtnReproducir
            // 
            this.BtnReproducir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReproducir.Location = new System.Drawing.Point(8, 86);
            this.BtnReproducir.Name = "BtnReproducir";
            this.BtnReproducir.Size = new System.Drawing.Size(172, 166);
            this.BtnReproducir.TabIndex = 2;
            this.BtnReproducir.Text = "Reproducir";
            this.BtnReproducir.UseVisualStyleBackColor = true;
            this.BtnReproducir.Click += new System.EventHandler(this.BtnReproducir_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(326, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(220, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "Nombre de la Cancion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(5, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(196, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "Seleccione un acancion de su lista";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 463);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "SpotyMy";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
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
        private System.Windows.Forms.ListBox lstTiempo;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.WebBrowser WBMusica;
        private System.Windows.Forms.Button BtnReproducir;
        private System.Windows.Forms.ComboBox comboBoxCanciones;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

