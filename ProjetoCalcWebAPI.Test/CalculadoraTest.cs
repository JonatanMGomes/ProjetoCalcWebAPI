using ProjetoCalcWebAPI.Web.Models;
using Xunit;

namespace ProjetoCalcWebAPI.Test;

public class CalculadoraTest
{
    [Fact]
    public void TestandoSeSomaCalculaValorCorretamente()
    {
        //Arrange
        var valorEsperado = 10;
        var calcTest = new Calculadora();
        //Act
        var valorATestar = calcTest.Soma(5, 5);
        //Assert
        Assert.Equal(valorEsperado, valorATestar);
    }
    [Fact]
    public void TestandoSeSubtracaoCalculaValorCorretamente()
    {
        //Arrange
        var valorEsperado = 5;
        var calcTest = new Calculadora();
        //Act
        var valorATestar = calcTest.Subtracao(10, 5);
        //Assert
        Assert.Equal(valorEsperado, valorATestar);
    }
    [Fact]
    public void TestandoSeMultiplicacaoCalculaValorCorretamente()
    {
        //Arrange
        var valorEsperado = 100;
        var calcTest = new Calculadora();
        //Act
        var valorATestar = calcTest.Multiplicacao(10, 10);
        //Assert
        Assert.Equal(valorEsperado, valorATestar);
    }
    [Fact]
    public void TestandoSeDivisaoCalculaValorCorretamente()
    {
        //Arrange
        var valorEsperado = 1;
        var calcTest = new Calculadora();
        //Act
        var valorATestar = calcTest.Divisao(10, 10);
        //Assert
        Assert.Equal(valorEsperado, valorATestar);
    }
    
}