namespace apiTSZR.Models
{
    public class Cliente
    {
         public int Id { get; set; }
         public string Nome { get; set; }
         public string? Cpf { get; set; }
         public string? Cnpj { get; set; }
         public string? Cargo { get; set; }
         public string? Instituicao { get; set; }
         public string Email { get; set; }
         public string Telefone { get; set;}
         public string Escolha { get; set; }
         public string? Equipamento { get; set; }
         public string Explicacao { get; set; }

         public Endereco Endereco { get; set; }

    }
}