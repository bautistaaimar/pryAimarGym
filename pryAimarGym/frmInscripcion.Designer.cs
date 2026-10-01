namespace pryAimarGym
{
    partial class frmInscripcion
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtNombre = new TextBox();
            lblNombre = new Label();
            lblEdad = new Label();
            grpDatosPersonales = new GroupBox();
            txtEdad = new TextBox();
            grpPlan = new GroupBox();
            chkEstudiante = new CheckBox();
            cboPlan = new ComboBox();
            lblPlan = new Label();
            lblTurno = new Label();
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            lblMes = new Label();
            chkCasillero = new CheckBox();
            grpFormasDePago = new GroupBox();
            rbtEfectivo = new RadioButton();
            rbtTarjeta = new RadioButton();
            comboBox2 = new ComboBox();
            lblCuotas = new Label();
            btnCalcular = new Button();
            btnLimpiar = new Button();
            grpDatosPersonales.SuspendLayout();
            grpPlan.SuspendLayout();
            grpFormasDePago.SuspendLayout();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(115, 30);
            txtNombre.MaxLength = 30;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(129, 23);
            txtNombre.TabIndex = 3;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(24, 30);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(54, 15);
            lblNombre.TabIndex = 4;
            lblNombre.Text = "Nombre:";
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.Location = new Point(34, 72);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(36, 15);
            lblEdad.TabIndex = 5;
            lblEdad.Text = "Edad:";
            // 
            // grpDatosPersonales
            // 
            grpDatosPersonales.Controls.Add(txtEdad);
            grpDatosPersonales.Controls.Add(lblEdad);
            grpDatosPersonales.Controls.Add(lblNombre);
            grpDatosPersonales.Controls.Add(txtNombre);
            grpDatosPersonales.Location = new Point(36, 22);
            grpDatosPersonales.Name = "grpDatosPersonales";
            grpDatosPersonales.Size = new Size(267, 100);
            grpDatosPersonales.TabIndex = 6;
            grpDatosPersonales.TabStop = false;
            grpDatosPersonales.Text = "DATOS PERSONALES";
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(115, 64);
            txtEdad.MaxLength = 3;
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(100, 23);
            txtEdad.TabIndex = 6;
            // 
            // grpPlan
            // 
            grpPlan.Controls.Add(chkCasillero);
            grpPlan.Controls.Add(lblMes);
            grpPlan.Controls.Add(textBox1);
            grpPlan.Controls.Add(comboBox1);
            grpPlan.Controls.Add(lblTurno);
            grpPlan.Controls.Add(lblPlan);
            grpPlan.Controls.Add(cboPlan);
            grpPlan.Controls.Add(chkEstudiante);
            grpPlan.Location = new Point(36, 128);
            grpPlan.Name = "grpPlan";
            grpPlan.Size = new Size(317, 191);
            grpPlan.TabIndex = 7;
            grpPlan.TabStop = false;
            grpPlan.Text = "PLAN";
            grpPlan.Enter += this.grpPlan_Enter;
            // 
            // chkEstudiante
            // 
            chkEstudiante.AutoSize = true;
            chkEstudiante.Location = new Point(35, 155);
            chkEstudiante.Name = "chkEstudiante";
            chkEstudiante.Size = new Size(81, 19);
            chkEstudiante.TabIndex = 0;
            chkEstudiante.Text = "Estudiante";
            chkEstudiante.UseVisualStyleBackColor = true;
            // 
            // cboPlan
            // 
            cboPlan.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPlan.FormattingEnabled = true;
            cboPlan.Items.AddRange(new object[] { "Musculacion", "Funcional", "Natacion" });
            cboPlan.Location = new Point(95, 35);
            cboPlan.Name = "cboPlan";
            cboPlan.Size = new Size(121, 23);
            cboPlan.TabIndex = 1;
            // 
            // lblPlan
            // 
            lblPlan.AutoSize = true;
            lblPlan.Location = new Point(35, 39);
            lblPlan.Name = "lblPlan";
            lblPlan.Size = new Size(30, 15);
            lblPlan.TabIndex = 2;
            lblPlan.Text = "Plan";
            lblPlan.Click += this.lblPlan_Click;
            // 
            // lblTurno
            // 
            lblTurno.AutoSize = true;
            lblTurno.Location = new Point(35, 75);
            lblTurno.Name = "lblTurno";
            lblTurno.Size = new Size(39, 15);
            lblTurno.TabIndex = 3;
            lblTurno.Text = "Turno";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Mañana ", "Tarde", "Noche" });
            comboBox1.Location = new Point(95, 72);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(95, 108);
            textBox1.MaxLength = 2;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(50, 23);
            textBox1.TabIndex = 5;
            textBox1.TextChanged += this.textBox1_TextChanged;
            // 
            // lblMes
            // 
            lblMes.AutoSize = true;
            lblMes.Location = new Point(38, 111);
            lblMes.Name = "lblMes";
            lblMes.Size = new Size(29, 15);
            lblMes.TabIndex = 6;
            lblMes.Text = "Mes";
            // 
            // chkCasillero
            // 
            chkCasillero.AutoSize = true;
            chkCasillero.Location = new Point(149, 156);
            chkCasillero.Name = "chkCasillero";
            chkCasillero.Size = new Size(145, 19);
            chkCasillero.TabIndex = 7;
            chkCasillero.Text = "Casillero ($ 3.000/mes)";
            chkCasillero.UseVisualStyleBackColor = true;
            // 
            // grpFormasDePago
            // 
            grpFormasDePago.Controls.Add(lblCuotas);
            grpFormasDePago.Controls.Add(comboBox2);
            grpFormasDePago.Controls.Add(rbtTarjeta);
            grpFormasDePago.Controls.Add(rbtEfectivo);
            grpFormasDePago.Location = new Point(36, 335);
            grpFormasDePago.Name = "grpFormasDePago";
            grpFormasDePago.Size = new Size(310, 100);
            grpFormasDePago.TabIndex = 8;
            grpFormasDePago.TabStop = false;
            grpFormasDePago.Text = "FORMAS DE PAGO";
            // 
            // rbtEfectivo
            // 
            rbtEfectivo.AutoSize = true;
            rbtEfectivo.Location = new Point(17, 29);
            rbtEfectivo.Name = "rbtEfectivo";
            rbtEfectivo.Size = new Size(77, 19);
            rbtEfectivo.TabIndex = 0;
            rbtEfectivo.TabStop = true;
            rbtEfectivo.Text = "EFECTIVO";
            rbtEfectivo.UseVisualStyleBackColor = true;
            // 
            // rbtTarjeta
            // 
            rbtTarjeta.AutoSize = true;
            rbtTarjeta.Location = new Point(16, 61);
            rbtTarjeta.Name = "rbtTarjeta";
            rbtTarjeta.Size = new Size(70, 19);
            rbtTarjeta.TabIndex = 1;
            rbtTarjeta.TabStop = true;
            rbtTarjeta.Text = "TARJETA";
            rbtTarjeta.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "1", "3", "6" });
            comboBox2.Location = new Point(204, 28);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(48, 23);
            comboBox2.TabIndex = 2;
            // 
            // lblCuotas
            // 
            lblCuotas.AutoSize = true;
            lblCuotas.Location = new Point(137, 31);
            lblCuotas.Name = "lblCuotas";
            lblCuotas.Size = new Size(51, 15);
            lblCuotas.TabIndex = 3;
            lblCuotas.Text = "CUOTAS";
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(90, 441);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(89, 32);
            btnCalcular.TabIndex = 9;
            btnCalcular.Text = "CALCULAR";
            btnCalcular.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(185, 441);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(82, 32);
            btnLimpiar.TabIndex = 10;
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // frmInscripcion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(445, 553);
            Controls.Add(btnLimpiar);
            Controls.Add(btnCalcular);
            Controls.Add(grpFormasDePago);
            Controls.Add(grpPlan);
            Controls.Add(grpDatosPersonales);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MinimizeBox = false;
            Name = "frmInscripcion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gimnasio Siglo — Inscripción";
            grpDatosPersonales.ResumeLayout(false);
            grpDatosPersonales.PerformLayout();
            grpPlan.ResumeLayout(false);
            grpPlan.PerformLayout();
            grpFormasDePago.ResumeLayout(false);
            grpFormasDePago.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TextBox txtNombre;
        private Label lblNombre;
        private Label lblEdad;
        private GroupBox grpDatosPersonales;
        private TextBox txtEdad;
        private GroupBox grpPlan;
        private Label lblPlan;
        private ComboBox cboPlan;
        private CheckBox chkEstudiante;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private Label lblTurno;
        private Label lblMes;
        private CheckBox chkCasillero;
        private GroupBox grpFormasDePago;
        private Label lblCuotas;
        private ComboBox comboBox2;
        private RadioButton rbtTarjeta;
        private RadioButton rbtEfectivo;
        private Button btnCalcular;
        private Button btnLimpiar;
    }
}
