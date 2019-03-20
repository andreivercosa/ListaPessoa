using System;
namespace ListaPessoaApp.Model
{
    public class Pessoa
    {
        public string nome { get; set; }
        public string sobrenome { get; set; }
        public string dtCadastro { get; set; }
        public string nomeCompleto {
            get { return nome + " " + sobrenome; }
        }

        public Pessoa()
        {




    }
    }
}
