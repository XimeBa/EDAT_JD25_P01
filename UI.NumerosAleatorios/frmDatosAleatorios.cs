namespace UI.NumerosAleatorios
{
    public partial class frmDatosAleatorios : Form
    {
        public frmDatosAleatorios()
        {
            InitializeComponent();
        }

        Random aleatorio = new Random();

        Empleado empleado = new Empleado();


        private void btnMostrarMensaje_Click(object sender, EventArgs e)
        {


            empleado.Numero = aleatorio.Next(1, 5);

            string[] strNombresA = {"Ximena", "Diana", "Antonio", "Uriel", "Juan" };
            char[] grupo = { 'A', 'B', 'C'};

            empleado.Nombre = strNombresA[aleatorio.Next(strNombresA.Length)];

            empleado.Grupo = grupo[aleatorio.Next(grupo.Length)];

            DateTime fechaInicial = new DateTime(1990, 01, 01);
            int rangoDias = (DateTime.Today - fechaInicial).Days;          //Se resta fecha de hoy, con la fecha inicial para asi poder determinar la fecha de nacimiento
            DateTime dtmFechaNacimiento = fechaInicial.AddDays(aleatorio.Next(rangoDias));
            

            if (empleado.Nombre.Substring(empleado.Nombre.Length - 1, 1) == "a")   //Substring es para tomar un valor especifico de la cadena 
                empleado.Sexo = "Femenino";                                       // el "a" va a determinar si es de sexo femenino 
                                                                                  //if y else para realizar la  comparación
            else
                empleado.Sexo = "Masculino";

            empleado.Sueldo = aleatorio.Next(1500, 3000);

            bool seguroMedico = aleatorio.Next(2) == 0;     // 

            //Se ocupa btn es para mostrar ahi la informacion en el formulario

            btnNumero.Text = empleado.Numero.ToString();

            btnNombre.Text = empleado.Nombre.ToString();

            //btnFechaNacimiento.Text = empleado.FechaNacimiento.ToString();

            if (empleado.Sexo == "Femenino")                    //if y el else se ocupa para lo mismo, llamar boton y realizar la comparación que se solicito anteriormente 
                btnFemenino.Checked = true;
            else
                btnMasculino.Checked = true;

            btnSueldo.Text = empleado.Sueldo.ToString();

            btnGrupo.Text = empleado.Grupo.ToString();

            btnSeguroMedico.Text = empleado.SeguroMedico.ToString();


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmDatosAleatorios_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGrupo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnFemenino_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnMasculino_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnSueldo_TextChanged(object sender, EventArgs e)
        {
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
