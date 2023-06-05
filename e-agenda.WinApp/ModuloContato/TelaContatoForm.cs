namespace e_Agenda.WinApp.ModuloContato
{
    public partial class TelaContatoForm : Form
    {
        private Contato contato;

        public TelaContatoForm()
        {
            InitializeComponent();

            this.ConfigurarDialog();
        }

        public Contato ObterContato()
        {
            int id = Convert.ToInt32(txtId.Text);

            string nome = txtNome.Text;

           // mTelefone.Text = value.telefone;

            string telefone = mTelefone.Text;


            string email = txtEmail.Text;

            string cargo = txtCargo.Text;

            string empresa = txtEmpresa.Text;

            Contato contato = new Contato(nome, mTelefone, email, cargo, empresa);

            if (id > 0) 
                contato.id = id;

            return contato;         
          
        }

        public void ConfigurarTela(Contato contato)
        {
            txtId.Text = contato.id.ToString();

            txtNome.Text = contato.nome;

            mTelefone.Text = contato.telefone;

            txtEmail.Text = contato.email;

            txtCargo.Text = contato.cargo;

            txtEmpresa.Text = contato.empresa;
        }
        private void btnGravar_Click(object sender, EventArgs e)
        {

            Contato contato = ObterContato();

            string[] erros = contato.Validar();

            //string nome = txtNome.Text;

            //string telefone = mTelefone.Text;

            //string email = txtEmail.Text;

            //bool validacao = email.Contains("@") && email.Contains(".com");

            //if (validacao == true)
            //{
            //    //   MessageBox.Show("email digitado é valido");
            //}
            //else
            //{
            //    MessageBox.Show("Email digitado é invalido");

            //    MessageBox.Show("xxx@xxx.com");
            //}

            //string cargo = txtCargo.Text;

            //string empresa = txtEmpresa.Text;

            //contato = new Contato(nome, telefone, email, cargo, empresa);

            //if (txtId.Text != "0")
            //    contato.id = Convert.ToInt32(txtId.Text);

            //string[] erros = contato.Validar();

            if (erros.Length > 0)
            {
                // mostra erros no rodapé

                TelaPrincipalForm.Instancia.AtualizarRodape(erros[0]);

                DialogResult = DialogResult.None;

            }
        }

        private void TelaContatoForm_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }
    }
}
