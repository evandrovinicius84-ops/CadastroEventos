using CadastroEventos.Models;
using System;

namespace CadastroEventos.Views
{
    public partial class ResumoPage : ContentPage
    {
        // O construtor recebe os dados da tela anterior e joga no BindingContext
        public ResumoPage(Evento eventoSelecionado)
        {
            InitializeComponent();
            BindingContext = eventoSelecionado;
        }

        private async void OnVoltarClicked(object sender, EventArgs e)
        {
            // Remove a página atual para retornar à tela de cadastro
            await Navigation.PopAsync();
        }
    }
}
