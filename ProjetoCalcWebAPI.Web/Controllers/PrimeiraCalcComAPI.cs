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
            if (primeiroNum == 0 || primeiroNum > 999 || segundoNum == 0 || segundoNum > 999)
            {
                return BadRequest("Parâmetro(s) inválido(s), nenhum dos parâmetros pode ser igual a 0 ou maior que 999.");
            }
            var resultado = primeiroNum + segundoNum;
            return Ok($"O resultado da soma é: {resultado}");
        }
        [HttpGet("Subtração")]
        public IActionResult SubtracaoAPI(int primeiroNum, int segundoNum)
        {
            if (primeiroNum == 0 || primeiroNum > 999 || segundoNum == 0 || segundoNum > 999)
            {
                return BadRequest("Parâmetro(s) inválido(s), nenhum dos parâmetros pode ser igual a 0 ou maior que 999.");
            }
            var resultado = primeiroNum - segundoNum;
            return Ok($"O resultado da subtração é: {resultado}");
        }
        [HttpGet("Multiplicação")]
        public IActionResult MultiplicacaoAPI(int primeiroNum, int segundoNum)
        {
            if (primeiroNum == 0 || primeiroNum > 999 || segundoNum == 0 || segundoNum > 999)
            {
                return BadRequest("Parâmetro(s) inválido(s), nenhum dos parâmetros pode ser igual a 0 ou maior que 999.");
            }
            if (primeiroNum < 0 || segundoNum < 0)
            {
                return BadRequest("Parâmetro inválido, nenhum dos parâmetros pode ser menor que 0.");
            }
            var resultado = primeiroNum * segundoNum;
            return Ok($"O resultado da multiplicação é: {resultado}");
        }
        [HttpGet("Divisão")]
        public IActionResult DivisaoAPI(int primeiroNum, int segundoNum)
        {
            if (primeiroNum == 0 || primeiroNum > 999 || segundoNum == 0 || segundoNum > 999)
            {
                return BadRequest("Parâmetro(s) inválido(s), nenhum dos parâmetros pode ser igual a 0 ou maior que 999.");
            }
            if (primeiroNum < 0 || segundoNum < 0)
            {
                return BadRequest("Parâmetro inválido, nenhum dos parâmetros pode ser menor que 0.");
            }
            var resultado = primeiroNum / segundoNum;
            return Ok($"O resultado da divisão é: {resultado}");
        }
    }
}