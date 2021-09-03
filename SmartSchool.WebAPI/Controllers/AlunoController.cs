using Microsoft.AspNetCore.Mvc;
using SmartSchool.WebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SmartSchool.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlunoController : ControllerBase
    {
        public List<Aluno> Alunos = new List<Aluno>(){
            new Aluno(){
                Id = 1,
                Nome = "Marcos",
                Sobrenome = "Almeida",
                Telefone = "1699623456"
            },
            new Aluno(){
                Id = 2,
                Nome = "José",
                Sobrenome = "Kent",
                Telefone = "585858"
            },
            new Aluno(){
                Id = 3,
                Nome = "Marta",
                Sobrenome = "Maria",
                Telefone = "123456"
            }
        };
        public AlunoController(){}
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(Alunos);
        }

        //api/aluno/byId?id=1
        [HttpGet("byId/{id}")]
        public IActionResult GetById(int id)
        {
            var aluno = Alunos.FirstOrDefault(a => a.Id == id);
            if(aluno == null) return BadRequest("Aluno não encontraodo");
            return Ok(aluno);
        }

        //api/aluno/byName?
        [HttpGet("ByName")]
        public IActionResult GetByName(string nome, string sobrenome)
        {
            var aluno = Alunos.FirstOrDefault(a => a.Nome.Contains(nome) && a.Sobrenome.Contains(sobrenome));
            if(aluno == null) return BadRequest("Aluno não encontraodo");
            return Ok(aluno);
        }

        // api/aluno
        [HttpPost]
        public IActionResult Post(Aluno aluno)
        {
            return Ok(aluno);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, Aluno aluno)
        {
            return Ok(aluno);
        }

        [HttpPatch("{id}")]
        public IActionResult Patch(int id, Aluno aluno)
        {
            return Ok(aluno);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok();
        }
    }
}
