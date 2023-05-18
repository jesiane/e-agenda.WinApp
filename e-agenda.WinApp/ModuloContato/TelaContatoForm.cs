namespace e_Agenda.WinApp.ModuloContato
{
    public partial class TelaContatoForm : Form
    {
        private Contato contato;

        public TelaContatoForm()
        {
            InitializeComponent();
        }

        public Contato Contato
        {
            set
            {
                txtId.Text = value.id.ToString();
                txtNome.Text = value.nome;
                //   txtTelefone.Text = value.telefone;
                mTelefone.Text = value.telefone; // formatação do proprio elemento 

                txtEmail.Text = value.email;
                txtCargo.Text = value.cargo;
                txtEmpresa.Text = value.empresa;
            }
            get
            {
                return contato;
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;

            //   string telefone = txtTelefone.Text;
            string telefone = mTelefone.Text;


            string email = txtEmail.Text;

            bool validacao = email.Contains("@") && email.Contains(".com");

            if (validacao == true)
            {
             //   MessageBox.Show("email digitado é valido");
            }
            else
            {
                MessageBox.Show("Email digitado é invalido");

                MessageBox.Show("Digite o email valido");
            }

            string cargo = txtCargo.Text;

            string empresa = txtEmpresa.Text;

            contato = new Contato(nome, telefone, email, cargo, empresa);

            if (txtId.Text != "0")
                contato.id = Convert.ToInt32(txtId.Text);
        }
    }
}
