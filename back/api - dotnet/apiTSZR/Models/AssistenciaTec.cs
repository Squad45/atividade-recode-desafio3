namespace apiTSZR.Models
{
    public class AssistenciaTec
    {
        public int Id { get; set; }
        public string Loja { get; set; }
        public ICollection<Equipamento> Equipamentos { get; set; }
    }
}