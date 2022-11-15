namespace apiTSZR.Models
{
    public class Avaliacao
    {
        public int Id { get; set; }
        public Cliente Cliente { get; set; }
        public string Avaliar { get; set; }
    }
}