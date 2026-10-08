namespace pryAimarGym
{
    public partial class frmInscripcion : Form
    {
        public frmInscripcion()
        {
            InitializeComponent();
        }

        private void EstadoInicial()
        {
            txtNombre.Clear();
            txtEdad.Clear();
            txtMeses.Text = "1";
            chkCasillero.Checked = false;
            chkEstudiante.Checked = false;
            cboPlan.SelectedIndex = 0;
            cboTurno.SelectedIndex = 0;
            rbtEfectivo.Checked = false;
            cboCuotas.SelectedIndex = 0;
            cboCuotas.Enabled = false;
            btnCalcular.Enabled = false;

        }
        private void frmInscripcion_Load(object sender, EventArgs e)
        {
            EstadoInicial();

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

        }

        private void lblPlan_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            EstadoInicial();

        }

     
    }
}
