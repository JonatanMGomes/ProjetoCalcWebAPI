namespace ProjetoCalcWebAPI.Web.Models
{
    public class Calculadora
    {
        public int Soma(int num1, int num2){
            return num1+num2;
        }
        public int Subtracao(int num1, int num2){
            return num1-num2;
        }
        public double Multiplicacao(int num1, int num2){
            return num1*num2;
        }
        public double Divisao(int num1, int num2){
            return num1/num2;
        }
    }
}