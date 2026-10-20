namespace pryReyesProyectoLaboratorio1
{
    partial class frmInscripcion
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
            this.components = new System.ComponentModel.Container();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.grpDatos = new System.Windows.Forms.GroupBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblEdad = new System.Windows.Forms.Label();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.chkEstudiante = new System.Windows.Forms.CheckBox();
            this.grpPlan = new System.Windows.Forms.GroupBox();
            this.lblPlan = new System.Windows.Forms.Label();
            this.cboPlan = new System.Windows.Forms.ComboBox();
            this.lblTurno = new System.Windows.Forms.Label();
            this.cboTurno = new System.Windows.Forms.ComboBox();
            this.lblMeses = new System.Windows.Forms.Label();
            this.txtMeses = new System.Windows.Forms.TextBox();
            this.chkCasillero = new System.Windows.Forms.CheckBox();
            this.grpPago = new System.Windows.Forms.GroupBox();
            this.rbtEfectivo = new System.Windows.Forms.RadioButton();
            this.rbtTarjeta = new System.Windows.Forms.RadioButton();
            this.lblCuotas = new System.Windows.Forms.Label();
            this.cboCuotas = new System.Windows.Forms.ComboBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.grpDatos.SuspendLayout();
            this.grpPlan.SuspendLayout();
            this.grpPago.SuspendLayout();
            this.SuspendLayout();
            // lblTitulo
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(28, 20);
            this.lblTitulo.Text = "Gimnasio Siglo - Inscripción de socios";
            // grpDatos
            this.grpDatos.Controls.Add(this.lblNombre);
            this.grpDatos.Controls.Add(this.txtNombre);
            this.grpDatos.Controls.Add(this.lblEdad);
            this.grpDatos.Controls.Add(this.txtEdad);
            this.grpDatos.Controls.Add(this.chkEstudiante);
            this.grpDatos.Location = new System.Drawing.Point(31, 68);
            this.grpDatos.Size = new System.Drawing.Size(410, 145);
            this.grpDatos.Text = "Datos personales";
            // lblNombre
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(20, 34);
            this.lblNombre.Text = "Nombre:";
            this.txtNombre.Location = new System.Drawing.Point(105, 31);
            this.txtNombre.MaxLength = 30;
            this.txtNombre.Size = new System.Drawing.Size(275, 23);
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            this.txtNombre.TextChanged += new System.EventHandler(this.Datos_TextChanged);
            // lblEdad
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(20, 72);
            this.lblEdad.Text = "Edad:";
            this.txtEdad.Location = new System.Drawing.Point(105, 69);
            this.txtEdad.MaxLength = 3;
            this.txtEdad.Size = new System.Drawing.Size(70, 23);
            this.txtEdad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloDigitos_KeyPress);
            this.txtEdad.TextChanged += new System.EventHandler(this.Datos_TextChanged);
            this.chkEstudiante.AutoSize = true;
            this.chkEstudiante.Location = new System.Drawing.Point(105, 106);
            this.chkEstudiante.Text = "Estudiante";
            // grpPlan
            this.grpPlan.Controls.Add(this.lblPlan);
            this.grpPlan.Controls.Add(this.cboPlan);
            this.grpPlan.Controls.Add(this.lblTurno);
            this.grpPlan.Controls.Add(this.cboTurno);
            this.grpPlan.Controls.Add(this.lblMeses);
            this.grpPlan.Controls.Add(this.txtMeses);
            this.grpPlan.Controls.Add(this.chkCasillero);
            this.grpPlan.Location = new System.Drawing.Point(31, 229);
            this.grpPlan.Size = new System.Drawing.Size(410, 205);
            this.grpPlan.Text = "Plan y servicios";
            this.lblPlan.AutoSize = true;
            this.lblPlan.Location = new System.Drawing.Point(20, 35);
            this.lblPlan.Text = "Plan:";
            this.cboPlan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPlan.Items.AddRange(new object[] { "Musculación", "Funcional", "Natación" });
            this.cboPlan.Location = new System.Drawing.Point(105, 32);
            this.cboPlan.Size = new System.Drawing.Size(180, 23);
            this.lblTurno.AutoSize = true;
            this.lblTurno.Location = new System.Drawing.Point(20, 75);
            this.lblTurno.Text = "Turno:";
            this.cboTurno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTurno.Items.AddRange(new object[] { "Mañana", "Tarde", "Noche" });
            this.cboTurno.Location = new System.Drawing.Point(105, 72);
            this.cboTurno.Size = new System.Drawing.Size(180, 23);
            this.lblMeses.AutoSize = true;
            this.lblMeses.Location = new System.Drawing.Point(20, 115);
            this.lblMeses.Text = "Meses (1 a 12):";
            this.txtMeses.Location = new System.Drawing.Point(145, 112);
            this.txtMeses.MaxLength = 2;
            this.txtMeses.Size = new System.Drawing.Size(60, 23);
            this.txtMeses.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloDigitos_KeyPress);
            this.txtMeses.TextChanged += new System.EventHandler(this.Datos_TextChanged);
            this.chkCasillero.AutoSize = true;
            this.chkCasillero.Location = new System.Drawing.Point(105, 154);
            this.chkCasillero.Text = "Casillero ($ 3.000/mes)";
            // grpPago
            this.grpPago.Controls.Add(this.rbtEfectivo);
            this.grpPago.Controls.Add(this.rbtTarjeta);
            this.grpPago.Controls.Add(this.lblCuotas);
            this.grpPago.Controls.Add(this.cboCuotas);
            this.grpPago.Location = new System.Drawing.Point(476, 68);
            this.grpPago.Size = new System.Drawing.Size(360, 180);
            this.grpPago.Text = "Forma de pago";
            this.rbtEfectivo.AutoSize = true;
            this.rbtEfectivo.Location = new System.Drawing.Point(25, 40);
            this.rbtEfectivo.Text = "Efectivo";
            this.rbtEfectivo.CheckedChanged += new System.EventHandler(this.FormaPago_CheckedChanged);
            this.rbtTarjeta.AutoSize = true;
            this.rbtTarjeta.Location = new System.Drawing.Point(25, 78);
            this.rbtTarjeta.Text = "Tarjeta";
            this.rbtTarjeta.CheckedChanged += new System.EventHandler(this.FormaPago_CheckedChanged);
            this.lblCuotas.AutoSize = true;
            this.lblCuotas.Location = new System.Drawing.Point(25, 120);
            this.lblCuotas.Text = "Cuotas:";
            this.cboCuotas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCuotas.Items.AddRange(new object[] { "1", "3", "6" });
            this.cboCuotas.Location = new System.Drawing.Point(95, 117);
            this.cboCuotas.Size = new System.Drawing.Size(100, 23);
            this.btnCalcular.Enabled = false;
            this.btnCalcular.Location = new System.Drawing.Point(476, 284);
            this.btnCalcular.Size = new System.Drawing.Size(160, 42);
            this.btnCalcular.Text = "&Calcular";
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            this.btnLimpiar.Location = new System.Drawing.Point(656, 284);
            this.btnLimpiar.Size = new System.Drawing.Size(160, 42);
            this.btnLimpiar.Text = "&Limpiar";
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // frmInscripcion
            this.AcceptButton = this.btnCalcular;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 480);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.grpDatos);
            this.Controls.Add(this.grpPlan);
            this.Controls.Add(this.grpPago);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.btnLimpiar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmInscripcion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gimnasio Siglo - Inscripción";
            this.Load += new System.EventHandler(this.frmInscripcion_Load);
            this.grpDatos.ResumeLayout(false);
            this.grpDatos.PerformLayout();
            this.grpPlan.ResumeLayout(false);
            this.grpPlan.PerformLayout();
            this.grpPago.ResumeLayout(false);
            this.grpPago.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox grpDatos;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.CheckBox chkEstudiante;
        private System.Windows.Forms.GroupBox grpPlan;
        private System.Windows.Forms.Label lblPlan;
        private System.Windows.Forms.ComboBox cboPlan;
        private System.Windows.Forms.Label lblTurno;
        private System.Windows.Forms.ComboBox cboTurno;
        private System.Windows.Forms.Label lblMeses;
        private System.Windows.Forms.TextBox txtMeses;
        private System.Windows.Forms.CheckBox chkCasillero;
        private System.Windows.Forms.GroupBox grpPago;
        private System.Windows.Forms.RadioButton rbtEfectivo;
        private System.Windows.Forms.RadioButton rbtTarjeta;
        private System.Windows.Forms.Label lblCuotas;
        private System.Windows.Forms.ComboBox cboCuotas;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpiar;

        #endregion
    }
}

