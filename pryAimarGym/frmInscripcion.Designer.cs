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
            chkCasillero = new CheckBox();
            lblMes = new Label();
            txtMeses = new TextBox();
            cboTurno = new ComboBox();
            lblTurno = new Label();
            lblPlan = new Label();
            cboPlan = new ComboBox();
            chkEstudiante = new CheckBox();
            grpFormasDePago = new GroupBox();
            lblCuotas = new Label();
            cboCuotas = new ComboBox();
            rbtTarjeta = new RadioButton();
            rbtEfectivo = new RadioButton();
            btnCalcular = new Button();
            btnLimpiar = new Button();
            grpDatosPersonales.SuspendLayout();
            grpPlan.SuspendLayout();
            grpFormasDePago.SuspendLayout();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(95, 30);
            txtNombre.MaxLength = 30;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(129, 23);
            txtNombre.TabIndex = 3;
            txtNombre.TextChanged += txtNombre_TextChanged;
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
            lblEdad.Location = new Point(24, 72);
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
            grpDatosPersonales.Location = new Point(21, 12);
            grpDatosPersonales.Name = "grpDatosPersonales";
            grpDatosPersonales.Size = new Size(237, 100);
            grpDatosPersonales.TabIndex = 6;
            grpDatosPersonales.TabStop = false;
            grpDatosPersonales.Text = "DATOS PERSONALES";
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(95, 64);
            txtEdad.MaxLength = 3;
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(100, 23);
            txtEdad.TabIndex = 6;
            // 
            // grpPlan
            // 
            grpPlan.Controls.Add(chkCasillero);
            grpPlan.Controls.Add(lblMes);
            grpPlan.Controls.Add(txtMeses);
            grpPlan.Controls.Add(cboTurno);
            grpPlan.Controls.Add(lblTurno);
            grpPlan.Controls.Add(lblPlan);
            grpPlan.Controls.Add(cboPlan);
            grpPlan.Controls.Add(chkEstudiante);
            grpPlan.Location = new Point(21, 118);
            grpPlan.Name = "grpPlan";
            grpPlan.Size = new Size(237, 211);
            grpPlan.TabIndex = 7;
            grpPlan.TabStop = false;
            grpPlan.Text = "PLAN";
            // 
            // chkCasillero
            // 
            chkCasillero.AutoSize = true;
            chkCasillero.Location = new Point(36, 180);
            chkCasillero.Name = "chkCasillero";
            chkCasillero.Size = new Size(145, 19);
            chkCasillero.TabIndex = 7;
            chkCasillero.Text = "Casillero ($ 3.000/mes)";
            chkCasillero.UseVisualStyleBackColor = true;
            // 
            // lblMes
            // 
            lblMes.AutoSize = true;
            lblMes.Location = new Point(24, 111);
            lblMes.Name = "lblMes";
            lblMes.Size = new Size(29, 15);
            lblMes.TabIndex = 6;
            lblMes.Text = "Mes";
            // 
            // txtMeses
            // 
            txtMeses.Location = new Point(95, 108);
            txtMeses.MaxLength = 2;
            txtMeses.Name = "txtMeses";
            txtMeses.Size = new Size(50, 23);
            txtMeses.TabIndex = 5;
            // 
            // cboTurno
            // 
            cboTurno.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTurno.FormattingEnabled = true;
            cboTurno.Items.AddRange(new object[] { "Mañana ", "Tarde", "Noche" });
            cboTurno.Location = new Point(95, 72);
            cboTurno.Name = "cboTurno";
            cboTurno.Size = new Size(121, 23);
            cboTurno.TabIndex = 4;
            // 
            // lblTurno
            // 
            lblTurno.AutoSize = true;
            lblTurno.Location = new Point(24, 75);
            lblTurno.Name = "lblTurno";
            lblTurno.Size = new Size(39, 15);
            lblTurno.TabIndex = 3;
            lblTurno.Text = "Turno";
            // 
            // lblPlan
            // 
            lblPlan.AutoSize = true;
            lblPlan.Location = new Point(24, 38);
            lblPlan.Name = "lblPlan";
            lblPlan.Size = new Size(30, 15);
            lblPlan.TabIndex = 2;
            lblPlan.Text = "Plan";
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
            // grpFormasDePago
            // 
            grpFormasDePago.Controls.Add(lblCuotas);
            grpFormasDePago.Controls.Add(cboCuotas);
            grpFormasDePago.Controls.Add(rbtTarjeta);
            grpFormasDePago.Controls.Add(rbtEfectivo);
            grpFormasDePago.Location = new Point(21, 335);
            grpFormasDePago.Name = "grpFormasDePago";
            grpFormasDePago.Size = new Size(237, 100);
            grpFormasDePago.TabIndex = 8;
            grpFormasDePago.TabStop = false;
            grpFormasDePago.Text = "FORMAS DE PAGO";
            // 
            // lblCuotas
            // 
            lblCuotas.AutoSize = true;
            lblCuotas.Location = new Point(126, 31);
            lblCuotas.Name = "lblCuotas";
            lblCuotas.Size = new Size(44, 15);
            lblCuotas.TabIndex = 3;
            lblCuotas.Text = "Cuotas";
            // 
            // cboCuotas
            // 
            cboCuotas.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCuotas.FormattingEnabled = true;
            cboCuotas.Items.AddRange(new object[] { "1", "3", "6" });
            cboCuotas.Location = new Point(176, 28);
            cboCuotas.Name = "cboCuotas";
            cboCuotas.Size = new Size(48, 23);
            cboCuotas.TabIndex = 2;
            cboCuotas.SelectedIndexChanged += cboCuotas_SelectedIndexChanged;
            // 
            // rbtTarjeta
            // 
            rbtTarjeta.AutoSize = true;
            rbtTarjeta.Location = new Point(16, 61);
            rbtTarjeta.Name = "rbtTarjeta";
            rbtTarjeta.Size = new Size(60, 19);
            rbtTarjeta.TabIndex = 1;
            rbtTarjeta.TabStop = true;
            rbtTarjeta.Text = "Tarjeta";
            rbtTarjeta.UseVisualStyleBackColor = true;
            rbtTarjeta.CheckedChanged += rbtTarjeta_CheckedChanged;
            // 
            // rbtEfectivo
            // 
            rbtEfectivo.AutoSize = true;
            rbtEfectivo.Location = new Point(17, 29);
            rbtEfectivo.Name = "rbtEfectivo";
            rbtEfectivo.Size = new Size(67, 19);
            rbtEfectivo.TabIndex = 0;
            rbtEfectivo.TabStop = true;
            rbtEfectivo.Text = "Efectivo";
            rbtEfectivo.UseVisualStyleBackColor = true;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(48, 441);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(89, 32);
            btnCalcular.TabIndex = 9;
            btnCalcular.Text = "CALCULAR";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(163, 441);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(82, 32);
            btnLimpiar.TabIndex = 10;
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // frmInscripcion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(283, 498);
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
            Load += frmInscripcion_Load;
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
        private TextBox txtMeses;
        private ComboBox cboTurno;
        private Label lblTurno;
        private Label lblMes;
        private CheckBox chkCasillero;
        private GroupBox grpFormasDePago;
        private Label lblCuotas;
        private ComboBox cboCuotas;
        private RadioButton rbtTarjeta;
        private RadioButton rbtEfectivo;
        private Button btnCalcular;
        private Button btnLimpiar;
    }
}
