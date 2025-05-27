using Controlecontatos.Data;
using Controlecontatos.Models;

namespace Controlecontatos.Repositorio;

public class ContatoRepositorio : IContatoRepositorio
{
    private readonly BancoContext _bancoContext;
    public ContatoRepositorio(BancoContext bancoContext)
    {
        _bancoContext = bancoContext;
    }
    public List<ContatoModel> BuscarTodos()
    {
        return _bancoContext.Contatos.ToList();
    }
    public ContatoModel ListarPorId(int id)
    {
        return _bancoContext.Contatos.FirstOrDefault(x => x.Id == id);
    }
    public ContatoModel Adicionar(ContatoModel contato)
    {
        _bancoContext.Contatos.Add(contato);
        _bancoContext.SaveChanges();
        return contato;
    }
    public ContatoModel Atualizar(ContatoModel contato)
    {
        ContatoModel contatoDB = ListarPorId(contato.Id);

        if (contatoDB == null)
        {
            throw new System.Exception("Houve um erro na atualização do contato");
        }

        contatoDB.Name = contato.Name;
        contatoDB.Email = contato.Email; 
        contatoDB.Celular = contato.Celular; 
        _bancoContext.SaveChanges();
        return contatoDB;
    }
    public bool Remover(int id)
    {
        ContatoModel contatoDB = ListarPorId(id);

        if (contatoDB == null)
        {
            throw new System.Exception("Houve um erro na remoção do contato");
        }

        _bancoContext.Contatos.Remove(contatoDB);
        _bancoContext.SaveChanges();
        return true;
    }

}