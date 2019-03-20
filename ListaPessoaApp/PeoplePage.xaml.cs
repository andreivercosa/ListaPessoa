using System;
using System.Collections.Generic;
using ListaPessoaApp.Model;

using Xamarin.Forms;

namespace ListaPessoaApp
{
    public partial class PeoplePage : ContentPage
    {

        public PeoplePage(List<Pessoa> NovaLista)
        {
            InitializeComponent();
            listView_lista.ItemsSource = NovaLista;
        }
    }
}
