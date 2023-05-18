

using e_Agenda.WinApp.ModuloContato;

namespace e_agenda.WinApp.ModuloContato
{
    public partial class ListagemContatosControl : UserControl
    {
        public ListagemContatosControl()
        {
            InitializeComponent();

        }

        public void AtualizarRegistros(List<Contato> contatos)
        {
            listContato.Items.Clear();

            foreach (Contato item in contatos)
            {
                listContato.Items.Add(item);
            }
        }

        public Contato ObterContatoSelecionado()
        {
            return (Contato)listContato.SelectedItem;
        }
    }
}