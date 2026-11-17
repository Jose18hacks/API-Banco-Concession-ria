using API_concessionaria.Models;

namespace API_concessionaria.Interfaces
{
    /*
        public interface - É um contrato: só diz QUE o método existe,
                           sem implementar (sem corpo { }).

        List<Marca>      - devolve uma lista de Marca.
    */
    public interface IMarcaRepository
    {
        // R - Read: devolve todos os cursos.
        List<Marca> ListarTodos();

        // R - Read: busca um curso pelo Id (ou null se não achar).
        Marca? BuscarPorId(int id);

        // C - Create: cadastra uma marca nova.
        void Cadastrar(Marca marca);
    }
}