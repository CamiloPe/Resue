
namespace Resue
{
    partial class FrmLoggIn
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
            this.grpDatosPersonales = new System.Windows.Forms.GroupBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblApellidoMaterno = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblApellidoPaterno = new System.Windows.Forms.Label();
            this.pctFoto = new System.Windows.Forms.PictureBox();
            this.grpFoto = new System.Windows.Forms.GroupBox();
            this.grpGenero = new System.Windows.Forms.GroupBox();
            this.rdbMasculino = new System.Windows.Forms.RadioButton();
            this.rdbFemenino = new System.Windows.Forms.RadioButton();
            this.rdbPersonalizado = new System.Windows.Forms.RadioButton();
            this.grpDatosDeRegistro = new System.Windows.Forms.GroupBox();
            this.txtEMail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtContrasena = new System.Windows.Forms.TextBox();
            this.lblContrasena = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lblConfirmarContrasena = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.cmbEdad = new System.Windows.Forms.ComboBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.grpDatosPersonales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctFoto)).BeginInit();
            this.grpFoto.SuspendLayout();
            this.grpGenero.SuspendLayout();
            this.grpDatosDeRegistro.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDatosPersonales
            // 
            this.grpDatosPersonales.Controls.Add(this.textBox2);
            this.grpDatosPersonales.Controls.Add(this.lblApellidoPaterno);
            this.grpDatosPersonales.Controls.Add(this.textBox1);
            this.grpDatosPersonales.Controls.Add(this.lblApellidoMaterno);
            this.grpDatosPersonales.Controls.Add(this.txtNombre);
            this.grpDatosPersonales.Controls.Add(this.lblNombre);
            this.grpDatosPersonales.Location = new System.Drawing.Point(12, 12);
            this.grpDatosPersonales.Name = "grpDatosPersonales";
            this.grpDatosPersonales.Size = new System.Drawing.Size(322, 109);
            this.grpDatosPersonales.TabIndex = 0;
            this.grpDatosPersonales.TabStop = false;
            this.grpDatosPersonales.Text = "Datos personales";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(6, 26);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(62, 17);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(130, 21);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(186, 22);
            this.txtNombre.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(130, 49);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(186, 22);
            this.textBox1.TabIndex = 3;
            // 
            // lblApellidoMaterno
            // 
            this.lblApellidoMaterno.AutoSize = true;
            this.lblApellidoMaterno.Location = new System.Drawing.Point(6, 54);
            this.lblApellidoMaterno.Name = "lblApellidoMaterno";
            this.lblApellidoMaterno.Size = new System.Drawing.Size(118, 17);
            this.lblApellidoMaterno.TabIndex = 2;
            this.lblApellidoMaterno.Text = "Apellido Materno:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(130, 77);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(186, 22);
            this.textBox2.TabIndex = 5;
            // 
            // lblApellidoPaterno
            // 
            this.lblApellidoPaterno.AutoSize = true;
            this.lblApellidoPaterno.Location = new System.Drawing.Point(6, 82);
            this.lblApellidoPaterno.Name = "lblApellidoPaterno";
            this.lblApellidoPaterno.Size = new System.Drawing.Size(116, 17);
            this.lblApellidoPaterno.TabIndex = 4;
            this.lblApellidoPaterno.Text = "Apellido Paterno:";
            // 
            // pctFoto
            // 
            this.pctFoto.Location = new System.Drawing.Point(64, 21);
            this.pctFoto.Name = "pctFoto";
            this.pctFoto.Size = new System.Drawing.Size(51, 63);
            this.pctFoto.TabIndex = 1;
            this.pctFoto.TabStop = false;
            // 
            // grpFoto
            // 
            this.grpFoto.Controls.Add(this.pctFoto);
            this.grpFoto.Location = new System.Drawing.Point(143, 127);
            this.grpFoto.Name = "grpFoto";
            this.grpFoto.Size = new System.Drawing.Size(191, 102);
            this.grpFoto.TabIndex = 2;
            this.grpFoto.TabStop = false;
            this.grpFoto.Text = "Foto";
            this.grpFoto.Enter += new System.EventHandler(this.grpFoto_Enter);
            // 
            // grpGenero
            // 
            this.grpGenero.Controls.Add(this.rdbPersonalizado);
            this.grpGenero.Controls.Add(this.rdbFemenino);
            this.grpGenero.Controls.Add(this.rdbMasculino);
            this.grpGenero.Location = new System.Drawing.Point(12, 127);
            this.grpGenero.Name = "grpGenero";
            this.grpGenero.Size = new System.Drawing.Size(124, 102);
            this.grpGenero.TabIndex = 2;
            this.grpGenero.TabStop = false;
            this.grpGenero.Text = "Genero";
            // 
            // rdbMasculino
            // 
            this.rdbMasculino.AutoSize = true;
            this.rdbMasculino.Location = new System.Drawing.Point(6, 21);
            this.rdbMasculino.Name = "rdbMasculino";
            this.rdbMasculino.Size = new System.Drawing.Size(92, 21);
            this.rdbMasculino.TabIndex = 0;
            this.rdbMasculino.TabStop = true;
            this.rdbMasculino.Text = "Masculino";
            this.rdbMasculino.UseVisualStyleBackColor = true;
            // 
            // rdbFemenino
            // 
            this.rdbFemenino.AutoSize = true;
            this.rdbFemenino.Location = new System.Drawing.Point(6, 48);
            this.rdbFemenino.Name = "rdbFemenino";
            this.rdbFemenino.Size = new System.Drawing.Size(91, 21);
            this.rdbFemenino.TabIndex = 1;
            this.rdbFemenino.TabStop = true;
            this.rdbFemenino.Text = "Femenino";
            this.rdbFemenino.UseVisualStyleBackColor = true;
            // 
            // rdbPersonalizado
            // 
            this.rdbPersonalizado.AutoSize = true;
            this.rdbPersonalizado.Location = new System.Drawing.Point(6, 75);
            this.rdbPersonalizado.Name = "rdbPersonalizado";
            this.rdbPersonalizado.Size = new System.Drawing.Size(119, 21);
            this.rdbPersonalizado.TabIndex = 2;
            this.rdbPersonalizado.TabStop = true;
            this.rdbPersonalizado.Text = "Personalizado";
            this.rdbPersonalizado.UseVisualStyleBackColor = true;
            this.rdbPersonalizado.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // grpDatosDeRegistro
            // 
            this.grpDatosDeRegistro.Controls.Add(this.cmbEdad);
            this.grpDatosDeRegistro.Controls.Add(this.lblEdad);
            this.grpDatosDeRegistro.Controls.Add(this.textBox3);
            this.grpDatosDeRegistro.Controls.Add(this.lblConfirmarContrasena);
            this.grpDatosDeRegistro.Controls.Add(this.txtContrasena);
            this.grpDatosDeRegistro.Controls.Add(this.lblContrasena);
            this.grpDatosDeRegistro.Controls.Add(this.txtUsuario);
            this.grpDatosDeRegistro.Controls.Add(this.lblUsuario);
            this.grpDatosDeRegistro.Controls.Add(this.txtEMail);
            this.grpDatosDeRegistro.Controls.Add(this.lblEmail);
            this.grpDatosDeRegistro.Location = new System.Drawing.Point(340, 12);
            this.grpDatosDeRegistro.Name = "grpDatosDeRegistro";
            this.grpDatosDeRegistro.Size = new System.Drawing.Size(391, 174);
            this.grpDatosDeRegistro.TabIndex = 3;
            this.grpDatosDeRegistro.TabStop = false;
            this.grpDatosDeRegistro.Text = "Datos De Registro";
            this.grpDatosDeRegistro.Enter += new System.EventHandler(this.grpDatosDeRegistro_Enter);
            // 
            // txtEMail
            // 
            this.txtEMail.Location = new System.Drawing.Point(199, 24);
            this.txtEMail.Name = "txtEMail";
            this.txtEMail.Size = new System.Drawing.Size(186, 22);
            this.txtEMail.TabIndex = 3;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(6, 27);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(59, 21);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "E-Mail";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(199, 52);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(186, 22);
            this.txtUsuario.TabIndex = 5;
            this.txtUsuario.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(6, 55);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(131, 21);
            this.lblUsuario.TabIndex = 4;
            this.lblUsuario.Text = "Elija un usuario";
            this.lblUsuario.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtContrasena
            // 
            this.txtContrasena.Location = new System.Drawing.Point(199, 80);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.Size = new System.Drawing.Size(186, 22);
            this.txtContrasena.TabIndex = 7;
            // 
            // lblContrasena
            // 
            this.lblContrasena.AutoSize = true;
            this.lblContrasena.Location = new System.Drawing.Point(6, 83);
            this.lblContrasena.Name = "lblContrasena";
            this.lblContrasena.Size = new System.Drawing.Size(99, 21);
            this.lblContrasena.TabIndex = 6;
            this.lblContrasena.Text = "contraseña";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(199, 108);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(186, 22);
            this.textBox3.TabIndex = 9;
            // 
            // lblConfirmarContrasena
            // 
            this.lblConfirmarContrasena.AutoSize = true;
            this.lblConfirmarContrasena.Location = new System.Drawing.Point(6, 113);
            this.lblConfirmarContrasena.Name = "lblConfirmarContrasena";
            this.lblConfirmarContrasena.Size = new System.Drawing.Size(146, 17);
            this.lblConfirmarContrasena.TabIndex = 8;
            this.lblConfirmarContrasena.Text = "Confirmar Contraseña";
            this.lblConfirmarContrasena.Click += new System.EventHandler(this.lblConfirmarContrasena_Click);
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(6, 143);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(41, 17);
            this.lblEdad.TabIndex = 10;
            this.lblEdad.Text = "Edad";
            // 
            // cmbEdad
            // 
            this.cmbEdad.FormattingEnabled = true;
            this.cmbEdad.Items.AddRange(new object[] {
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51"});
            this.cmbEdad.Location = new System.Drawing.Point(199, 136);
            this.cmbEdad.Name = "cmbEdad";
            this.cmbEdad.Size = new System.Drawing.Size(186, 24);
            this.cmbEdad.TabIndex = 11;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(340, 192);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(191, 35);
            this.btnAceptar.TabIndex = 12;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // btnMenu
            // 
            this.btnMenu.Location = new System.Drawing.Point(534, 192);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(191, 35);
            this.btnMenu.TabIndex = 13;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            // 
            // FrmLoggIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 258);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.grpDatosDeRegistro);
            this.Controls.Add(this.grpGenero);
            this.Controls.Add(this.grpFoto);
            this.Controls.Add(this.grpDatosPersonales);
            this.Name = "FrmLoggIn";
            this.Text = "Logg-In";
            this.grpDatosPersonales.ResumeLayout(false);
            this.grpDatosPersonales.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctFoto)).EndInit();
            this.grpFoto.ResumeLayout(false);
            this.grpGenero.ResumeLayout(false);
            this.grpGenero.PerformLayout();
            this.grpDatosDeRegistro.ResumeLayout(false);
            this.grpDatosDeRegistro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDatosPersonales;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblApellidoPaterno;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblApellidoMaterno;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.PictureBox pctFoto;
        private System.Windows.Forms.GroupBox grpFoto;
        private System.Windows.Forms.GroupBox grpGenero;
        private System.Windows.Forms.RadioButton rdbPersonalizado;
        private System.Windows.Forms.RadioButton rdbFemenino;
        private System.Windows.Forms.RadioButton rdbMasculino;
        private System.Windows.Forms.GroupBox grpDatosDeRegistro;
        private System.Windows.Forms.TextBox txtEMail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtContrasena;
        private System.Windows.Forms.Label lblContrasena;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lblConfirmarContrasena;
        private System.Windows.Forms.ComboBox cmbEdad;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnMenu;
    }
}