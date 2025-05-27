using Controlecontatos.Models;

namespace Controlecontatos.Repositorio;

public interface IContatoRepositorio
{
    List<ContatoModel> BuscarTodos();
    ContatoModel Adicionar(ContatoModel contato);
    
}