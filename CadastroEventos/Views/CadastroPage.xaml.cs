using CadastroEventos.Models;
using System;

namespace CadastroEventos.Views
{
    public partial class CadastroPage : ContentPage
    {
        public CadastroPage()
        {
            InitializeComponent();
            // Vincula o BindingContext a uma nova instância do modelo Evento
            BindingContext = new Evento();
        }

        private async void OnSalvarClicked(object sender, EventArgs e)
        {
            var evento = (Evento)BindingContext;

            // Validações básicas de preenchimento
            if (string.IsNullOrWhiteSpace(evento.Nome))
            {
                await DisplayAlert("Erro", "O nome do evento é obrigatório.", "OK");
                return;
            }

            if (evento.DataTermino < evento.DataInicio)
            {
                await DisplayAlert("Erro", "A data de término não pode ser anterior à data de início.", "OK");
                return;
            }

            // Abre a página de Resumo passando o objeto com os dados preenchidos
            await Navigation.PushAsync(new ResumoPage(evento));
        }
    }
}
