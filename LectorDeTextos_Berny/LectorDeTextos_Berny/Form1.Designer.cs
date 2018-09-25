namespace LectorDeTextos_Berny {
    partial class FormArchivos {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbQuitar = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnProcesar = new System.Windows.Forms.Button();
            this.btn_GuardarComo = new System.Windows.Forms.Button();
            this.txtRutaArchivo = new System.Windows.Forms.TextBox();
            this.btnExaminar = new System.Windows.Forms.Button();
            this.txtTEXTO = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.ContPalabras = new System.Windows.Forms.Label();
            this.ContCaracteres = new System.Windows.Forms.Label();
            this.ContEspaciosBlancos = new System.Windows.Forms.Label();
            this.ContTabuladores = new System.Windows.Forms.Label();
            this.ContLineas = new System.Windows.Forms.Label();
            this.ContVocales = new System.Windows.Forms.Label();
            this.ContConsonantes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ARCHIVO: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Palabras";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(196, 297);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Caracteres";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(154, 321);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Espacios en blanco";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(188, 346);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tabuladores";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(216, 372);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Lineas";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(209, 396);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Vocales";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(185, 422);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Consonantes";
            // 
            // cmbQuitar
            // 
            this.cmbQuitar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbQuitar.FormattingEnabled = true;
            this.cmbQuitar.Items.AddRange(new object[] {
            "Espacios en Blanco",
            "Vocales",
            "Consonantes"});
            this.cmbQuitar.Location = new System.Drawing.Point(188, 468);
            this.cmbQuitar.Name = "cmbQuitar";
            this.cmbQuitar.Size = new System.Drawing.Size(176, 21);
            this.cmbQuitar.TabIndex = 8;
            this.cmbQuitar.SelectedIndexChanged += new System.EventHandler(this.cmbQuitar_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(0, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 13);
            this.label9.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(141, 471);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Quitar :";
            // 
            // btnProcesar
            // 
            this.btnProcesar.Location = new System.Drawing.Point(386, 462);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(104, 30);
            this.btnProcesar.TabIndex = 11;
            this.btnProcesar.Text = "Procesar";
            this.btnProcesar.UseVisualStyleBackColor = true;
            this.btnProcesar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_GuardarComo
            // 
            this.btn_GuardarComo.Location = new System.Drawing.Point(496, 462);
            this.btn_GuardarComo.Name = "btn_GuardarComo";
            this.btn_GuardarComo.Size = new System.Drawing.Size(103, 30);
            this.btn_GuardarComo.TabIndex = 12;
            this.btn_GuardarComo.Text = "Guardar como...";
            this.btn_GuardarComo.UseVisualStyleBackColor = true;
            this.btn_GuardarComo.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtRutaArchivo
            // 
            this.txtRutaArchivo.Location = new System.Drawing.Point(96, 12);
            this.txtRutaArchivo.Multiline = true;
            this.txtRutaArchivo.Name = "txtRutaArchivo";
            this.txtRutaArchivo.ReadOnly = true;
            this.txtRutaArchivo.Size = new System.Drawing.Size(333, 19);
            this.txtRutaArchivo.TabIndex = 13;
            // 
            // btnExaminar
            // 
            this.btnExaminar.Location = new System.Drawing.Point(435, 7);
            this.btnExaminar.Name = "btnExaminar";
            this.btnExaminar.Size = new System.Drawing.Size(150, 29);
            this.btnExaminar.TabIndex = 14;
            this.btnExaminar.Text = "Examinar";
            this.btnExaminar.UseVisualStyleBackColor = true;
            this.btnExaminar.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // txtTEXTO
            // 
            this.txtTEXTO.Location = new System.Drawing.Point(73, 53);
            this.txtTEXTO.Multiline = true;
            this.txtTEXTO.Name = "txtTEXTO";
            this.txtTEXTO.ReadOnly = true;
            this.txtTEXTO.Size = new System.Drawing.Size(534, 200);
            this.txtTEXTO.TabIndex = 15;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(206, 272);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "Palabras";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(38, 435);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(607, 13);
            this.label12.TabIndex = 17;
            this.label12.Text = "_________________________________________________________________________________" +
    "___________________";
            // 
            // ContPalabras
            // 
            this.ContPalabras.AutoSize = true;
            this.ContPalabras.Location = new System.Drawing.Point(432, 272);
            this.ContPalabras.Name = "ContPalabras";
            this.ContPalabras.Size = new System.Drawing.Size(13, 13);
            this.ContPalabras.TabIndex = 18;
            this.ContPalabras.Text = "--";
            // 
            // ContCaracteres
            // 
            this.ContCaracteres.AutoSize = true;
            this.ContCaracteres.Location = new System.Drawing.Point(432, 297);
            this.ContCaracteres.Name = "ContCaracteres";
            this.ContCaracteres.Size = new System.Drawing.Size(13, 13);
            this.ContCaracteres.TabIndex = 19;
            this.ContCaracteres.Text = "--";
            // 
            // ContEspaciosBlancos
            // 
            this.ContEspaciosBlancos.AutoSize = true;
            this.ContEspaciosBlancos.Location = new System.Drawing.Point(432, 321);
            this.ContEspaciosBlancos.Name = "ContEspaciosBlancos";
            this.ContEspaciosBlancos.Size = new System.Drawing.Size(13, 13);
            this.ContEspaciosBlancos.TabIndex = 20;
            this.ContEspaciosBlancos.Text = "--";
            // 
            // ContTabuladores
            // 
            this.ContTabuladores.AutoSize = true;
            this.ContTabuladores.Location = new System.Drawing.Point(432, 346);
            this.ContTabuladores.Name = "ContTabuladores";
            this.ContTabuladores.Size = new System.Drawing.Size(13, 13);
            this.ContTabuladores.TabIndex = 21;
            this.ContTabuladores.Text = "--";
            // 
            // ContLineas
            // 
            this.ContLineas.AutoSize = true;
            this.ContLineas.Location = new System.Drawing.Point(432, 372);
            this.ContLineas.Name = "ContLineas";
            this.ContLineas.Size = new System.Drawing.Size(13, 13);
            this.ContLineas.TabIndex = 22;
            this.ContLineas.Text = "--";
            // 
            // ContVocales
            // 
            this.ContVocales.AutoSize = true;
            this.ContVocales.Location = new System.Drawing.Point(432, 396);
            this.ContVocales.Name = "ContVocales";
            this.ContVocales.Size = new System.Drawing.Size(13, 13);
            this.ContVocales.TabIndex = 23;
            this.ContVocales.Text = "--";
            // 
            // ContConsonantes
            // 
            this.ContConsonantes.AutoSize = true;
            this.ContConsonantes.Location = new System.Drawing.Point(432, 422);
            this.ContConsonantes.Name = "ContConsonantes";
            this.ContConsonantes.Size = new System.Drawing.Size(13, 13);
            this.ContConsonantes.TabIndex = 24;
            this.ContConsonantes.Text = "--";
            // 
            // FormArchivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(667, 518);
            this.Controls.Add(this.ContConsonantes);
            this.Controls.Add(this.ContVocales);
            this.Controls.Add(this.ContLineas);
            this.Controls.Add(this.ContTabuladores);
            this.Controls.Add(this.ContEspaciosBlancos);
            this.Controls.Add(this.ContCaracteres);
            this.Controls.Add(this.ContPalabras);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtTEXTO);
            this.Controls.Add(this.btnExaminar);
            this.Controls.Add(this.txtRutaArchivo);
            this.Controls.Add(this.btn_GuardarComo);
            this.Controls.Add(this.btnProcesar);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmbQuitar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormArchivos";
            this.Text = "Lector de Archivos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnProcesar;
        private System.Windows.Forms.Button btn_GuardarComo;
        private System.Windows.Forms.TextBox txtRutaArchivo;
        private System.Windows.Forms.Button btnExaminar;
        private System.Windows.Forms.TextBox txtTEXTO;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label ContPalabras;
        private System.Windows.Forms.Label ContCaracteres;
        private System.Windows.Forms.Label ContEspaciosBlancos;
        private System.Windows.Forms.Label ContTabuladores;
        private System.Windows.Forms.Label ContLineas;
        private System.Windows.Forms.Label ContVocales;
        private System.Windows.Forms.Label ContConsonantes;
        private System.Windows.Forms.ComboBox cmbQuitar;
    }
}

