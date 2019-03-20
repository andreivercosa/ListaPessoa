using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using ListaPessoaApp.Model;

namespace ListaPessoaApp
{
    public partial class MainPage : ContentPage
    {
        List<Pessoa> listaPessoa = new List<Pessoa>();
        List<string> stringlista = new List<string>();

        public MainPage()
        {
            InitializeComponent();
        }

        void Adicionar(object sender, System.EventArgs e)
        {
            Pessoa pessoa = new Pessoa();
            pessoa.nome = nome.Text;
            pessoa.sobrenome = sobrenome.Text;

            listaPessoa.Add(pessoa);
            stringlista.Add(pessoa.nome + " " + pessoa.sobrenome);
            pessoa.dtCadastro = string.Format("{0:dd/MM/yyyy HH:hh:mm:ss}", DateTime.Now);
        }

        void Listar(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new PeoplePage(listaPessoa));
        }
    }

}
