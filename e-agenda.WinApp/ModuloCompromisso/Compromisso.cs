﻿using e_Agenda.WinApp.Compartilhado;
using e_Agenda.WinApp.ModuloContato;

namespace e_Agenda.WinApp.ModuloCompromisso
{
    public class Compromisso : EntidadeBase
    {
        public int id;
        public string assunto;
        public string local;
        public DateTime data;
        public DateTime horaInicio;
        public DateTime horaTermino;
        public Contato contatoCompromisso;

        public Compromisso(string assunto, string local, DateTime data, DateTime horaInicio, DateTime horaTermino, Contato contatoCompromisso)
        {
            this.assunto = assunto;
            this.local = local;
            this.data = data;
            this.horaInicio = horaInicio;
            this.horaTermino = horaTermino;
            this.contatoCompromisso = contatoCompromisso;
        }

        public override string ToString()
        {
            string contato = contatoCompromisso == null ?
                " |Sem Contato|" : ", Contato: " + contatoCompromisso.nome;
            return "Id: " + id + ", Assunto: " + assunto + ", Local: " + local +
                ", Data: " + data.ToString() + ", HoraInício: " + horaInicio.ToString("HH:mm") + 
                ", HoraTérmino: " + horaTermino.ToString("HH:mm") + contato;
        }
    }
}
