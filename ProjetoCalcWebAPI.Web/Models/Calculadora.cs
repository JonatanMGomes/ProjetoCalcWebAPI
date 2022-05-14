using ProjetoCalcWebAPI.Web.MinhasExceptions;

namespace ProjetoCalcWebAPI.Web.Models
{
    public class Calculadora
    {
        public int Somar(int num1, int num2)
        {
            if (ValidarNumero(num1) && ValidarNumero(num2))
            {
                return num1 + num2;
            }
            throw new InputIncorreto("Número(s) invalido(s)!");
        }
        public int Subtrair(int num1, int num2)
        {
            if (ValidarNumero(num1) && ValidarNumero(num2))
            {
                return num1 - num2;
            }
            throw new InputIncorreto("Número(s) invalido(s)!");
        }
        public double Multiplicar(int num1, int num2)
        {
            if (ValidarNumero(num1) && ValidarNumero(num2) && ValidarNumeroSemNegativos(num1) && ValidarNumeroSemNegativos(num2))
            {
                return num1 * num2;
            }
            throw new InputIncorreto("Número(s) invalido(s)!");
        }
        public double Dividir(int num1, int num2)
        {
            if (ValidarNumero(num1) && ValidarNumero(num2) && ValidarNumeroSemNegativos(num1) && ValidarNumeroSemNegativos(num2))
            {
                return num1 / num2;
            }
            throw new InputIncorreto("Número(s) invalido(s)!");
        }
        public bool ValidarNumero(double valor)
        {
            if (valor != 0 & valor < 1000)
                return true;
            return false;
        }
        public bool ValidarNumeroSemNegativos(double valor)
        {
            if (valor > 0)
                return true;
            return false;
        }
    }
}