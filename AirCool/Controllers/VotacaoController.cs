using AirCool.Domain.Entities;
using AirCool.Dto.Requests.Votacao;
using AirCool.Repositories.Interfaces;
using AirCool.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AirCool.Controllers
{
    [Route("api/v1/votacao")]
    [ApiController]
    public class VotacaoController : ControllerBase
    {
        private readonly IVotacaoService _votacaoService;
        public VotacaoController (IVotacaoService votacaoService)
        {
            _votacaoService = votacaoService;
        }

        // GET: api/<ValuesController>
        [HttpGet("obter-votacoes/{idEmpresa}")]
        public IEnumerable<string> ObterVotacoes(Guid idEmpresa)
        {

            return new string[] { "value1", "value2" };
        }

        // GET api/<ValuesController>/5
        [HttpGet("obter-votacoao/{idExterno}/{idEmpresa}")]
        public string ObterVotacao(int id)
        {
            return "value";
        }

        // POST api/<ValuesController>
        [HttpPost]
        public IActionResult Post([FromBody] CriarVotacaoRequest request)
        {
            _votacaoService.CriarVotacao(request);

            return Ok();
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
