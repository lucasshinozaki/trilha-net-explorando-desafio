namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            bool _verifica = hospedes.Count <= Suite.Capacidade;
            if (_verifica)
            {
                Hospedes = hospedes;
            }
            else
            {
                throw new Exception("A capacidade é menor que o número de hóspeder recebido");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            return Hospedes.Count;
        }

        public decimal CalcularValorDiaria()
        {
            decimal valor = DiasReservados * Suite.ValorDiaria;
            bool _verifica = DiasReservados >= 10;
            if (_verifica)
            {
                valor *= 0.9M ;
            }

            return valor;
        }
    }
}