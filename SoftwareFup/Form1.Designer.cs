namespace SoftwareFup
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
            this.btnClicAqui = new System.Windows.Forms.Button();
            this.picFotoFup = new System.Windows.Forms.PictureBox();
            this.lblNombreFup = new System.Windows.Forms.Label();
            this.lblPresentacion = new System.Windows.Forms.Label();
            this.radEstudianteFup = new System.Windows.Forms.RadioButton();
            this.radEgresadFup = new System.Windows.Forms.RadioButton();
            this.cboProgramasAcademicos = new System.Windows.Forms.ComboBox();
            this.calFup = new System.Windows.Forms.MonthCalendar();
            this.chkSeleccion = new System.Windows.Forms.CheckBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.txtCalificacionSoftware = new System.Windows.Forms.TextBox();
            this.rtbListaFup = new System.Windows.Forms.RichTextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblPresentacionFup = new System.Windows.Forms.Label();
            this.txtLectura = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picFotoFup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClicAqui
            // 
            this.btnClicAqui.Location = new System.Drawing.Point(12, 181);
            this.btnClicAqui.Name = "btnClicAqui";
            this.btnClicAqui.Size = new System.Drawing.Size(75, 23);
            this.btnClicAqui.TabIndex = 0;
            this.btnClicAqui.Text = "ClickAqui";
            this.btnClicAqui.UseVisualStyleBackColor = true;
            this.btnClicAqui.Click += new System.EventHandler(this.button1_Click);
            // 
            // picFotoFup
            // 
            this.picFotoFup.Image = global::SoftwareFup.Properties.Resources.FUP;
            this.picFotoFup.Location = new System.Drawing.Point(12, 12);
            this.picFotoFup.Name = "picFotoFup";
            this.picFotoFup.Size = new System.Drawing.Size(183, 159);
            this.picFotoFup.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFotoFup.TabIndex = 1;
            this.picFotoFup.TabStop = false;
            // 
            // lblNombreFup
            // 
            this.lblNombreFup.AutoSize = true;
            this.lblNombreFup.Location = new System.Drawing.Point(198, 12);
            this.lblNombreFup.Name = "lblNombreFup";
            this.lblNombreFup.Size = new System.Drawing.Size(0, 13);
            this.lblNombreFup.TabIndex = 2;
            // 
            // lblPresentacion
            // 
            this.lblPresentacion.AutoSize = true;
            this.lblPresentacion.Location = new System.Drawing.Point(198, 37);
            this.lblPresentacion.Name = "lblPresentacion";
            this.lblPresentacion.Size = new System.Drawing.Size(0, 13);
            this.lblPresentacion.TabIndex = 3;
            // 
            // radEstudianteFup
            // 
            this.radEstudianteFup.AutoSize = true;
            this.radEstudianteFup.Location = new System.Drawing.Point(201, 154);
            this.radEstudianteFup.Name = "radEstudianteFup";
            this.radEstudianteFup.Size = new System.Drawing.Size(96, 17);
            this.radEstudianteFup.TabIndex = 4;
            this.radEstudianteFup.TabStop = true;
            this.radEstudianteFup.Text = "Soy Estudiante";
            this.radEstudianteFup.UseVisualStyleBackColor = true;
            this.radEstudianteFup.CheckedChanged += new System.EventHandler(this.radEgresadoFup_CheckedChanged);
            // 
            // radEgresadFup
            // 
            this.radEgresadFup.AutoSize = true;
            this.radEgresadFup.Location = new System.Drawing.Point(201, 117);
            this.radEgresadFup.Name = "radEgresadFup";
            this.radEgresadFup.Size = new System.Drawing.Size(91, 17);
            this.radEgresadFup.TabIndex = 5;
            this.radEgresadFup.TabStop = true;
            this.radEgresadFup.Text = "Soy Egresado";
            this.radEgresadFup.UseVisualStyleBackColor = true;
            // 
            // cboProgramasAcademicos
            // 
            this.cboProgramasAcademicos.FormattingEnabled = true;
            this.cboProgramasAcademicos.Items.AddRange(new object[] {
            "Arquitectura",
            "Administracion de Empresas",
            "Admin Empresas Agropecuarias",
            "Contaduria",
            "Derecho",
            "Ecologia",
            "Ingenieria Industrial",
            "Ingenieria de Sistemas",
            "Licenciatura",
            "Trabajo Social",
            "Psicologia"});
            this.cboProgramasAcademicos.Location = new System.Drawing.Point(318, 150);
            this.cboProgramasAcademicos.Name = "cboProgramasAcademicos";
            this.cboProgramasAcademicos.Size = new System.Drawing.Size(139, 21);
            this.cboProgramasAcademicos.TabIndex = 6;
            // 
            // calFup
            // 
            this.calFup.Location = new System.Drawing.Point(618, 12);
            this.calFup.Name = "calFup";
            this.calFup.TabIndex = 7;
            // 
            // chkSeleccion
            // 
            this.chkSeleccion.AutoSize = true;
            this.chkSeleccion.Location = new System.Drawing.Point(201, 187);
            this.chkSeleccion.Name = "chkSeleccion";
            this.chkSeleccion.Size = new System.Drawing.Size(258, 17);
            this.chkSeleccion.TabIndex = 8;
            this.chkSeleccion.Text = "Seleccione si esta de acuerdo con este Software\r\n";
            this.chkSeleccion.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(387, 236);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(37, 20);
            this.numericUpDown1.TabIndex = 9;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // txtCalificacionSoftware
            // 
            this.txtCalificacionSoftware.Location = new System.Drawing.Point(201, 236);
            this.txtCalificacionSoftware.Name = "txtCalificacionSoftware";
            this.txtCalificacionSoftware.Size = new System.Drawing.Size(157, 20);
            this.txtCalificacionSoftware.TabIndex = 10;
            this.txtCalificacionSoftware.Text = "Califique el Software de 1 a 10";
            // 
            // rtbListaFup
            // 
            this.rtbListaFup.Location = new System.Drawing.Point(711, 187);
            this.rtbListaFup.Name = "rtbListaFup";
            this.rtbListaFup.Size = new System.Drawing.Size(100, 96);
            this.rtbListaFup.TabIndex = 11;
            this.rtbListaFup.Text = "Programa\nNotas \nPromedio";
            this.rtbListaFup.TextChanged += new System.EventHandler(this.rtbListaFup_TextChanged);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(198, 12);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(35, 13);
            this.lblNombre.TabIndex = 12;
            this.lblNombre.Text = "label1";
            // 
            // lblPresentacionFup
            // 
            this.lblPresentacionFup.AutoSize = true;
            this.lblPresentacionFup.Location = new System.Drawing.Point(198, 65);
            this.lblPresentacionFup.Name = "lblPresentacionFup";
            this.lblPresentacionFup.Size = new System.Drawing.Size(35, 13);
            this.lblPresentacionFup.TabIndex = 13;
            this.lblPresentacionFup.Text = "label1";
            // 
            // txtLectura
            // 
            this.txtLectura.Enabled = false;
            this.txtLectura.Location = new System.Drawing.Point(516, 235);
            this.txtLectura.Name = "txtLectura";
            this.txtLectura.ReadOnly = true;
            this.txtLectura.Size = new System.Drawing.Size(100, 20);
            this.txtLectura.TabIndex = 14;
            this.txtLectura.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 450);
            this.Controls.Add(this.txtLectura);
            this.Controls.Add(this.lblPresentacionFup);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.rtbListaFup);
            this.Controls.Add(this.txtCalificacionSoftware);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.chkSeleccion);
            this.Controls.Add(this.calFup);
            this.Controls.Add(this.cboProgramasAcademicos);
            this.Controls.Add(this.radEgresadFup);
            this.Controls.Add(this.radEstudianteFup);
            this.Controls.Add(this.lblPresentacion);
            this.Controls.Add(this.lblNombreFup);
            this.Controls.Add(this.picFotoFup);
            this.Controls.Add(this.btnClicAqui);
            this.Name = "Form1";
            this.Text = "FUP";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picFotoFup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClicAqui;
        private System.Windows.Forms.PictureBox picFotoFup;
        private System.Windows.Forms.Label lblNombreFup;
        private System.Windows.Forms.Label lblPresentacion;
        private System.Windows.Forms.RadioButton radEstudianteFup;
        private System.Windows.Forms.RadioButton radEgresadFup;
        private System.Windows.Forms.ComboBox cboProgramasAcademicos;
        private System.Windows.Forms.MonthCalendar calFup;
        private System.Windows.Forms.CheckBox chkSeleccion;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox txtCalificacionSoftware;
        private System.Windows.Forms.RichTextBox rtbListaFup;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblPresentacionFup;
        private System.Windows.Forms.TextBox txtLectura;
    }
}

