namespace PizzariaCSharp.Model.Pedido
{
    public class Pedido
    {
        public int Id {get; private set;}
        public DateTime Data {get; private set;}
        public Cliente cliente {get; private set;}
        public List<Pizza> Pizzas {get; private set;}
        public List<Bebida> Bebidas {get; private set;}
    }
}