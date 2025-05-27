﻿using Controlecontatos.Models;
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
    // GET
    public IActionResult Index()
    {
        List<ContatoModel> contatos = _contatoRepositorio.BuscarTodos();
        return View(contatos);
    }
    public IActionResult Adicionar()
    {
        return View();
    }
    
    public IActionResult Editar()
    {
        return View();
    }
    
    public IActionResult DeletarConfirmacao()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Adicionar(ContatoModel contato)
    {
        _contatoRepositorio.Adicionar(contato);
        return RedirectToAction("Index");
    }
}