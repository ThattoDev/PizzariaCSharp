using PizzariaCSharp.Repository;

namespace PizzariaCSharp.Controller
{
    public class BebidaController
    {
         private BebidaRepository _repositoryBebida;

        public BebidaController(BebidaRepository repositoryBebida)
        {
            _repositoryBebida = repositoryBebida;
        }
    }
}