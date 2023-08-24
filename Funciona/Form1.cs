namespace Funciona
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void CarregaForm(Form form)
        {
            form.TopLevel = false;
            panel2.Controls.Clear();
            panel2.Controls.Add(form);
            form.Location = new Point(panel2.Width/2 - form.Width/2, panel2.Height/2 - form.Height/2);
            form.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Inicio inicio = new Inicio();
            CarregaForm(inicio);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            login login = new login();
            CarregaForm(login);
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            Inicio inicio = new Inicio();
            CarregaForm(inicio);
        }
    }
}