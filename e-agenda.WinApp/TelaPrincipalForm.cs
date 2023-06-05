using e_Agenda.WinApp.Compartilhado;
using e_Agenda.WinApp.ModuloContato;
using e_Agenda.WinApp.ModuloCompromisso;
using e_Agenda.WinApp.ModuloTarefa;
using e_Agenda.WinApp.ModuloDespesa;


namespace e_Agenda.WinApp
{
    public partial class TelaPrincipalForm : Form
    {
        private ControladorBase controlador;

        static ContextoDados contextoDados = new ContextoDados(carregarDados: true);

        private IRepositorioContato repositorioContato = new RepositorioContatoEmArquivo(contextoDados);
        private IRepositorioCategoria repositorioCategoria = new RepositorioCategoriaEmArquivo(contextoDados);

        private IRepositorioCompromisso repositorioCompromisso = new RepositorioCompromissoEmArquivo(contextoDados);
        private IRepositorioTarefa repositorioTarefa = new RepositorioTarefaEmArquivo(contextoDados);


        private static TelaPrincipalForm telaPrincipal;
        public TelaPrincipalForm()
        {
            InitializeComponent();

            telaPrincipal = this;

            PopularRepositorios();
        }

        private void PopularRepositorios()
        {
            Contato caio = new Contato("Caio Henrique Garcia Valle", "caio@gmail.com", "(99) 99999-9999", "Dev", "CEDUP");

            Contato camile = new Contato("Camile Coelho Arruda", "camile@gmail.com", "(99) 99999-9999", "Dev", "IFSC");

            Contato davi = new Contato("Davi William Silva", "davi@gmail.com", "(99) 99999-9999", "Dev", "UNIPLAC");

            Contato diego = new Contato("Diego Oliveira", "diego@gmail.com", "(99) 99999-9999", "Dev", "UNIPLAC");

            Contato eduardo = new Contato("Eduardo Moreira de Jesus", "eduardo@gmail.com", "(99) 99999-9999", "Dev", "IFSC");

            repositorioContato.Inserir(caio);
            repositorioContato.Inserir(camile);
            repositorioContato.Inserir(davi);
            repositorioContato.Inserir(diego);
            repositorioContato.Inserir(eduardo);

            Compromisso c01 = new Compromisso("Entrevista - Caio Henrique", new DateTime(2023, 5, 21), new TimeSpan(9, 0, 0), new TimeSpan(10, 0, 0), caio, "Midilages", TipoLocalEnum.Presencial);
            Compromisso c02 = new Compromisso("Entrevista - Camile", new DateTime(2023, 5, 22), new TimeSpan(9, 0, 0), new TimeSpan(10, 0, 0), camile, "Midilages", TipoLocalEnum.Presencial);
            Compromisso c03 = new Compromisso("Entrevista - Davi", new DateTime(2023, 5, 23), new TimeSpan(9, 0, 0), new TimeSpan(10, 0, 0), davi, "Midilages", TipoLocalEnum.Presencial);
            Compromisso c04 = new Compromisso("Entrevista - Diego", new DateTime(2023, 5, 24), new TimeSpan(9, 0, 0), new TimeSpan(10, 0, 0), diego, "Midilages", TipoLocalEnum.Presencial);
            Compromisso c05 = new Compromisso("Entrevista - Eduardo", new DateTime(2023, 5, 25), new TimeSpan(9, 0, 0), new TimeSpan(10, 0, 0), eduardo, "Midilages", TipoLocalEnum.Presencial);

            repositorioCompromisso.Inserir(c01);
            repositorioCompromisso.Inserir(c02);
            repositorioCompromisso.Inserir(c03);
            repositorioCompromisso.Inserir(c04);
            repositorioCompromisso.Inserir(c05);
        }

        public void AtualizarRodape(string mensagem)
        {
            labelRodape.Text = mensagem;
        }

        //singleton
        public static TelaPrincipalForm Instancia
        {
            get
            {
                if (telaPrincipal == null)
                    telaPrincipal = new TelaPrincipalForm();

                return telaPrincipal;
            }
        }

        private void contatosMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorContato(repositorioContato);

            ConfigurarTelaPrincipal(controlador);
        }

        private void compromissosMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorCompromisso(repositorioContato, repositorioCompromisso);

            ConfigurarTelaPrincipal(controlador);
        }

        private void tarefasMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorTarefa(repositorioTarefa);

            ConfigurarTelaPrincipal(controlador);
        }

        private void categoriasMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorCategoria(repositorioCategoria);

            ConfigurarTelaPrincipal(controlador);
        }

        private void ConfigurarTelaPrincipal(ControladorBase controladorBase)
        {
            labelTipoCadastro.Text = controladorBase.ObterTipoCadastro();

            ConfigurarEstados(controlador);

            ConfigurarToolTips(controlador);

            ConfigurarListagem(controlador);
        }

        private void ConfigurarListagem(ControladorBase controladorBase)
        {
            UserControl listagem = controladorBase.ObterListagem();

            listagem.Dock = DockStyle.Fill;

            panelRegistros.Controls.Clear();

            panelRegistros.Controls.Add(listagem);
        }


        private void ConfigurarToolTips(ControladorBase controlador)
        {
            btnInserir.ToolTipText = controlador.ToolTipInserir;
            btnEditar.ToolTipText = controlador.ToolTipEditar;
            btnExcluir.ToolTipText = controlador.ToolTipExcluir;
            btnFiltrar.ToolTipText = controlador.ToolTipFiltrar;
            btnAdicionarItens.ToolTipText = controlador.ToolTipAdicionarItens;
            btnConcluirItens.ToolTipText = controlador.ToolTipConcluirItens;
        }


        private void ConfigurarEstados(ControladorBase controlador)
        {
            btnInserir.Enabled = controlador.InserirHabilitado;
            btnEditar.Enabled = controlador.EditarHabilitado;
            btnExcluir.Enabled = controlador.ExcluirHabilitado;
            btnFiltrar.Enabled = controlador.FiltrarHabilitado;
            btnAdicionarItens.Enabled = controlador.AdicionarItensHabilitado;
            btnConcluirItens.Enabled = controlador.ConcluirItensHabilitado;
        }
        private void btnInserir_Click(object sender, EventArgs e)
        {
            controlador.Inserir();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            controlador.Editar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            controlador.Excluir();
        }

        private void btnFiltar_Click(object sender, EventArgs e)
        {
            controlador.Filtrar();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            controlador.Adicionar();
        }

        private void btnConcluirItens_Click(object sender, EventArgs e)
        {
            controlador.ConcluirItens();
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            controlador.Visualizar();
        }
    }
}