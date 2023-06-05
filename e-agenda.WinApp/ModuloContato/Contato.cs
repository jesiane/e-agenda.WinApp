﻿using e_Agenda.WinApp.Compartilhado;

namespace e_Agenda.WinApp.ModuloContato
{
    public class Contato : EntidadeBase <Contato>
    {
        public int id;
        public string nome;
        public string telefone;
        public string email;
        public string cargo;
        public string empresa;

        public Contato(string nome, string telefone, string email, string cargo, string empresa)
        {
            this.nome = nome;
            this.telefone = telefone;
            this.email = email;
            this.cargo = cargo; 
            this.empresa = empresa;
        }

        public override void AtualizarInformacoes(Contato registroAtualizado)
        {
            this.nome = registroAtualizado.nome;
            this.telefone = registroAtualizado.telefone;
            this.email = registroAtualizado.email;
            this.cargo = registroAtualizado.cargo;
            this.empresa = registroAtualizado.empresa;
        }

        public override string ToString()
        {
            return "Id: " + id + "," + nome + ", Empresa: " + empresa +", Telefone" + telefone;
        }

        public override string[] Validar()
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrEmpty(nome))
                erros.Add("O campo 'nome' é obrigatorio");


            if (string.IsNullOrEmpty(telefone))
                erros.Add("O campo 'telefone' é obrigatorio");


            if (string.IsNullOrEmpty(email))
                erros.Add("O campo 'email' é obrigatorio");

            return erros.ToArray();
        }

        public override bool Equals(object? obj)
        {
            return obj is Contato contato &&
                   id == contato.id &&
                   nome == contato.nome &&
                   telefone == contato.telefone &&
                   email == contato.email &&
                   cargo == contato.cargo &&
                   empresa == contato.empresa;
        }
    }
}
 