namespace apiTSZR.Models
{
    public class Equipamento
    {
        public int Id { get; set; }
        public Avaliacao Avaliacao { get; set;}
        public string Pecas { get; set;}
        public double Valor { get; set; }

        public AssistenciaTec Tec { get; set; }
    }
}