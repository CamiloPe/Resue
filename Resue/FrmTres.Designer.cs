
namespace Resue
{
    partial class FrmInformacion
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
            this.pnlMenuSuperior = new System.Windows.Forms.Panel();
            this.grpInformacion = new System.Windows.Forms.GroupBox();
            this.lblSexo = new System.Windows.Forms.Label();
            this.rdbHombre = new System.Windows.Forms.RadioButton();
            this.rdbMujer = new System.Windows.Forms.RadioButton();
            this.rdbOtro = new System.Windows.Forms.RadioButton();
            this.lblEdad = new System.Windows.Forms.Label();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.lstHorasDormir = new System.Windows.Forms.ListBox();
            this.lblOcupacion = new System.Windows.Forms.Label();
            this.txtOcupación = new System.Windows.Forms.TextBox();
            this.lblHorasDormir = new System.Windows.Forms.Label();
            this.lblProblemasDormir = new System.Windows.Forms.Label();
            this.rdbSi = new System.Windows.Forms.RadioButton();
            this.rdbNo = new System.Windows.Forms.RadioButton();
            this.rdbAVeces = new System.Windows.Forms.RadioButton();
            this.lblRazonesDormi = new System.Windows.Forms.Label();
            this.chcComerDeNoche = new System.Windows.Forms.CheckBox();
            this.chcInsomnio = new System.Windows.Forms.CheckBox();
            this.chcEstres = new System.Windows.Forms.CheckBox();
            this.chcVerTelevison = new System.Windows.Forms.CheckBox();
            this.chcDispositivosElectronicos = new System.Windows.Forms.CheckBox();
            this.chcOtros = new System.Windows.Forms.CheckBox();
            this.btnContinuar = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblRecomendaciones = new System.Windows.Forms.Label();
            this.btnRegresarAlMenu = new System.Windows.Forms.Button();
            this.pnlRecomendaciones = new System.Windows.Forms.Panel();
            this.grpInformacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenuSuperior
            // 
            this.pnlMenuSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMenuSuperior.Location = new System.Drawing.Point(0, 0);
            this.pnlMenuSuperior.Name = "pnlMenuSuperior";
            this.pnlMenuSuperior.Size = new System.Drawing.Size(800, 25);
            this.pnlMenuSuperior.TabIndex = 0;
            // 
            // grpInformacion
            // 
            this.grpInformacion.Controls.Add(this.btnContinuar);
            this.grpInformacion.Controls.Add(this.chcOtros);
            this.grpInformacion.Controls.Add(this.chcDispositivosElectronicos);
            this.grpInformacion.Controls.Add(this.chcVerTelevison);
            this.grpInformacion.Controls.Add(this.chcEstres);
            this.grpInformacion.Controls.Add(this.chcInsomnio);
            this.grpInformacion.Controls.Add(this.chcComerDeNoche);
            this.grpInformacion.Controls.Add(this.lblRazonesDormi);
            this.grpInformacion.Controls.Add(this.rdbAVeces);
            this.grpInformacion.Controls.Add(this.rdbNo);
            this.grpInformacion.Controls.Add(this.rdbSi);
            this.grpInformacion.Controls.Add(this.lblProblemasDormir);
            this.grpInformacion.Controls.Add(this.lblHorasDormir);
            this.grpInformacion.Controls.Add(this.lstHorasDormir);
            this.grpInformacion.Controls.Add(this.txtOcupación);
            this.grpInformacion.Controls.Add(this.lblOcupacion);
            this.grpInformacion.Controls.Add(this.txtEdad);
            this.grpInformacion.Controls.Add(this.lblEdad);
            this.grpInformacion.Controls.Add(this.rdbOtro);
            this.grpInformacion.Controls.Add(this.rdbMujer);
            this.grpInformacion.Controls.Add(this.rdbHombre);
            this.grpInformacion.Controls.Add(this.lblSexo);
            this.grpInformacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpInformacion.Location = new System.Drawing.Point(0, 31);
            this.grpInformacion.Name = "grpInformacion";
            this.grpInformacion.Size = new System.Drawing.Size(359, 452);
            this.grpInformacion.TabIndex = 0;
            this.grpInformacion.TabStop = false;
            this.grpInformacion.Text = "Información";
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSexo.Location = new System.Drawing.Point(6, 41);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(42, 18);
            this.lblSexo.TabIndex = 0;
            this.lblSexo.Text = "Sexo";
            // 
            // rdbHombre
            // 
            this.rdbHombre.AutoSize = true;
            this.rdbHombre.Location = new System.Drawing.Point(73, 41);
            this.rdbHombre.Name = "rdbHombre";
            this.rdbHombre.Size = new System.Drawing.Size(80, 22);
            this.rdbHombre.TabIndex = 1;
            this.rdbHombre.TabStop = true;
            this.rdbHombre.Text = "Hombre";
            this.rdbHombre.UseVisualStyleBackColor = true;
            // 
            // rdbMujer
            // 
            this.rdbMujer.AutoSize = true;
            this.rdbMujer.Location = new System.Drawing.Point(159, 41);
            this.rdbMujer.Name = "rdbMujer";
            this.rdbMujer.Size = new System.Drawing.Size(63, 22);
            this.rdbMujer.TabIndex = 2;
            this.rdbMujer.TabStop = true;
            this.rdbMujer.Text = "Mujer";
            this.rdbMujer.UseVisualStyleBackColor = true;
            // 
            // rdbOtro
            // 
            this.rdbOtro.AutoSize = true;
            this.rdbOtro.Location = new System.Drawing.Point(228, 41);
            this.rdbOtro.Name = "rdbOtro";
            this.rdbOtro.Size = new System.Drawing.Size(56, 22);
            this.rdbOtro.TabIndex = 3;
            this.rdbOtro.TabStop = true;
            this.rdbOtro.Text = "Otro";
            this.rdbOtro.UseVisualStyleBackColor = true;
            this.rdbOtro.CheckedChanged += new System.EventHandler(this.rdbOtro_CheckedChanged);
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(6, 79);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(42, 18);
            this.lblEdad.TabIndex = 4;
            this.lblEdad.Text = "Edad";
            this.lblEdad.Click += new System.EventHandler(this.lblEdad_Click);
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(73, 76);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(182, 24);
            this.txtEdad.TabIndex = 5;
            // 
            // lstHorasDormir
            // 
            this.lstHorasDormir.FormattingEnabled = true;
            this.lstHorasDormir.ItemHeight = 18;
            this.lstHorasDormir.Items.AddRange(new object[] {
            "Menos de 3 horas",
            "4 Horas",
            "5 Horas",
            "6 Horas",
            "7 Horas",
            "8 Horas",
            "Más de 8 Horas"});
            this.lstHorasDormir.Location = new System.Drawing.Point(199, 161);
            this.lstHorasDormir.Name = "lstHorasDormir";
            this.lstHorasDormir.Size = new System.Drawing.Size(154, 22);
            this.lstHorasDormir.TabIndex = 6;
            // 
            // lblOcupacion
            // 
            this.lblOcupacion.AutoSize = true;
            this.lblOcupacion.Location = new System.Drawing.Point(6, 115);
            this.lblOcupacion.Name = "lblOcupacion";
            this.lblOcupacion.Size = new System.Drawing.Size(80, 18);
            this.lblOcupacion.TabIndex = 6;
            this.lblOcupacion.Text = "Ocupación";
            // 
            // txtOcupación
            // 
            this.txtOcupación.Location = new System.Drawing.Point(92, 112);
            this.txtOcupación.Name = "txtOcupación";
            this.txtOcupación.Size = new System.Drawing.Size(163, 24);
            this.txtOcupación.TabIndex = 7;
            // 
            // lblHorasDormir
            // 
            this.lblHorasDormir.AutoSize = true;
            this.lblHorasDormir.Location = new System.Drawing.Point(12, 161);
            this.lblHorasDormir.Name = "lblHorasDormir";
            this.lblHorasDormir.Size = new System.Drawing.Size(183, 18);
            this.lblHorasDormir.TabIndex = 8;
            this.lblHorasDormir.Text = "¿Cuantas horas duermes?";
            // 
            // lblProblemasDormir
            // 
            this.lblProblemasDormir.AutoSize = true;
            this.lblProblemasDormir.Location = new System.Drawing.Point(12, 198);
            this.lblProblemasDormir.Name = "lblProblemasDormir";
            this.lblProblemasDormir.Size = new System.Drawing.Size(222, 18);
            this.lblProblemasDormir.TabIndex = 9;
            this.lblProblemasDormir.Text = "¿Tienes problemas para dormir?";
            // 
            // rdbSi
            // 
            this.rdbSi.AutoSize = true;
            this.rdbSi.Location = new System.Drawing.Point(12, 232);
            this.rdbSi.Name = "rdbSi";
            this.rdbSi.Size = new System.Drawing.Size(39, 22);
            this.rdbSi.TabIndex = 10;
            this.rdbSi.TabStop = true;
            this.rdbSi.Text = "Si";
            this.rdbSi.UseVisualStyleBackColor = true;
            // 
            // rdbNo
            // 
            this.rdbNo.AutoSize = true;
            this.rdbNo.Location = new System.Drawing.Point(64, 232);
            this.rdbNo.Name = "rdbNo";
            this.rdbNo.Size = new System.Drawing.Size(46, 22);
            this.rdbNo.TabIndex = 11;
            this.rdbNo.TabStop = true;
            this.rdbNo.Text = "No";
            this.rdbNo.UseVisualStyleBackColor = true;
            // 
            // rdbAVeces
            // 
            this.rdbAVeces.AutoSize = true;
            this.rdbAVeces.Location = new System.Drawing.Point(127, 232);
            this.rdbAVeces.Name = "rdbAVeces";
            this.rdbAVeces.Size = new System.Drawing.Size(80, 22);
            this.rdbAVeces.TabIndex = 12;
            this.rdbAVeces.TabStop = true;
            this.rdbAVeces.Text = "A Veces";
            this.rdbAVeces.UseVisualStyleBackColor = true;
            // 
            // lblRazonesDormi
            // 
            this.lblRazonesDormi.AutoSize = true;
            this.lblRazonesDormi.Location = new System.Drawing.Point(12, 266);
            this.lblRazonesDormi.Name = "lblRazonesDormi";
            this.lblRazonesDormi.Size = new System.Drawing.Size(161, 18);
            this.lblRazonesDormi.TabIndex = 1;
            this.lblRazonesDormi.Text = "¿Que problema tienes?";
            // 
            // chcComerDeNoche
            // 
            this.chcComerDeNoche.AutoSize = true;
            this.chcComerDeNoche.Location = new System.Drawing.Point(12, 287);
            this.chcComerDeNoche.Name = "chcComerDeNoche";
            this.chcComerDeNoche.Size = new System.Drawing.Size(153, 22);
            this.chcComerDeNoche.TabIndex = 13;
            this.chcComerDeNoche.Text = "Comer en la noche";
            this.chcComerDeNoche.UseVisualStyleBackColor = true;
            // 
            // chcInsomnio
            // 
            this.chcInsomnio.AutoSize = true;
            this.chcInsomnio.Location = new System.Drawing.Point(12, 306);
            this.chcInsomnio.Name = "chcInsomnio";
            this.chcInsomnio.Size = new System.Drawing.Size(88, 22);
            this.chcInsomnio.TabIndex = 14;
            this.chcInsomnio.Text = "Insomnio";
            this.chcInsomnio.UseVisualStyleBackColor = true;
            this.chcInsomnio.CheckedChanged += new System.EventHandler(this.chcInsomnio_CheckedChanged);
            // 
            // chcEstres
            // 
            this.chcEstres.AutoSize = true;
            this.chcEstres.Location = new System.Drawing.Point(12, 325);
            this.chcEstres.Name = "chcEstres";
            this.chcEstres.Size = new System.Drawing.Size(70, 22);
            this.chcEstres.TabIndex = 15;
            this.chcEstres.Text = "Estrés";
            this.chcEstres.UseVisualStyleBackColor = true;
            // 
            // chcVerTelevison
            // 
            this.chcVerTelevison.AutoSize = true;
            this.chcVerTelevison.Location = new System.Drawing.Point(12, 344);
            this.chcVerTelevison.Name = "chcVerTelevison";
            this.chcVerTelevison.Size = new System.Drawing.Size(245, 22);
            this.chcVerTelevison.TabIndex = 16;
            this.chcVerTelevison.Text = "Ver televisión antes de ir a dormir";
            this.chcVerTelevison.UseVisualStyleBackColor = true;
            // 
            // chcDispositivosElectronicos
            // 
            this.chcDispositivosElectronicos.AutoSize = true;
            this.chcDispositivosElectronicos.Location = new System.Drawing.Point(12, 363);
            this.chcDispositivosElectronicos.Name = "chcDispositivosElectronicos";
            this.chcDispositivosElectronicos.Size = new System.Drawing.Size(292, 22);
            this.chcDispositivosElectronicos.TabIndex = 17;
            this.chcDispositivosElectronicos.Text = "Interactuar con dispositivos electronicos";
            this.chcDispositivosElectronicos.UseVisualStyleBackColor = true;
            // 
            // chcOtros
            // 
            this.chcOtros.AutoSize = true;
            this.chcOtros.Location = new System.Drawing.Point(12, 385);
            this.chcOtros.Name = "chcOtros";
            this.chcOtros.Size = new System.Drawing.Size(65, 22);
            this.chcOtros.TabIndex = 18;
            this.chcOtros.Text = "Otros";
            this.chcOtros.UseVisualStyleBackColor = true;
            // 
            // btnContinuar
            // 
            this.btnContinuar.Location = new System.Drawing.Point(228, 412);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(90, 34);
            this.btnContinuar.TabIndex = 19;
            this.btnContinuar.Text = "Continuar";
            this.btnContinuar.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(588, 31);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 20;
            // 
            // lblRecomendaciones
            // 
            this.lblRecomendaciones.AutoSize = true;
            this.lblRecomendaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecomendaciones.Location = new System.Drawing.Point(382, 81);
            this.lblRecomendaciones.Name = "lblRecomendaciones";
            this.lblRecomendaciones.Size = new System.Drawing.Size(285, 20);
            this.lblRecomendaciones.TabIndex = 21;
            this.lblRecomendaciones.Text = "Nuestras recomendaciones para ti son:";
            // 
            // btnRegresarAlMenu
            // 
            this.btnRegresarAlMenu.Location = new System.Drawing.Point(642, 453);
            this.btnRegresarAlMenu.Name = "btnRegresarAlMenu";
            this.btnRegresarAlMenu.Size = new System.Drawing.Size(127, 30);
            this.btnRegresarAlMenu.TabIndex = 22;
            this.btnRegresarAlMenu.Text = "Regresar Al Menú";
            this.btnRegresarAlMenu.UseVisualStyleBackColor = true;
            // 
            // pnlRecomendaciones
            // 
            this.pnlRecomendaciones.Location = new System.Drawing.Point(386, 114);
            this.pnlRecomendaciones.Name = "pnlRecomendaciones";
            this.pnlRecomendaciones.Size = new System.Drawing.Size(383, 333);
            this.pnlRecomendaciones.TabIndex = 23;
            // 
            // FrmInformacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 495);
            this.Controls.Add(this.pnlRecomendaciones);
            this.Controls.Add(this.btnRegresarAlMenu);
            this.Controls.Add(this.lblRecomendaciones);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.grpInformacion);
            this.Controls.Add(this.pnlMenuSuperior);
            this.Name = "FrmInformacion";
            this.Text = "FrmInformacion";
            this.grpInformacion.ResumeLayout(false);
            this.grpInformacion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenuSuperior;
        private System.Windows.Forms.GroupBox grpInformacion;
        private System.Windows.Forms.RadioButton rdbOtro;
        private System.Windows.Forms.RadioButton rdbMujer;
        private System.Windows.Forms.RadioButton rdbHombre;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.TextBox txtOcupación;
        private System.Windows.Forms.Label lblOcupacion;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.ListBox lstHorasDormir;
        private System.Windows.Forms.CheckBox chcVerTelevison;
        private System.Windows.Forms.CheckBox chcEstres;
        private System.Windows.Forms.CheckBox chcInsomnio;
        private System.Windows.Forms.CheckBox chcComerDeNoche;
        private System.Windows.Forms.Label lblRazonesDormi;
        private System.Windows.Forms.RadioButton rdbAVeces;
        private System.Windows.Forms.RadioButton rdbNo;
        private System.Windows.Forms.RadioButton rdbSi;
        private System.Windows.Forms.Label lblProblemasDormir;
        private System.Windows.Forms.Label lblHorasDormir;
        private System.Windows.Forms.Button btnContinuar;
        private System.Windows.Forms.CheckBox chcOtros;
        private System.Windows.Forms.CheckBox chcDispositivosElectronicos;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblRecomendaciones;
        private System.Windows.Forms.Button btnRegresarAlMenu;
        private System.Windows.Forms.Panel pnlRecomendaciones;
    }
}