namespace apiTSZR.Models
{
    public class Endereco
    {
        public int Id { get; set; }
        public string Uf { get; set;}
        public string Cep { get; set;}
        public string Rua { get; set; }
        public string PontoRef { get; set;}

        public Cliente cliente { get; set; }

    }
}
