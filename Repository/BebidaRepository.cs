using PizzariaCSharp.Model;

namespace PizzariaCSharp.Repository
{
    public class BebidaRepository
    {
        private List<Bebida> _bebidas;
        private int _ultimoId = 0;

        public BebidaRepository()
        {
            _bebidas = new List<Bebida>();
            
        }

        public Bebida Adiciona(Bebida bebida)
        {
            _ultimoId++;
            bebida.Id = _ultimoId;

            _bebidas.Add(bebida);
            return bebida;
        }

        public List<Bebida> ObterTodos()
        {

            return _bebidas;
        }

        public Bebida ObterPorId(int id)
        {
            _bebidas.Where(b => b.Id == id);
        }
    }
}