﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        public IEnumerable<Evento> _evento = new Evento[]{
                new Evento(){
                EventoId = 1,
                Tema = "Angular 11 e .net 5",
                Lote = "1º Lote",
                Local = "Brasilia",
                ImageURL = "imagem.jpg",
                QtdPessoas = 250,
                DataEvento = DateTime.Now.AddDays(2).ToString()
                },
                new Evento(){
                EventoId = 2,
                Tema = "Angular 11 e .net 5 e suas novidades",
                Lote = "2º Lote",
                Local = "Sao Paulo",
                ImageURL = "imagem.jpg",
                QtdPessoas = 50,
                DataEvento = DateTime.Now.AddDays(5).ToString()
                }
            };

        public EventoController()
        {
            
        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _evento;
        }

        [HttpGet("{id}")]
        public IEnumerable<Evento> GetById(int id)
        {
            return _evento.Where(evento => evento.EventoId == id);
        }

        [HttpPut("{id}")]
        public string Post(int id)
        {
            return $"Exemplo de PUT com id = {id}";
        }
    }
}
