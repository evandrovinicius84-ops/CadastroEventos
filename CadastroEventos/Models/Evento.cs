using System;

namespace CadastroEventos.Models
{
    public class Evento
    {
        public string Nome { get; set; }
        public DateTime DataInicio { get; set; } = DateTime.Now;
        public DateTime DataTermino { get; set; } = DateTime.Now.AddDays(1);
        public int NumeroParticipantes { get; set; }
        public string Local { get; set; }
        public decimal CustoPorParticipante { get; set; }

        // Propriedade que calcula a diferença de tempo usando TimeSpan
        public TimeSpan Duracao => DataTermino - DataInicio;

        // Retorna a duração em dias (garante pelo menos 1 se for no mesmo dia)
        public int DuracaoEmDias => Duracao.Days <= 0 ? 1 : Duracao.Days;

        // Calcula o custo total com base no número de participantes
        public decimal CustoTotal => NumeroParticipantes * CustoPorParticipante;
    }
}

