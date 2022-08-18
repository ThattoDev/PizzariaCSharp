namespace PizzariaCSharp.Model
{
    public class Cliente
    {
        public int Id {get; set;}
        public string Nome {get; set;}
        public int telefone {get; set;}
        public List<Endereco> Enderecos {get; set;}
        
    }
}