using Microsoft.AspNetCore.Mvc;


namespace ProjetoCalcWebAPI.Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PrimeiraCalcComAPI : ControllerBase
    {
        [HttpGet("Soma")]
        public IActionResult SomaAPI(int primeiroNum, int segundoNum)
        {
            var resultado = primeiroNum + segundoNum;
            return Ok($"O resultado da soma é: {resultado}");
        }
        [HttpGet("Subtração")]
        public IActionResult SubtracaoAPI(int primeiroNum, int segundoNum)
        {
            var resultado = primeiroNum - segundoNum;
            return Ok($"O resultado da subtração é: {resultado}");
        }
        [HttpGet("Multiplicação")]
        public IActionResult MultiplicacaoAPI(int primeiroNum, int segundoNum)
        {
            var resultado = primeiroNum * segundoNum;
            return Ok($"O resultado da multiplicação é: {resultado}");
        }
        [HttpGet("Divisão")]
        public IActionResult DivisaoAPI(int primeiroNum, int segundoNum)
        {
            var resultado = primeiroNum / segundoNum;
            return Ok($"O resultado da divisão é: {resultado}");
        }
    }
}