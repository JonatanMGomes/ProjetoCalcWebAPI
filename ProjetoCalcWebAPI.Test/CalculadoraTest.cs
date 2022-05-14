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
        var valorATestar = calcTest.Somar(5, 5);
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
        var valorATestar = calcTest.Subtrair(10, 5);
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
        var valorATestar = calcTest.Multiplicar(10, 10);
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
        var valorATestar = calcTest.Dividir(10, 10);
        //Assert
        Assert.Equal(valorEsperado, valorATestar);
    }
    
}