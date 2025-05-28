using Controlecontatos.Models;
using Controlecontatos.Repositorio;
using Microsoft.AspNetCore.Mvc;

namespace Controlecontatos.Controllers;

public class ContatoController : Controller
{
    private readonly IContatoRepositorio _contatoRepositorio;

    public ContatoController(IContatoRepositorio contatoRepositorio)
    {
        _contatoRepositorio = contatoRepositorio;
    }

    public IActionResult Index()
    {
        List<ContatoModel> contatos = _contatoRepositorio.BuscarTodos();
        return View(contatos);
    }

    public IActionResult Adicionar()
    {
        return View();
    }

    public IActionResult Editar(int id)
    {
        ContatoModel contato = _contatoRepositorio.ListarPorId(id);
        return View(contato);
    }

    public IActionResult DeletarConfirmacao(int id)
    {
        ContatoModel contato = _contatoRepositorio.ListarPorId(id);
        return View(contato);
    }

    [HttpPost]
    public IActionResult Adicionar(ContatoModel contato)
    {
        try
        {
            if (ModelState.IsValid)
            {
                _contatoRepositorio.Adicionar(contato);
                TempData["MensagemSucesso"] = "Contato cadastrado com sucesso!";
                return RedirectToAction("Index");
            }

            return View(contato);
        }
        catch (System.Exception error)
        {
            TempData["MensagemErro"] =
                "Ops...Não conseguimos cadastrar seu contato, tente novamente. Detalhe do erro:" +
                error.Message;
            return RedirectToAction("Index");
        }
    }

    [HttpPost]
    public IActionResult Alterar(ContatoModel contato)
    {
        try
        {
            if (ModelState.IsValid)
            {
                _contatoRepositorio.Atualizar(contato);
                TempData["MensagemSucesso"] = "Contato alterado com sucesso!";
                return RedirectToAction("Index");
            }

            return View("Editar", contato);
        }
        catch (System.Exception error)
        {
            TempData["MensagemErro"] =
                "Ops...Não conseguimos atualizar seu contato, tente novamente. Detalhe do erro:" +
                error.Message;
            return RedirectToAction("Index");
        }
    }

    public IActionResult Remover(int id)
    {
        try
        {
            if (_contatoRepositorio.Remover(id))
            {
                TempData["MensagemSucesso"] = "Contato deletado com sucesso!";
            }
            else
            {
                TempData["MensagemErro"] = "Ops...Não conseguimos apagar seu contato, tente novamente.";
            }

            return RedirectToAction("Index");
        }
        catch (System.Exception error)
        {
            TempData["MensagemErro"] = "Ops...Não conseguimos apagar seu contato, tente novamente. Detalhe do erro:" +
                                       error.Message;
            return RedirectToAction("Index");
        }
    }
}