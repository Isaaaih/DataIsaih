
namespace data.formas
{
    partial class DatosForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbEscolaridad = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.chkMujer = new System.Windows.Forms.CheckBox();
            this.checkBoxOtro = new System.Windows.Forms.CheckBox();
            this.chkHombre = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.PowderBlue;
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.cmbEstado);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cmbEscolaridad);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.chkMujer);
            this.groupBox1.Controls.Add(this.checkBoxOtro);
            this.groupBox1.Controls.Add(this.chkHombre);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtEdad);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtNombres);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtApellidos);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 452);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos ";
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::data.Properties.Resources.Download_Open_Door_Door_Opening_Door_Royalty_Free_Stock_Illustration_Image;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(330, 352);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 72);
            this.button1.TabIndex = 14;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbEstado
            // 
            this.cmbEstado.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Items.AddRange(new object[] {
            "Aguascalientes <<",
            "Baja California <<",
            "Baja California Sur <<",
            "Campeche <<",
            "Chiapas <<",
            "Chihuahua <<",
            "Ciudad de México <<",
            "Coahuila <<",
            "Colima <<",
            "Durango <<",
            "Estado de México <<",
            "Guanajuato <<",
            "Guerrero <<",
            "Hidalgo <<",
            "Jalisco <<",
            "Michoacán <<",
            "Morelos <<",
            "Nayarit <<",
            "Nuevo León <<",
            "Oaxaca <<",
            "Puebla <<",
            "Querétaro <<",
            "Quintana Roo <<",
            "San Luis Potosí <<",
            "Sinaloa <<",
            "Sonora <<",
            "Tabasco <<",
            "Tamaulipas <<",
            "Tlaxcala <<",
            "Veracruz <<",
            "Yucatán <<",
            "Zacatecas <<"});
            this.cmbEstado.Location = new System.Drawing.Point(33, 322);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(212, 31);
            this.cmbEstado.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(29, 279);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 21);
            this.label6.TabIndex = 12;
            this.label6.Text = "Estado";
            // 
            // cmbEscolaridad
            // 
            this.cmbEscolaridad.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEscolaridad.FormattingEnabled = true;
            this.cmbEscolaridad.Items.AddRange(new object[] {
            "Kinder",
            "Primaria ",
            "Secundaria",
            "Preparatoria",
            "Universidad"});
            this.cmbEscolaridad.Location = new System.Drawing.Point(209, 211);
            this.cmbEscolaridad.Name = "cmbEscolaridad";
            this.cmbEscolaridad.Size = new System.Drawing.Size(173, 31);
            this.cmbEscolaridad.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(205, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 21);
            this.label5.TabIndex = 10;
            this.label5.Text = "Escolaridad";
            // 
            // chkMujer
            // 
            this.chkMujer.AutoSize = true;
            this.chkMujer.Location = new System.Drawing.Point(388, 143);
            this.chkMujer.Name = "chkMujer";
            this.chkMujer.Size = new System.Drawing.Size(131, 41);
            this.chkMujer.TabIndex = 9;
            this.chkMujer.Text = "Mujer";
            this.chkMujer.UseVisualStyleBackColor = true;
            // 
            // checkBoxOtro
            // 
            this.checkBoxOtro.AutoSize = true;
            this.checkBoxOtro.Location = new System.Drawing.Point(388, 190);
            this.checkBoxOtro.Name = "checkBoxOtro";
            this.checkBoxOtro.Size = new System.Drawing.Size(112, 41);
            this.checkBoxOtro.TabIndex = 8;
            this.checkBoxOtro.Text = "Otro";
            this.checkBoxOtro.UseVisualStyleBackColor = true;
            this.checkBoxOtro.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // chkHombre
            // 
            this.chkHombre.AutoSize = true;
            this.chkHombre.Location = new System.Drawing.Point(388, 96);
            this.chkHombre.Name = "chkHombre";
            this.chkHombre.Size = new System.Drawing.Size(167, 41);
            this.chkHombre.TabIndex = 7;
            this.chkHombre.Text = "Hombre";
            this.chkHombre.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(396, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Genero";
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(33, 202);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(122, 45);
            this.txtEdad.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Edad";
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(209, 92);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(122, 45);
            this.txtNombres.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(205, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombres";
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(33, 92);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(122, 45);
            this.txtApellidos.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Apellidos";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // DatosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "DatosForm";
            this.Text = "Datos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.CheckBox chkMujer;
        private System.Windows.Forms.CheckBox checkBoxOtro;
        private System.Windows.Forms.CheckBox chkHombre;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbEscolaridad;
        private System.Windows.Forms.Label label5;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}