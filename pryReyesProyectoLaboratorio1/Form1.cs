using System;
using System.Collections.Generic; // Necesario para usar List<T>
using System.Windows.Forms;

namespace pryReyesProyectoLaboratorio1
{
    public partial class frmInscripcion : Form
    {
        private const int EDAD_MINIMA = 14;
        private const int MESES_MINIMOS = 1;
        private const int MESES_MAXIMOS = 12;
        private const decimal PRECIO_MUSCULACION = 15000m;
        private const decimal PRECIO_FUNCIONAL = 18000m;
        private const decimal PRECIO_NATACION = 22000m;
        private const decimal PRECIO_CASILLERO = 3000m;
        private const decimal DESCUENTO_MENOR = 0.25m;
        private const decimal DESCUENTO_MAYOR = 0.30m;
        private const decimal DESCUENTO_ESTUDIANTE = 0.15m;
        private const decimal DESCUENTO_EFECTIVO = 0.10m;
        private const decimal RECARGO_TRES_CUOTAS = 0.10m;
        private const decimal RECARGO_SEIS_CUOTAS = 0.20m;

        private struct SOCIO
        {
            public string nombre;
            public int edad;
            public string categoria;
            public string plan;
            public string horario;
            public int meses;
            public string formaPago;
            public decimal total;
            public decimal valorCuota;
        }

        // ➔ ARRAY / LISTA GLOBAL PARA ALMACENAR LOS SOCIOS
        private List<SOCIO> listaSocios = new List<SOCIO>();

        public frmInscripcion()
        {
            InitializeComponent();
        }

        private void frmInscripcion_Load(object sender, EventArgs e)
        {
            EstadoInicial();
        }

        private void EstadoInicial()
        {
            txtNombre.Clear();
            txtEdad.Clear();
            txtMeses.Text = "1";
            chkEstudiante.Checked = false;
            chkCasillero.Checked = false;
            cboPlan.SelectedIndex = 0;
            cboTurno.SelectedIndex = 0;
            rbtEfectivo.Checked = true;
            cboCuotas.SelectedIndex = -1;
            cboCuotas.Enabled = false;
            btnCalcular.Enabled = false;
            txtNombre.Focus();
        }

        private void SoloDigitos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLower(e.KeyChar))
            {
                e.KeyChar = char.ToUpper(e.KeyChar);
            }
        }

        private void Datos_TextChanged(object sender, EventArgs e)
        {
            if (txtNombre.Text.Trim() != string.Empty && txtEdad.Text != string.Empty && txtMeses.Text != string.Empty)
            {
                btnCalcular.Enabled = true;
            }
            else
            {
                btnCalcular.Enabled = false;
            }
        }

        private void FormaPago_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtTarjeta.Checked)
            {
                cboCuotas.Enabled = true;
                cboCuotas.SelectedIndex = 0;
            }
            else
            {
                cboCuotas.SelectedIndex = -1;
                cboCuotas.Enabled = false;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            EstadoInicial();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int edad = int.Parse(txtEdad.Text);
            int meses = int.Parse(txtMeses.Text);

            if (edad < EDAD_MINIMA)
            {
                MessageBox.Show("La edad mínima para inscribirse es de 14 años.", "Datos inválidos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (meses < MESES_MINIMOS || meses > MESES_MAXIMOS)
            {
                MessageBox.Show("La cantidad de meses debe estar entre 1 y 12.", "Datos inválidos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string plan = cboPlan.SelectedItem.ToString();
            decimal precioMensual;
            switch (plan)
            {
                case "Musculación":
                    precioMensual = PRECIO_MUSCULACION;
                    break;
                case "Funcional":
                    precioMensual = PRECIO_FUNCIONAL;
                    break;
                case "Natación":
                    precioMensual = PRECIO_NATACION;
                    break;
                default:
                    MessageBox.Show("Seleccione un plan válido.", "Datos inválidos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
            }

            string horario;
            switch (cboTurno.SelectedIndex)
            {
                case 0:
                    horario = "Mañana (7 a 12 h)";
                    break;
                case 1:
                    horario = "Tarde (14 a 18 h)";
                    break;
                case 2:
                    horario = "Noche (18 a 23 h)";
                    break;
                default:
                    horario = "No definido";
                    break;
            }

            if (chkCasillero.Checked) precioMensual += PRECIO_CASILLERO;

            decimal subtotal = precioMensual * meses;
            decimal descuento;
            if (edad < 18)
            {
                descuento = DESCUENTO_MENOR;
            }
            else if (edad >= 65)
            {
                descuento = DESCUENTO_MAYOR;
            }
            else
            {
                descuento = chkEstudiante.Checked ? DESCUENTO_ESTUDIANTE : 0m;
            }

            decimal total = subtotal - (subtotal * descuento);
            decimal ajustePago = 0m;
            string formaPago;
            int cuotas = 1;

            if (rbtEfectivo.Checked)
            {
                ajustePago = -DESCUENTO_EFECTIVO;
                formaPago = "Efectivo";
            }
            else
            {
                cuotas = int.Parse(cboCuotas.SelectedItem.ToString());
                formaPago = "Tarjeta en " + cuotas + " cuota" + (cuotas == 1 ? "" : "s");
                switch (cuotas)
                {
                    case 1:
                        ajustePago = 0m;
                        break;
                    case 3:
                        ajustePago = RECARGO_TRES_CUOTAS;
                        break;
                    case 6:
                        ajustePago = RECARGO_SEIS_CUOTAS;
                        break;
                }
            }

            total += total * ajustePago;
            string categoria = edad < 18 ? "Menor" : "Mayor";
            decimal valorCuota = rbtEfectivo.Checked ? total : total / cuotas;

            SOCIO socio = new SOCIO
            {
                nombre = txtNombre.Text.Trim(),
                edad = edad,
                categoria = categoria,
                plan = plan,
                horario = horario,
                meses = meses,
                formaPago = formaPago,
                total = total,
                valorCuota = valorCuota
            };

            // ➔ Guardamos el socio en la lista cada vez que se calcula la inscripción
            listaSocios.Add(socio);

            string resumen = "Socio: " + socio.nombre + Environment.NewLine
                + "Edad: " + socio.edad + " (" + socio.categoria + ")" + Environment.NewLine
                + "Plan: " + socio.plan + Environment.NewLine
                + "Horario: " + socio.horario + Environment.NewLine
                + "Meses: " + socio.meses + Environment.NewLine
                + "Forma de pago: " + socio.formaPago + Environment.NewLine
                + "Total: " + socio.total.ToString("C2") + Environment.NewLine
                + "Valor de cuota: " + socio.valorCuota.ToString("C2");

            MessageBox.Show(resumen, "Resumen de inscripción", MessageBoxButtons.OK, MessageBoxIcon.Information);
            EstadoInicial();
        }

        // ➔ EVENTO DEL BOTÓN DE INFORMACIÓN PARA CONSULTAR TODOS LOS SOCIOS CARGADOS
        private void btnInformacionSocios_Click(object sender, EventArgs e)
        {
            if (listaSocios.Count == 0)
            {
                MessageBox.Show("No hay socios registrados en el sistema.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string reporte = "=== LISTADO DE SOCIOS INSCRIPTOS ===\n\n";

            foreach (SOCIO s in listaSocios)
            {
                reporte += "• Nombre: " + s.nombre + " (" + s.edad + " años - " + s.categoria + ")\n"
                        + "  Plan: " + s.plan + " | Horario: " + s.horario + "\n"
                        + "  Meses: " + s.meses + " | Pago: " + s.formaPago + "\n"
                        + "  Total a Pagar: " + s.total.ToString("C2") + "\n"
                        + "--------------------------------------------------\n";
            }

            MessageBox.Show(reporte, "Consulta General de Socios", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}